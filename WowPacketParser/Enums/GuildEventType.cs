namespace WowPacketParser.Enums
{
    public enum  GuildEventType
    {
        Promotion           = 0,
        Demotion            = 1,
        MOTD                = 2,
        PlayerJoined        = 3,
        PlayerLeft          = 4,
        PlayerRemoved       = 5,
        Unk6                = 6,
        ChangeGM            = 7,
        Disbanded           = 8,
        TabardChange        = 9,
        RankUpdated         = 10,
        Unk11               = 11,
        PlayerSignedOn      = 12,
        PlayerSignedOff     = 13,
        BankBagSlotsChanged = 14,
        BankTabPurchased    = 15,
        BankTabUpdated      = 16,
        BankMoneyUpdate     = 17,
        BankMoneyWithdraw   = 18,
        BankTextChanged     = 19
    }

    public enum GuildEventType442
    {
        MOTD                = 3,
        PlayerJoined        = 4, // Untested
        PlayerLeft          = 5,
        PlayerRemoved       = 6,
        ChangeGM            = 8,
        RankUpdated         = 11,
        RankCreated         = 12,
        RankDeleted         = 13,
        RankOrderChanged    = 14,
        Unk15               = 15, // At guild creation - Set founder
        PlayerSignedOn      = 16,
        PlayerSignedOff     = 17,
        BankBagSlotsChanged = 18,
        BankTabPurchased    = 19,
        BankTabUpdated      = 20,
        BankMoneyUpdate     = 21,
    }
}
