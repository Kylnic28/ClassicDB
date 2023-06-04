using ClassicDB_Lib.Handler;
using MySql.Data.MySqlClient;

namespace ClassicDB_Lib.Creator
{
    public sealed class Item : EntryCreator<ItemTemplate>
    {
        private ItemTemplate _template;
        private bool _updateExistingEntry = false;
        private uint _oldEntry;

        public Item(MySqlHandler handler) : base("item_template", handler)
        {
            _template = new();
        }

        /// <summary>
        /// Get a copy of <see cref="ItemTemplate"/> instance. Only for reading purpose. For writing, use <see cref="Item"/> methods.
        /// </summary>
        public override ItemTemplate GetTemplate => new ItemTemplate(_template);
        public Item SetEntry(uint entry)
        {
            if (_updateExistingEntry)
                _oldEntry = _template.Entry;

            _template.Entry = entry;

            return this;
        }
        public Item SetPatch(byte patch)
        {
            _template.Patch = patch;
            return this;
        }
        public Item SetClass(byte itemClass)
        {
            _template.Class = itemClass;
            return this;
        }
        public Item SetSubClass(byte itemSubClass)
        {
            _template.Subclass = itemSubClass;
            return this;
        }
        public Item SetName(string name)
        {
            _template.Name = name;
            return this;
        }
        public Item SetDescription(string description)
        {
            _template.Description = description;
            return this;
        }
        public Item SetDisplayId(uint displayId)
        {
            _template.DisplayId = displayId;
            return this;
        }
        public Item SetQuality(byte quality)
        {
            _template.Quality = quality;
            return this;
        }
        public Item SetFlags(uint flags)
        {
            _template.Flags = flags;
            return this;
        }
        public Item SetBuyCount(byte buyCount)
        {
            _template.BuyCount = buyCount;
            return this;
        }
        public Item SetBuyPrice(uint buyPrice)
        {
            _template.BuyPrice = buyPrice;
            return this;
        }
        public Item SetSellPrice(uint sellPrice)
        {
            _template.SellPrice = sellPrice;
            return this;
        }
        public Item SetInventoryType(byte inventoryType)
        {
            _template.InventoryType = inventoryType;
            return this;
        }
        public Item SetAllowableClass(int allowableClass)
        {
            _template.AllowableClass = allowableClass;
            return this;
        }
        public Item SetAllowableRace(int allowableRace)
        {
            _template.AllowableRace = allowableRace;
            return this;
        }
        public Item SetItemLevel(byte itemLevel)
        {
            _template.ItemLevel = itemLevel;
            return this;
        }
        public Item SetRequiredLevel(byte requiredLevel)
        {
            _template.RequiredLevel = requiredLevel;
            return this;
        }
        public Item SetRequiredSkill(ushort requiredSkill)
        {
            _template.RequiredSkill = requiredSkill;
            return this;
        }
        public Item SetRequiredSkillRank(ushort requiredSkillRank)
        {
            _template.RequiredSkillRank = requiredSkillRank;
            return this;
        }
        public Item SetRequiredSpell(uint requiredSpell)
        {
            _template.RequiredSpell = requiredSpell;
            return this;
        }
        public Item SetRequiredHonorRank(uint honorRank)
        {
            _template.RequiredHonorRank = honorRank;
            return this;
        }
        public Item SetRequiredCityRank(uint cityRank)
        {
            _template.RequiredCityRank = cityRank;
            return this;
        }
        public Item SetRequiredReputationFaction(ushort requiredReputationFaction)
        {
            _template.RequiredReputationFaction = requiredReputationFaction;
            return this;
        }
        public Item SetRequiredReputationRank(ushort requiredReputationRank)
        {
            _template.RequiredReputationRank = requiredReputationRank;
            return this;
        }
        public Item SetMaxCount(ushort maxCount) 
        { 
            _template.MaxCount = maxCount; 
            return this; 
        }
        public Item SetStackable(ushort stackable) 
        { 
            _template.Stackable = stackable; 
            return this; 
        }
        public Item SetContainerSlots(byte containerSlots) 
        {
            _template.ContainerSlots = containerSlots; return this; 
        }
        public Item SetStatType1(byte statType1) 
        { 
            _template.StatType1 = statType1; 
            return this; 
        }
        public Item SetStatValue1(short statValue1) 
        { 
            _template.StatValue1 = statValue1;
            return this; 
        }
        public Item SetStatType2(byte statType2) 
        { 
            _template.StatType2 = statType2; 
            return this; 
        }
        public Item SetStatValue2(short statValue2) 
        { 
            _template.StatValue2 = statValue2; 
            return this; 
        }
        public Item SetStatType3(byte statType3) 
        { 
            _template.StatType3 = statType3; 
            return this; 
        }
        public Item SetStatValue3(short statValue3) 
        {
            _template.StatValue3 = statValue3; 
            return this; 
        }
        public Item SetStatType4(byte statType4)
        { 
            _template.StatType4 = statType4; 
            return this; 
        }
        public Item SetStatValue4(short statValue4) 
        {
            _template.StatValue4 = statValue4; 
            return this; 
        }
        public Item SetStatType5(byte statType5) 
        { 
            _template.StatType5 = statType5; 
            return this; 
        }
        public Item SetStatValue5(short statValue5) 
        { 
            _template.StatValue5 = statValue5; 
            return this; 
        }
        public Item SetStatType6(byte statType6) 
        { 
            _template.StatType6 = statType6; 
            return this; 
        }
        public Item SetStatValue6(short statValue6) 
        { 
            _template.StatValue6 = statValue6; 
            return this; 
        }
        public Item SetStatType7(byte statType7) 
        { 
            _template.StatType7 = statType7; 
            return this; 
        }
        public Item SetStatValue7(short statValue7) 
        {
            _template.StatValue7 = statValue7; 
            return this; 
        }
        public Item SetStatType8(byte statType8) 
        { 
            _template.StatType8 = statType8; 
            return this;
        }
        public Item SetStatValue8(short statValue8) 
        { 
            _template.StatValue8 = statValue8; 
            return this; 
        }
        public Item SetStatType9(byte statType9) 
        { 
            _template.StatType9 = statType9; 
            return this; 
        }
        public Item SetStatValue9(short statValue9) 
        {
            _template.StatValue9 = statValue9; 
            return this; 
        }
        public Item SetStatType10(byte statType10) 
        { 
            _template.StatType10 = statType10; 
            return this; 
        }
        public Item SetStatValue10(short statValue10) 
        { 
            _template.StatValue10 = statValue10; 
            return this;
        }
        public Item SetDelay(ushort delay) 
        { 
            _template.Delay = delay; 
            return this;
        }
        public Item SetRangeMod(float rangeMod) 
        { 
            _template.RangeMod = rangeMod; 
            return this; 
        }
        public Item SetAmmoType(byte ammoType) { _template.AmmoType = ammoType; return this; }
        public Item SetDmgMin1(float dmgMin1) { _template.DmgMin1 = dmgMin1; return this; }
        public Item SetDmgMax1(float dmgMax1) { _template.DmgMax1 = dmgMax1; return this; }
        public Item SetDmgType1(byte dmgType1) { _template.DmgType1 = dmgType1; return this; }
        public Item SetDmgMin2(float dmgMin2) { _template.DmgMin2 = dmgMin2; return this; }
        public Item SetDmgMax2(float dmgMax2) { _template.DmgMax2 = dmgMax2; return this; }
        public Item SetDmgType2(byte dmgType2) { _template.DmgType2 = dmgType2; return this; }
        public Item SetDmgMin3(float dmgMin3) { _template.DmgMin3 = dmgMin3; return this; }
        public Item SetDmgMax3(float dmgMax3) { _template.DmgMax3 = dmgMax3; return this; }
        public Item SetDmgType3(byte dmgType3) { _template.DmgType3 = dmgType3; return this; }
        public Item SetDmgMin4(float dmgMin4) { _template.DmgMin4 = dmgMin4; return this; }
        public Item SetDmgMax4(float dmgMax4) { _template.DmgMax4 = dmgMax4; return this; }
        public Item SetDmgType4(byte dmgType4) { _template.DmgType4 = dmgType4; return this; }
        public Item SetDmgMin5(float dmgMin5) { _template.DmgMin5 = dmgMin5; return this; }
        public Item SetDmgMax5(float dmgMax5) { _template.DmgMax5 = dmgMax5; return this; }
        public Item SetDmgType5(byte dmgType5) { _template.DmgType5 = dmgType5; return this; }
        public Item SetBlock(uint block) { _template.Block = block; return this; }
        public Item SetArmor(short armor) { _template.Armor = armor; return this; }
        public Item SetHolyRes(short holyRes) { _template.HolyRes = holyRes; return this; }
        public Item SetFireRes(short fireRes) { _template.FireRes = fireRes; return this; }
        public Item SetNatureRes(short natureRes) { _template.NatureRes = natureRes; return this; }
        public Item SetFrostRes(short frostRes) { _template.FrostRes = frostRes; return this; }
        public Item SetShadowRes(short shadowRes) { _template.ShadowRes = shadowRes; return this; }
        public Item SetArcaneRes(short arcaneRes) { _template.ArcaneRes = arcaneRes; return this; }
        public Item SetSpellid1(uint spellid1) { _template.Spellid1 = spellid1; return this; }
        public Item SetSpelltrigger1(byte spelltrigger1) { _template.Spelltrigger1 = spelltrigger1; return this; }
        public Item SetSpellcharges1(sbyte spellcharges1) { _template.Spellcharges1 = spellcharges1; return this; }
        public Item SetSpellppmrate1(float spellppmrate1) { _template.Spellppmrate1 = spellppmrate1; return this; }
        public Item SetSpellcooldown1(int spellcooldown1) { _template.Spellcooldown1 = spellcooldown1; return this; }
        public Item SetSpellcategory1(ushort spellcategory1) { _template.Spellcategory1 = spellcategory1; return this; }
        public Item SetSpellcategorycooldown1(int spellcategorycooldown1) { _template.Spellcategorycooldown1 = spellcategorycooldown1; return this; }
        public Item SetSpellid2(uint spellid2) { _template.Spellid2 = spellid2; return this; }
        public Item SetSpelltrigger2(byte spelltrigger2) { _template.Spelltrigger2 = spelltrigger2; return this; }
        public Item SetSpellcharges2(sbyte spellcharges2) { _template.Spellcharges2 = spellcharges2; return this; }
        public Item SetSpellppmrate2(float spellppmrate2) { _template.Spellppmrate2 = spellppmrate2; return this; }
        public Item SetSpellcooldown2(int spellcooldown2) { _template.Spellcooldown2 = spellcooldown2; return this; }
        public Item SetSpellcategory2(ushort spellcategory2) { _template.Spellcategory2 = spellcategory2; return this; }
        public Item SetSpellcategorycooldown2(int spellcategorycooldown2) { _template.Spellcategorycooldown2 = spellcategorycooldown2; return this; }
        public Item SetSpellid3(uint spellid3) { _template.Spellid3 = spellid3; return this; }
        public Item SetSpelltrigger3(byte spelltrigger3) { _template.Spelltrigger3 = spelltrigger3; return this; }
        public Item SetSpellcharges3(sbyte spellcharges3) { _template.Spellcharges3 = spellcharges3; return this; }
        public Item SetSpellppmrate3(float spellppmrate3) { _template.Spellppmrate3 = spellppmrate3; return this; }
        public Item SetSpellcooldown3(int spellcooldown3) { _template.Spellcooldown3 = spellcooldown3; return this; }
        public Item SetSpellcategory3(ushort spellcategory3) { _template.Spellcategory3 = spellcategory3; return this; }
        public Item SetSpellcategorycooldown3(int spellcategorycooldown3) { _template.Spellcategorycooldown3 = spellcategorycooldown3; return this; }
        public Item SetSpellid4(uint spellid4) { _template.Spellid4 = spellid4; return this; }
        public Item SetSpelltrigger4(byte spelltrigger4) { _template.Spelltrigger4 = spelltrigger4; return this; }
        public Item SetSpellcharges4(sbyte spellcharges4) { _template.Spellcharges4 = spellcharges4; return this; }
        public Item SetSpellppmrate4(float spellppmrate4) { _template.Spellppmrate4 = spellppmrate4; return this; }
        public Item SetSpellcooldown4(int spellcooldown4) { _template.Spellcooldown4 = spellcooldown4; return this; }
        public Item SetSpellcategory4(ushort spellcategory4) { _template.Spellcategory4 = spellcategory4; return this; }
        public Item SetSpellcategorycooldown4(int spellcategorycooldown4) { _template.Spellcategorycooldown4 = spellcategorycooldown4; return this; }
        public Item SetSpellid5(uint spellid5) { _template.Spellid5 = spellid5; return this; }
        public Item SetSpelltrigger5(byte spelltrigger5) { _template.Spelltrigger5 = spelltrigger5; return this; }
        public Item SetSpellcharges5(sbyte spellcharges5) { _template.Spellcharges5 = spellcharges5; return this; }
        public Item SetSpellppmrate5(float spellppmrate5) { _template.Spellppmrate5 = spellppmrate5; return this; }
        public Item SetSpellcooldown5(int spellcooldown5) { _template.Spellcooldown5 = spellcooldown5; return this; }
        public Item SetSpellcategory5(ushort spellcategory5) { _template.Spellcategory5 = spellcategory5; return this; }
        public Item SetSpellcategorycooldown5(int spellcategorycooldown5) { _template.Spellcategorycooldown5 = spellcategorycooldown5; return this; }
        public Item SetBonding(byte bonding) { _template.Bonding = bonding; return this; }
        public Item SetPageText(uint pageText) { _template.PageText = pageText; return this; }
        public Item SetPageLanguage(byte pageLanguage) 
        { 
            _template.PageLanguage = pageLanguage; 
            return this; 
        }
        public Item SetPageMaterial(byte pageMaterial) 
        { 
            _template.PageMaterial = pageMaterial; 
            return this; 
        }
        public Item SetStartQuest(uint startQuest) 
        {
            _template.StartQuest = startQuest;
            return this; 
        }
        public Item SetLockId(uint lockId) 
        { 
            _template.LockId = lockId; 
            return this; 
        }
        public Item SetMaterial(sbyte material) 
        { 
            _template.Material = material; 
            return this; 
        }
        public Item SetSheath(byte sheath) 
        { 
            _template.Sheath = sheath; 
            return this; 
        }
        public Item SetRandomProperty(uint randomProperty) 
        { 
            _template.RandomProperty = randomProperty; 
            return this; 
        }
        public Item SetSetId(uint setId) 
        {
            _template.SetId = setId; 
            return this;
        }
        public Item SetMaxDurability(ushort maxDurability) 
        { 
            _template.MaxDurability = maxDurability; 
            return this; 
        }
        public Item SetAreaBound(uint areaBound) 
        { 
            _template.AreaBound = areaBound; 
            return this;
        }
        public Item SetMapBound(short mapBound) 
        { 
            _template.MapBound = mapBound; 
            return this; 
        }
        public Item SetDuration(uint duration) 
        { 
            _template.Duration = duration; 
            return this; 
        }
        public Item SetBagFamily(int bagFamily) 
        { 
            _template.BagFamily = bagFamily;
            return this; 
        }
        public Item SetDisenchantId(uint disenchantId) 
        { 
            _template.DisenchantId = disenchantId; 
            return this; 
        }
        public Item SetFoodType(byte foodType)
        {
            _template.FoodType = foodType; 
            return this; 
        }
        public Item SetMinMoneyLoot(uint minMoneyLoot) 
        {
            _template.MinMoneyLoot = minMoneyLoot; 
            return this; 
        }
        public Item SetMaxMoneyLoot(uint maxMoneyLoot)
        { 
            _template.MaxMoneyLoot = maxMoneyLoot; 
            return this; 
        }
        public Item SetWrappedGift(uint wrappedGift) 
        {
            _template.WrappedGift = wrappedGift; 
            return this; 
        }
        public Item SetExtraFlags(byte extraFlags) 
        {
            _template.ExtraFlags = extraFlags; 
            return this; 
        }
        public Item SetOtherTeamEntry(uint otherTeamEntry) 
        {
            _template.OtherTeamEntry = otherTeamEntry; return this; 
        }
        public Item SetItemTemplate(ItemTemplate template)
        {
            if (template == null)
                throw new ArgumentNullException(nameof(template));

            _template = template;

            return this;
        }

        public override bool SaveToDB()
        {
            var parameters = GetMySqlParameters(_template);

            return DatabaseHandler.ApplyToDatabase(_updateExistingEntry == true ? _template.UpdateQuery() : _template.InsertQuery(), parameters);
        }

        public override bool LoadFromDB(uint entry)
        {
            _updateExistingEntry = true;
            _oldEntry = entry;

            string query = $"SELECT * FROM {Table} WHERE Entry = @Entry";

            try
            {
                DatabaseHandler.Open();

                using var cmd = new MySqlCommand(query, DatabaseHandler.Instance);
                cmd.Parameters.Add(new("@Entry", entry));

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows && reader.Read())
                    _template = new ItemTemplate(reader);
                else
                    return false;
              

                return true;
            }
            catch (MySqlException ex) {

                Console.WriteLine(ex);
                return false; 
            }
            finally { DatabaseHandler.Close(); }
            

        }


    }
}
