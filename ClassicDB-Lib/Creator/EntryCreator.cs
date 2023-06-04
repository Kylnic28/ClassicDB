using ClassicDB_Lib.Handler;
using MySql.Data.MySqlClient;

namespace ClassicDB_Lib.Creator
{
    public abstract class EntryCreator<T> where T : class
    {
        private readonly MySqlHandler _handler;
        private readonly string _tableName;
        protected MySqlHandler DatabaseHandler { get { return _handler; } }
        protected string Table { get { return _tableName; } }

        public EntryCreator(string tableName, MySqlHandler handler)
        {
            _tableName = tableName;
            _handler = handler;
        }

        /// <summary>
        /// Return current template.
        /// </summary>
        public abstract T GetTemplate { get; }

        /// <summary>
        /// Load an entry from database.
        /// </summary>
        /// <param name="entry">Entry</param>
        public abstract bool LoadFromDB(uint entry);

        /// <summary>
        /// Save instance of <see cref="T"/> in database.
        /// </summary>
        /// <returns>True if success, otherwise, false.</returns>
        public abstract bool SaveToDB();

        /// <summary>
        /// Get parameters for each template.
        /// </summary>
        /// <param name="template">Template</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Occurs when parameter is null./></exception>
        /// <exception cref="ArgumentException">Occurs when a mandatory entry isn't correctly set.</exception>
        public List<MySqlParameter> GetMySqlParameters(T template)
        {
            if (template == null)
                throw new ArgumentNullException("You must specify a template !");

            var parameters = new List<MySqlParameter>();

            var properties = typeof(T).GetProperties();

            foreach(var property in properties) 
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(template);
                var defaultValue = property.PropertyType.IsValueType ? Activator.CreateInstance(property.PropertyType) : null;
                var attributes = property.GetCustomAttributes(false);

                foreach(var attribute in attributes) {

                    var entryAttribute = (DatabaseEntryAttribute)attribute;

                    if (entryAttribute.IsMandatory && propertyValue!.Equals(defaultValue))
                        throw new ArgumentException($"{property.Name} is mandatory! Please, fill it correctly.");
                }

                parameters.Add(new(string.Concat('@', propertyName), propertyValue));
                
            }

            return parameters;
        }
    }
}
