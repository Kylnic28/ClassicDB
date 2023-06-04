using ClassicDB_Lib.Creator;
using MySql.Data.MySqlClient;

public class ItemTemplate
{

    [DatabaseEntry(isMandatory: true)]
    public uint Entry { get; set; }
    public byte Patch { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public byte Class { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public byte Subclass { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public string? Name { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public string? Description { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public uint DisplayId { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public byte Quality { get; set; }
    public uint Flags { get; set; }
    public byte BuyCount { get; set; }
    public uint BuyPrice { get; set; }
    public uint SellPrice { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public byte InventoryType { get; set; }
    public int AllowableClass { get; set; }
    public int AllowableRace { get; set; }
    public byte ItemLevel { get; set; }

    [DatabaseEntry(isMandatory: true)]
    public byte RequiredLevel { get; set; }
    public ushort RequiredSkill { get; set; }
    public ushort RequiredSkillRank { get; set; }
    public uint RequiredSpell { get; set; }
    public uint RequiredHonorRank { get; set; }
    public uint RequiredCityRank { get; set; }
    public ushort RequiredReputationFaction { get; set; }
    public ushort RequiredReputationRank { get; set; }
    public ushort MaxCount { get; set; }
    public ushort Stackable { get; set; }
    public byte ContainerSlots { get; set; }
    public byte StatType1 { get; set; }
    public short StatValue1 { get; set; }
    public byte StatType2 { get; set; }
    public short StatValue2 { get; set; }
    public byte StatType3 { get; set; }
    public short StatValue3 { get; set; }
    public byte StatType4 { get; set; }
    public short StatValue4 { get; set; }
    public byte StatType5 { get; set; }
    public short StatValue5 { get; set; }
    public byte StatType6 { get; set; }
    public short StatValue6 { get; set; }
    public byte StatType7 { get; set; }
    public short StatValue7 { get; set; }
    public byte StatType8 { get; set; }
    public short StatValue8 { get; set; }
    public byte StatType9 { get; set; }
    public short StatValue9 { get; set; }
    public byte StatType10 { get; set; }
    public short StatValue10 { get; set; }
    public ushort Delay { get; set; }
    public float RangeMod { get; set; }
    public byte AmmoType { get; set; }
    public float DmgMin1 { get; set; }
    public float DmgMax1 { get; set; }
    public byte DmgType1 { get; set; }
    public float DmgMin2 { get; set; }
    public float DmgMax2 { get; set; }
    public byte DmgType2 { get; set; }
    public float DmgMin3 { get; set; }
    public float DmgMax3 { get; set; }
    public byte DmgType3 { get; set; }
    public float DmgMin4 { get; set; }
    public float DmgMax4 { get; set; }
    public byte DmgType4 { get; set; }
    public float DmgMin5 { get; set; }
    public float DmgMax5 { get; set; }
    public byte DmgType5 { get; set; }
    public uint Block { get; set; }
    public short Armor { get; set; }
    public short HolyRes { get; set; }
    public short FireRes { get; set; }
    public short NatureRes { get; set; }
    public short FrostRes { get; set; }
    public short ShadowRes { get; set; }
    public short ArcaneRes { get; set; }
    public uint Spellid1 { get; set; }
    public byte Spelltrigger1 { get; set; }
    public sbyte Spellcharges1 { get; set; }
    public float Spellppmrate1 { get; set; }
    public int Spellcooldown1 { get; set; }
    public ushort Spellcategory1 { get; set; }
    public int Spellcategorycooldown1 { get; set; }
    public uint Spellid2 { get; set; }
    public byte Spelltrigger2 { get; set; }
    public sbyte Spellcharges2 { get; set; }
    public float Spellppmrate2 { get; set; }
    public int Spellcooldown2 { get; set; }
    public ushort Spellcategory2 { get; set; }
    public int Spellcategorycooldown2 { get; set; }
    public uint Spellid3 { get; set; }
    public byte Spelltrigger3 { get; set; }
    public sbyte Spellcharges3 { get; set; }
    public float Spellppmrate3 { get; set; }
    public int Spellcooldown3 { get; set; }
    public ushort Spellcategory3 { get; set; }
    public int Spellcategorycooldown3 { get; set; }
    public uint Spellid4 { get; set; }
    public byte Spelltrigger4 { get; set; }
    public sbyte Spellcharges4 { get; set; }
    public float Spellppmrate4 { get; set; }
    public int Spellcooldown4 { get; set; }
    public ushort Spellcategory4 { get; set; }
    public int Spellcategorycooldown4 { get; set; }
    public uint Spellid5 { get; set; }
    public byte Spelltrigger5 { get; set; }
    public sbyte Spellcharges5 { get; set; }
    public float Spellppmrate5 { get; set; }
    public int Spellcooldown5 { get; set; }
    public ushort Spellcategory5 { get; set; }
    public int Spellcategorycooldown5 { get; set; }
    public byte Bonding { get; set; }
    public uint PageText { get; set; }
    public byte PageLanguage { get; set; }
    public byte PageMaterial { get; set; }
    public uint StartQuest { get; set; }
    public uint LockId { get; set; }
    public sbyte Material { get; set; }
    public byte Sheath { get; set; }
    public uint RandomProperty { get; set; }
    public uint SetId { get; set; }
    public ushort MaxDurability { get; set; }
    public uint AreaBound { get; set; }
    public short MapBound { get; set; }
    public uint Duration { get; set; }
    public int BagFamily { get; set; }
    public uint DisenchantId { get; set; }
    public byte FoodType { get; set; }
    public uint MinMoneyLoot { get; set; }
    public uint MaxMoneyLoot { get; set; }
    public uint WrappedGift { get; set; }
    public byte ExtraFlags { get; set; }
    public uint OtherTeamEntry { get; set; }

    /// <summary>
    /// Empty constructor
    /// </summary>
    public ItemTemplate() { }

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="clone">Clone</param>
    public ItemTemplate(ItemTemplate clone)
    {
        this.Entry = clone.Entry;
        this.Patch = clone.Patch;
        this.Class = clone.Class;
        this.Subclass = clone.Subclass;
        this.Name = clone.Name;
        this.Description = clone.Description;
        this.DisplayId = clone.DisplayId;
        this.Quality = clone.Quality;
        this.Flags = clone.Flags;
        this.BuyCount = clone.BuyCount;
        this.BuyPrice = clone.BuyPrice;
        this.SellPrice = clone.SellPrice;
        this.InventoryType = clone.InventoryType;
        this.AllowableClass = clone.AllowableClass;
        this.AllowableRace = clone.AllowableRace;
        this.ItemLevel = clone.ItemLevel;
        this.RequiredLevel = clone.RequiredLevel;
        this.RequiredSkill = clone.RequiredSkill;
        this.RequiredSkillRank = clone.RequiredSkillRank;
        this.RequiredSpell = clone.RequiredSpell;
        this.RequiredHonorRank = clone.RequiredHonorRank;
        this.RequiredCityRank = clone.RequiredCityRank;
        this.RequiredReputationFaction = clone.RequiredReputationFaction;
        this.RequiredReputationRank = clone.RequiredReputationRank;
        this.MaxCount = clone.MaxCount;
        this.Stackable = clone.Stackable;
        this.ContainerSlots = clone.ContainerSlots;
        this.StatType1 = clone.StatType1;
        this.StatValue1 = clone.StatValue1;
        this.StatType2 = clone.StatType2;
        this.StatValue2 = clone.StatValue2;
        this.StatType3 = clone.StatType3;
        this.StatValue3 = clone.StatValue3;
        this.StatType4 = clone.StatType4;
        this.StatValue4 = clone.StatValue4;
        this.StatType5 = clone.StatType5;
        this.StatValue5 = clone.StatValue5;
        this.StatType6 = clone.StatType6;
        this.StatValue6 = clone.StatValue6;
        this.StatType7 = clone.StatType7;
        this.StatValue7 = clone.StatValue7;
        this.StatType8 = clone.StatType8;
        this.StatValue8 = clone.StatValue8;
        this.StatType9 = clone.StatType9;
        this.StatValue9 = clone.StatValue9;
        this.StatType10 = clone.StatType10;
        this.StatValue10 = clone.StatValue10;
        this.Delay = clone.Delay;
        this.RangeMod = clone.RangeMod;
        this.AmmoType = clone.AmmoType;
        this.DmgMin1 = clone.DmgMin1;
        this.DmgMax1 = clone.DmgMax1;
        this.DmgType1 = clone.DmgType1;
        this.DmgMin2 = clone.DmgMin2;
        this.DmgMax2 = clone.DmgMax2;
        this.DmgType2 = clone.DmgType2;
        this.DmgMin3 = clone.DmgMin3;
        this.DmgMax3 = clone.DmgMax3;
        this.DmgType3 = clone.DmgType3;
        this.DmgMin4 = clone.DmgMin4;
        this.DmgMax4 = clone.DmgMax4;
        this.DmgType4 = clone.DmgType4;
        this.DmgMin5 = clone.DmgMin5;
        this.DmgMax5 = clone.DmgMax5;
        this.DmgType5 = clone.DmgType5;
        this.Block = clone.Block;
        this.Armor = clone.Armor;
        this.HolyRes = clone.HolyRes;
        this.FireRes = clone.FireRes;
        this.NatureRes = clone.NatureRes;
        this.FrostRes = clone.FrostRes;
        this.ShadowRes = clone.ShadowRes;
        this.ArcaneRes = clone.ArcaneRes;
        this.Spellid1 = clone.Spellid1;
        this.Spelltrigger1 = clone.Spelltrigger1;
        this.Spellcharges1 = clone.Spellcharges1;
        this.Spellppmrate1 = clone.Spellppmrate1;
        this.Spellcooldown1 = clone.Spellcooldown1;
        this.Spellcategory1 = clone.Spellcategory1;
        this.Spellcategorycooldown1 = clone.Spellcategorycooldown1;
        this.Spellid2 = clone.Spellid2;
        this.Spelltrigger2 = clone.Spelltrigger2;
        this.Spellcharges2 = clone.Spellcharges2;
        this.Spellppmrate2 = clone.Spellppmrate2;
        this.Spellcooldown2 = clone.Spellcooldown2;
        this.Spellcategory2 = clone.Spellcategory2;
        this.Spellcategorycooldown2 = clone.Spellcategorycooldown2;
        this.Spellid3 = clone.Spellid3;
        this.Spelltrigger3 = clone.Spelltrigger3;
        this.Spellcharges3 = clone.Spellcharges3;
        this.Spellppmrate3 = clone.Spellppmrate3;
        this.Spellcooldown3 = clone.Spellcooldown3;
        this.Spellcategory3 = clone.Spellcategory3;
        this.Spellcategorycooldown3 = clone.Spellcategorycooldown3;
        this.Spellid4 = clone.Spellid4;
        this.Spelltrigger4 = clone.Spelltrigger4;
        this.Spellcharges4 = clone.Spellcharges4;
        this.Spellppmrate4 = clone.Spellppmrate4;
        this.Spellcooldown4 = clone.Spellcooldown4;
        this.Spellcategory4 = clone.Spellcategory4;
        this.Spellcategorycooldown4 = clone.Spellcategorycooldown4;
        this.Spellid5 = clone.Spellid5;
        this.Spelltrigger5 = clone.Spelltrigger5;
        this.Spellcharges5 = clone.Spellcharges5;
        this.Spellppmrate5 = clone.Spellppmrate5;
        this.Spellcooldown5 = clone.Spellcooldown5;
        this.Spellcategory5 = clone.Spellcategory5;
        this.Spellcategorycooldown5 = clone.Spellcategorycooldown5;
        this.Bonding = clone.Bonding;
        this.PageText = clone.PageText;
        this.PageLanguage = clone.PageLanguage;
        this.PageMaterial = clone.PageMaterial;
        this.StartQuest = clone.StartQuest;
        this.LockId = clone.LockId;
        this.Material = clone.Material;
        this.Sheath = clone.Sheath;
        this.RandomProperty = clone.RandomProperty;
        this.SetId = clone.SetId;
        this.MaxDurability = clone.MaxDurability;
        this.AreaBound = clone.AreaBound;
        this.MapBound = clone.MapBound;
        this.Duration = clone.Duration;
        this.BagFamily = clone.BagFamily;
        this.DisenchantId = clone.DisenchantId;
        this.FoodType = clone.FoodType;
        this.MinMoneyLoot = clone.MinMoneyLoot;
        this.MaxMoneyLoot = clone.MaxMoneyLoot;
        this.WrappedGift = clone.WrappedGift;
        this.ExtraFlags = clone.ExtraFlags;
        this.OtherTeamEntry = clone.OtherTeamEntry;
    }

    /// <summary>
    /// Initialize instance through database.
    /// </summary>
    /// <param name="reader">MySql Reader</param>
    public ItemTemplate(MySqlDataReader reader)
    {
        this.Entry = reader.GetUInt32("entry");
        this.Patch = reader.GetByte("patch");
        this.Class = reader.GetByte("class");
        this.Subclass = reader.GetByte("subclass");
        this.Name = reader.GetString("name");
        this.Description = reader.GetString("description");
        this.DisplayId = reader.GetUInt32("display_id");
        this.Quality = reader.GetByte("quality");
        this.Flags = reader.GetUInt32("flags");
        this.BuyCount = reader.GetByte("buy_count");
        this.BuyPrice = reader.GetUInt32("buy_price");
        this.SellPrice = reader.GetUInt32("sell_price");
        this.InventoryType = reader.GetByte("inventory_type");
        this.AllowableClass = reader.GetInt32("allowable_class");
        this.AllowableRace = reader.GetInt32("allowable_race");
        this.ItemLevel = reader.GetByte("item_level");
        this.RequiredLevel = reader.GetByte("required_level");
        this.RequiredSkill = reader.GetUInt16("required_skill");
        this.RequiredSkillRank = reader.GetUInt16("required_skill_rank");
        this.RequiredSpell = reader.GetUInt32("required_spell");
        this.RequiredHonorRank = reader.GetUInt32("required_honor_rank");
        this.RequiredCityRank = reader.GetUInt32("required_city_rank");
        this.RequiredReputationFaction = reader.GetUInt16("required_reputation_faction");
        this.RequiredReputationRank = reader.GetUInt16("required_reputation_rank");
        this.MaxCount = reader.GetUInt16("max_count");
        this.Stackable = reader.GetUInt16("stackable");
        this.ContainerSlots = reader.GetByte("container_slots");
        this.StatType1 = reader.GetByte("stat_type1");
        this.StatValue1 = reader.GetInt16("stat_value1");
        this.StatType2 = reader.GetByte("stat_type2");
        this.StatValue2 = reader.GetInt16("stat_value2");
        this.StatType3 = reader.GetByte("stat_type3");
        this.StatValue3 = reader.GetInt16("stat_value3");
        this.StatType4 = reader.GetByte("stat_type4");
        this.StatValue4 = reader.GetInt16("stat_value4");
        this.StatType5 = reader.GetByte("stat_type5");
        this.StatValue5 = reader.GetInt16("stat_value5");
        this.StatType6 = reader.GetByte("stat_type6");
        this.StatValue6 = reader.GetInt16("stat_value6");
        this.StatType7 = reader.GetByte("stat_type7");
        this.StatValue7 = reader.GetInt16("stat_value7");
        this.StatType8 = reader.GetByte("stat_type8");
        this.StatValue8 = reader.GetInt16("stat_value8");
        this.StatType9 = reader.GetByte("stat_type9");
        this.StatValue9 = reader.GetInt16("stat_value9");
        this.StatType10 = reader.GetByte("stat_type10");
        this.StatValue10 = reader.GetInt16("stat_value10");
        this.Delay = reader.GetUInt16("delay");
        this.RangeMod = reader.GetFloat("range_mod");
        this.AmmoType = reader.GetByte("ammo_type");
        this.DmgMin1 = reader.GetFloat("dmg_min1");
        this.DmgMax1 = reader.GetFloat("dmg_max1");
        this.DmgType1 = reader.GetByte("dmg_type1");
        this.DmgMin2 = reader.GetFloat("dmg_min2");
        this.DmgMax2 = reader.GetFloat("dmg_max2");
        this.DmgType2 = reader.GetByte("dmg_type2");
        this.DmgMin3 = reader.GetFloat("dmg_min3");
        this.DmgMax3 = reader.GetFloat("dmg_max3");
        this.DmgType3 = reader.GetByte("dmg_type3");
        this.DmgMin4 = reader.GetFloat("dmg_min4");
        this.DmgMax4 = reader.GetFloat("dmg_max4");
        this.DmgType4 = reader.GetByte("dmg_type4");
        this.DmgMin5 = reader.GetFloat("dmg_min5");
        this.DmgMax5 = reader.GetFloat("dmg_max5");
        this.DmgType5 = reader.GetByte("dmg_type5");
        this.Block = reader.GetUInt32("block");
        this.Armor = reader.GetInt16("armor");
        this.HolyRes = reader.GetInt16("holy_res");
        this.FireRes = reader.GetInt16("fire_res");
        this.NatureRes = reader.GetInt16("nature_res");
        this.FrostRes = reader.GetInt16("frost_res");
        this.ShadowRes = reader.GetInt16("shadow_res");
        this.ArcaneRes = reader.GetInt16("arcane_res");
        this.Spellid1 = reader.GetUInt32("spellid_1");
        this.Spelltrigger1 = reader.GetByte("spelltrigger_1");
        this.Spellcharges1 = reader.GetSByte("spellcharges_1");
        this.Spellppmrate1 = reader.GetFloat("spellppmrate_1");
        this.Spellcooldown1 = reader.GetInt32("spellcooldown_1");
        this.Spellcategory1 = reader.GetUInt16("spellcategory_1");
        this.Spellcategorycooldown1 = reader.GetInt32("spellcategorycooldown_1");
        this.Spellid2 = reader.GetUInt32("spellid_2");
        this.Spelltrigger2 = reader.GetByte("spelltrigger_2");
        this.Spellcharges2 = reader.GetSByte("spellcharges_2");
        this.Spellppmrate2 = reader.GetFloat("spellppmrate_2");
        this.Spellcooldown2 = reader.GetInt32("spellcooldown_2");
        this.Spellcategory2 = reader.GetUInt16("spellcategory_2");
        this.Spellcategorycooldown2 = reader.GetInt32("spellcategorycooldown_2");
        this.Spellid3 = reader.GetUInt32("spellid_3");
        this.Spelltrigger3 = reader.GetByte("spelltrigger_3");
        this.Spellcharges3 = reader.GetSByte("spellcharges_3");
        this.Spellppmrate3 = reader.GetFloat("spellppmrate_3");
        this.Spellcooldown3 = reader.GetInt32("spellcooldown_3");
        this.Spellcategory3 = reader.GetUInt16("spellcategory_3");
        this.Spellcategorycooldown3 = reader.GetInt32("spellcategorycooldown_3");
        this.Spellid4 = reader.GetUInt32("spellid_4");
        this.Spelltrigger4 = reader.GetByte("spelltrigger_4");
        this.Spellcharges4 = reader.GetSByte("spellcharges_4");
        this.Spellppmrate4 = reader.GetFloat("spellppmrate_4");
        this.Spellcooldown4 = reader.GetInt32("spellcooldown_4");
        this.Spellcategory4 = reader.GetUInt16("spellcategory_4");
        this.Spellcategorycooldown4 = reader.GetInt32("spellcategorycooldown_4");
        this.Spellid5 = reader.GetUInt32("spellid_5");
        this.Spelltrigger5 = reader.GetByte("spelltrigger_5");
        this.Spellcharges5 = reader.GetSByte("spellcharges_5");
        this.Spellppmrate5 = reader.GetFloat("spellppmrate_5");
        this.Spellcooldown5 = reader.GetInt32("spellcooldown_5");
        this.Spellcategory5 = reader.GetUInt16("spellcategory_5");
        this.Spellcategorycooldown5 = reader.GetInt32("spellcategorycooldown_5");
        this.Bonding = reader.GetByte("bonding");
        this.PageText = reader.GetUInt32("page_text");
        this.PageLanguage = reader.GetByte("page_language");
        this.PageMaterial = reader.GetByte("page_material");
        this.StartQuest = reader.GetUInt32("start_quest");
        this.LockId = reader.GetUInt32("lock_id");
        this.Material = reader.GetSByte("material");
        this.Sheath = reader.GetByte("sheath");
        this.RandomProperty = reader.GetUInt32("random_property");
        this.SetId = reader.GetUInt32("set_id");
        this.MaxDurability = reader.GetUInt16("max_durability");
        this.AreaBound = reader.GetUInt32("area_bound");
        this.MapBound = reader.GetInt16("map_bound");
        this.Duration = reader.GetUInt32("duration");
        this.BagFamily = reader.GetInt32("bag_family");
        this.DisenchantId = reader.GetUInt32("disenchant_id");
        this.FoodType = reader.GetByte("food_type");
        this.MinMoneyLoot = reader.GetUInt32("min_money_loot");
        this.MaxMoneyLoot = reader.GetUInt32("max_money_loot");
        this.WrappedGift = reader.GetUInt32("wrapped_gift");
        this.ExtraFlags = reader.GetByte("extra_flags");
        this.OtherTeamEntry = reader.GetUInt32("other_team_entry");
    }

    public ItemTemplate(uint entry, byte patch, byte @class, byte subclass, string name, string description, uint displayId, byte quality, uint flags, byte buyCount, uint buyPrice, uint sellPrice, byte inventoryType, int allowableClass, int allowableRace, byte itemLevel, byte requiredLevel, ushort requiredSkill, ushort requiredSkillRank, uint requiredSpell, uint requiredHonorRank, uint requiredCityRank, ushort requiredReputationFaction, ushort requiredReputationRank, ushort maxCount, ushort stackable, byte containerSlots, byte statType1, short statValue1, byte statType2, short statValue2, byte statType3, short statValue3, byte statType4, short statValue4, byte statType5, short statValue5, byte statType6, short statValue6, byte statType7, short statValue7, byte statType8, short statValue8, byte statType9, short statValue9, byte statType10, short statValue10, ushort delay, float rangeMod, byte ammoType, float dmgMin1, float dmgMax1, byte dmgType1, float dmgMin2, float dmgMax2, byte dmgType2, float dmgMin3, float dmgMax3, byte dmgType3, float dmgMin4, float dmgMax4, byte dmgType4, float dmgMin5, float dmgMax5, byte dmgType5, uint block, short armor, short holyRes, short fireRes, short natureRes, short frostRes, short shadowRes, short arcaneRes, uint spellid1, byte spelltrigger1, sbyte spellcharges1, float spellppmrate1, int spellcooldown1, ushort spellcategory1, int spellcategorycooldown1, uint spellid2, byte spelltrigger2, sbyte spellcharges2, float spellppmrate2, int spellcooldown2, ushort spellcategory2, int spellcategorycooldown2, uint spellid3, byte spelltrigger3, sbyte spellcharges3, float spellppmrate3, int spellcooldown3, ushort spellcategory3, int spellcategorycooldown3, uint spellid4, byte spelltrigger4, sbyte spellcharges4, float spellppmrate4, int spellcooldown4, ushort spellcategory4, int spellcategorycooldown4, uint spellid5, byte spelltrigger5, sbyte spellcharges5, float spellppmrate5, int spellcooldown5, ushort spellcategory5, int spellcategorycooldown5, byte bonding, uint pageText, byte pageLanguage, byte pageMaterial, uint startQuest, uint lockId, sbyte material, byte sheath, uint randomProperty, uint setId, ushort maxDurability, uint areaBound, short mapBound, uint duration, int bagFamily, uint disenchantId, byte foodType, uint minMoneyLoot, uint maxMoneyLoot, uint wrappedGift, byte extraFlags, uint otherTeamEntry)
    {
        Entry = entry;
        Patch = patch;
        Class = @class;
        Subclass = subclass;
        Name = name;
        Description = description;
        DisplayId = displayId;
        Quality = quality;
        Flags = flags;
        BuyCount = buyCount;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
        InventoryType = inventoryType;
        AllowableClass = allowableClass;
        AllowableRace = allowableRace;
        ItemLevel = itemLevel;
        RequiredLevel = requiredLevel;
        RequiredSkill = requiredSkill;
        RequiredSkillRank = requiredSkillRank;
        RequiredSpell = requiredSpell;
        RequiredHonorRank = requiredHonorRank;
        RequiredCityRank = requiredCityRank;
        RequiredReputationFaction = requiredReputationFaction;
        RequiredReputationRank = requiredReputationRank;
        MaxCount = maxCount;
        Stackable = stackable;
        ContainerSlots = containerSlots;
        StatType1 = statType1;
        StatValue1 = statValue1;
        StatType2 = statType2;
        StatValue2 = statValue2;
        StatType3 = statType3;
        StatValue3 = statValue3;
        StatType4 = statType4;
        StatValue4 = statValue4;
        StatType5 = statType5;
        StatValue5 = statValue5;
        StatType6 = statType6;
        StatValue6 = statValue6;
        StatType7 = statType7;
        StatValue7 = statValue7;
        StatType8 = statType8;
        StatValue8 = statValue8;
        StatType9 = statType9;
        StatValue9 = statValue9;
        StatType10 = statType10;
        StatValue10 = statValue10;
        Delay = delay;
        RangeMod = rangeMod;
        AmmoType = ammoType;
        DmgMin1 = dmgMin1;
        DmgMax1 = dmgMax1;
        DmgType1 = dmgType1;
        DmgMin2 = dmgMin2;
        DmgMax2 = dmgMax2;
        DmgType2 = dmgType2;
        DmgMin3 = dmgMin3;
        DmgMax3 = dmgMax3;
        DmgType3 = dmgType3;
        DmgMin4 = dmgMin4;
        DmgMax4 = dmgMax4;
        DmgType4 = dmgType4;
        DmgMin5 = dmgMin5;
        DmgMax5 = dmgMax5;
        DmgType5 = dmgType5;
        Block = block;
        Armor = armor;
        HolyRes = holyRes;
        FireRes = fireRes;
        NatureRes = natureRes;
        FrostRes = frostRes;
        ShadowRes = shadowRes;
        ArcaneRes = arcaneRes;
        Spellid1 = spellid1;
        Spelltrigger1 = spelltrigger1;
        Spellcharges1 = spellcharges1;
        Spellppmrate1 = spellppmrate1;
        Spellcooldown1 = spellcooldown1;
        Spellcategory1 = spellcategory1;
        Spellcategorycooldown1 = spellcategorycooldown1;
        Spellid2 = spellid2;
        Spelltrigger2 = spelltrigger2;
        Spellcharges2 = spellcharges2;
        Spellppmrate2 = spellppmrate2;
        Spellcooldown2 = spellcooldown2;
        Spellcategory2 = spellcategory2;
        Spellcategorycooldown2 = spellcategorycooldown2;
        Spellid3 = spellid3;
        Spelltrigger3 = spelltrigger3;
        Spellcharges3 = spellcharges3;
        Spellppmrate3 = spellppmrate3;
        Spellcooldown3 = spellcooldown3;
        Spellcategory3 = spellcategory3;
        Spellcategorycooldown3 = spellcategorycooldown3;
        Spellid4 = spellid4;
        Spelltrigger4 = spelltrigger4;
        Spellcharges4 = spellcharges4;
        Spellppmrate4 = spellppmrate4;
        Spellcooldown4 = spellcooldown4;
        Spellcategory4 = spellcategory4;
        Spellcategorycooldown4 = spellcategorycooldown4;
        Spellid5 = spellid5;
        Spelltrigger5 = spelltrigger5;
        Spellcharges5 = spellcharges5;
        Spellppmrate5 = spellppmrate5;
        Spellcooldown5 = spellcooldown5;
        Spellcategory5 = spellcategory5;
        Spellcategorycooldown5 = spellcategorycooldown5;
        Bonding = bonding;
        PageText = pageText;
        PageLanguage = pageLanguage;
        PageMaterial = pageMaterial;
        StartQuest = startQuest;
        LockId = lockId;
        Material = material;
        Sheath = sheath;
        RandomProperty = randomProperty;
        SetId = setId;
        MaxDurability = maxDurability;
        AreaBound = areaBound;
        MapBound = mapBound;
        Duration = duration;
        BagFamily = bagFamily;
        DisenchantId = disenchantId;
        FoodType = foodType;
        MinMoneyLoot = minMoneyLoot;
        MaxMoneyLoot = maxMoneyLoot;
        WrappedGift = wrappedGift;
        ExtraFlags = extraFlags;
        OtherTeamEntry = otherTeamEntry;
    }

    public string InsertQuery()
    {
        return "INSERT INTO item_template (entry,patch,class,subclass,name,description,display_id,quality,flags,buy_count,buy_price,sell_price,inventory_type,allowable_class,allowable_race,item_level,required_level,required_skill,required_skill_rank,required_spell,required_honor_rank,required_city_rank,required_reputation_faction,required_reputation_rank,max_count,stackable,container_slots,stat_type1,stat_value1,stat_type2,stat_value2,stat_type3,stat_value3,stat_type4,stat_value4,stat_type5,stat_value5,stat_type6,stat_value6,stat_type7,stat_value7,stat_type8,stat_value8,stat_type9,stat_value9,stat_type10,stat_value10,delay,range_mod,ammo_type,dmg_min1,dmg_max1,dmg_type1,dmg_min2,dmg_max2,dmg_type2,dmg_min3,dmg_max3,dmg_type3,dmg_min4,dmg_max4,dmg_type4,dmg_min5,dmg_max5,dmg_type5,block,armor,holy_res,fire_res,nature_res,frost_res,shadow_res,arcane_res,spellid_1,spelltrigger_1,spellcharges_1,spellppmrate_1,spellcooldown_1,spellcategory_1,spellcategorycooldown_1,spellid_2,spelltrigger_2,spellcharges_2,spellppmrate_2,spellcooldown_2,spellcategory_2,spellcategorycooldown_2,spellid_3,spelltrigger_3,spellcharges_3,spellppmrate_3,spellcooldown_3,spellcategory_3,spellcategorycooldown_3,spellid_4,spelltrigger_4,spellcharges_4,spellppmrate_4,spellcooldown_4,spellcategory_4,spellcategorycooldown_4,spellid_5,spelltrigger_5,spellcharges_5,spellppmrate_5,spellcooldown_5,spellcategory_5,spellcategorycooldown_5,bonding,page_text,page_language,page_material,start_quest,lock_id,material,sheath,random_property,set_id,max_durability,area_bound,map_bound,duration,bag_family,disenchant_id,food_type,min_money_loot,max_money_loot,wrapped_gift,extra_flags,other_team_entry) VALUES (@Entry,@Patch,@Class,@Subclass,@Name,@Description,@DisplayId,@Quality,@Flags,@BuyCount,@BuyPrice,@SellPrice,@InventoryType,@AllowableClass,@AllowableRace,@ItemLevel,@RequiredLevel,@RequiredSkill,@RequiredSkillRank,@RequiredSpell,@RequiredHonorRank,@RequiredCityRank,@RequiredReputationFaction,@RequiredReputationRank,@MaxCount,@Stackable,@ContainerSlots,@StatType1,@StatValue1,@StatType2,@StatValue2,@StatType3,@StatValue3,@StatType4,@StatValue4,@StatType5,@StatValue5,@StatType6,@StatValue6,@StatType7,@StatValue7,@StatType8,@StatValue8,@StatType9,@StatValue9,@StatType10,@StatValue10,@Delay,@RangeMod,@AmmoType,@DmgMin1,@DmgMax1,@DmgType1,@DmgMin2,@DmgMax2,@DmgType2,@DmgMin3,@DmgMax3,@DmgType3,@DmgMin4,@DmgMax4,@DmgType4,@DmgMin5,@DmgMax5,@DmgType5,@Block,@Armor,@HolyRes,@FireRes,@NatureRes,@FrostRes,@ShadowRes,@ArcaneRes,@Spellid1,@Spelltrigger1,@Spellcharges1,@Spellppmrate1,@Spellcooldown1,@Spellcategory1,@Spellcategorycooldown1,@Spellid2,@Spelltrigger2,@Spellcharges2,@Spellppmrate2,@Spellcooldown2,@Spellcategory2,@Spellcategorycooldown2,@Spellid3,@Spelltrigger3,@Spellcharges3,@Spellppmrate3,@Spellcooldown3,@Spellcategory3,@Spellcategorycooldown3,@Spellid4,@Spelltrigger4,@Spellcharges4,@Spellppmrate4,@Spellcooldown4,@Spellcategory4,@Spellcategorycooldown4,@Spellid5,@Spelltrigger5,@Spellcharges5,@Spellppmrate5,@Spellcooldown5,@Spellcategory5,@Spellcategorycooldown5,@Bonding,@PageText,@PageLanguage,@PageMaterial,@StartQuest,@LockId,@Material,@Sheath,@RandomProperty,@SetId,@MaxDurability,@AreaBound,@MapBound,@Duration,@BagFamily,@DisenchantId,@FoodType,@MinMoneyLoot,@MaxMoneyLoot,@WrappedGift,@ExtraFlags,@OtherTeamEntry)";
    }

    public string UpdateQuery()
    {
        return "UPDATE item_template SET patch = @Patch, class = @Class, subclass = @Subclass, name = @Name, description = @Description, display_id = @DisplayId, quality = @Quality, flags = @Flags, buy_count = @BuyCount, buy_price = @BuyPrice, sell_price = @SellPrice, inventory_type = @InventoryType, allowable_class = @AllowableClass, allowable_race = @AllowableRace, item_level = @ItemLevel, required_level = @RequiredLevel, required_skill = @RequiredSkill, required_skill_rank = @RequiredSkillRank, required_spell = @RequiredSpell, required_honor_rank = @RequiredHonorRank, required_city_rank = @RequiredCityRank, required_reputation_faction = @RequiredReputationFaction, required_reputation_rank = @RequiredReputationRank, max_count = @MaxCount, stackable = @Stackable, container_slots = @ContainerSlots, stat_type1 = @StatType1, stat_value1 = @StatValue1, stat_type2 = @StatType2, stat_value2 = @StatValue2, stat_type3 = @StatType3, stat_value3 = @StatValue3, stat_type4 = @StatType4, stat_value4 = @StatValue4, stat_type5 = @StatType5, stat_value5 = @StatValue5, stat_type6 = @StatType6, stat_value6 = @StatValue6, stat_type7 = @StatType7, stat_value7 = @StatValue7, stat_type8 = @StatType8, stat_value8 = @StatValue8, stat_type9 = @StatType9, stat_value9 = @StatValue9, stat_type10 = @StatType10, stat_value10 = @StatValue10, delay = @Delay, range_mod = @RangeMod, ammo_type = @AmmoType, dmg_min1 = @DmgMin1, dmg_max1 = @DmgMax1, dmg_type1 = @DmgType1, dmg_min2 = @DmgMin2, dmg_max2 = @DmgMax2, dmg_type2 = @DmgType2, dmg_min3 = @DmgMin3, dmg_max3 = @DmgMax3, dmg_type3 = @DmgType3, dmg_min4 = @DmgMin4, dmg_max4 = @DmgMax4, dmg_type4 = @DmgType4, dmg_min5 = @DmgMin5, dmg_max5 = @DmgMax5, dmg_type5 = @DmgType5, block = @Block, armor = @Armor, holy_res = @HolyRes, fire_res = @FireRes, nature_res = @NatureRes, frost_res = @FrostRes, shadow_res = @ShadowRes, arcane_res = @ArcaneRes, spellid_1 = @Spellid1, spelltrigger_1 = @Spelltrigger1, spellcharges_1 = @Spellcharges1, spellppmrate_1 = @Spellppmrate1, spellcooldown_1 = @Spellcooldown1, spellcategory_1 = @Spellcategory1, spellcategorycooldown_1 = @Spellcategorycooldown1, spellid_2 = @Spellid2, spelltrigger_2 = @Spelltrigger2, spellcharges_2 = @Spellcharges2, spellppmrate_2 = @Spellppmrate2, spellcooldown_2 = @Spellcooldown2, spellcategory_2 = @Spellcategory2, spellcategorycooldown_2 = @Spellcategorycooldown2, spellid_3 = @Spellid3, spelltrigger_3 = @Spelltrigger3, spellcharges_3 = @Spellcharges3, spellppmrate_3 = @Spellppmrate3, spellcooldown_3 = @Spellcooldown3, spellcategory_3 = @Spellcategory3, spellcategorycooldown_3 = @Spellcategorycooldown3, spellid_4 = @Spellid4, spelltrigger_4 = @Spelltrigger4, spellcharges_4 = @Spellcharges4, spellppmrate_4 = @Spellppmrate4, spellcooldown_4 = @Spellcooldown4, spellcategory_4 = @Spellcategory4, spellcategorycooldown_4 = @Spellcategorycooldown4, spellid_5 = @Spellid5, spelltrigger_5 = @Spelltrigger5, spellcharges_5 = @Spellcharges5, spellppmrate_5 = @Spellppmrate5, spellcooldown_5 = @Spellcooldown5, spellcategory_5 = @Spellcategory5, spellcategorycooldown_5 = @Spellcategorycooldown5, bonding = @Bonding, page_text = @PageText, page_language = @PageLanguage, page_material = @PageMaterial, start_quest = @StartQuest, lock_id = @LockId, material = @Material, sheath = @Sheath, random_property = @RandomProperty, set_id = @SetId, max_durability = @MaxDurability, area_bound = @AreaBound, map_bound = @MapBound, duration = @Duration, bag_family = @BagFamily, disenchant_id = @DisenchantId, food_type = @FoodType, min_money_loot = @MinMoneyLoot, max_money_loot = @MaxMoneyLoot, wrapped_gift = @WrappedGift, extra_flags = @ExtraFlags, other_team_entry = @OtherTeamEntry WHERE entry = @Entry";
    }

    public string DeleteQuery()
    {
        return "DELETE FROM item_template WHERE entry = @Entry;";
    }
}