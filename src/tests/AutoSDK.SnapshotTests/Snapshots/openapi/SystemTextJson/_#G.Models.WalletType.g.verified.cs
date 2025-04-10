//HintName: G.Models.WalletType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WalletType
    {
        /// <summary>
        /// 
        /// </summary>
        E,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        P,
        /// <summary>
        /// 
        /// </summary>
        Education,
        /// <summary>
        /// 
        /// </summary>
        ProductSubscription,
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        C,
        /// <summary>
        /// 
        /// </summary>
        GoTokens,
        /// <summary>
        /// 
        /// </summary>
        GoWinCash,
        /// <summary>
        /// 
        /// </summary>
        GoWinRewardTokens,
        /// <summary>
        /// 
        /// </summary>
        XWallet,
        /// <summary>
        /// 
        /// </summary>
        TransferWallet,
        /// <summary>
        /// 
        /// </summary>
        SharesWallet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WalletTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WalletType value)
        {
            return value switch
            {
                WalletType.E => "E",
                WalletType.D => "D",
                WalletType.P => "P",
                WalletType.Education => "Education",
                WalletType.ProductSubscription => "ProductSubscription",
                WalletType.A => "A",
                WalletType.C => "C",
                WalletType.GoTokens => "GoTokens",
                WalletType.GoWinCash => "GoWinCash",
                WalletType.GoWinRewardTokens => "GoWinRewardTokens",
                WalletType.XWallet => "XWallet",
                WalletType.TransferWallet => "TransferWallet",
                WalletType.SharesWallet => "SharesWallet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WalletType? ToEnum(string value)
        {
            return value switch
            {
                "E" => WalletType.E,
                "D" => WalletType.D,
                "P" => WalletType.P,
                "Education" => WalletType.Education,
                "ProductSubscription" => WalletType.ProductSubscription,
                "A" => WalletType.A,
                "C" => WalletType.C,
                "GoTokens" => WalletType.GoTokens,
                "GoWinCash" => WalletType.GoWinCash,
                "GoWinRewardTokens" => WalletType.GoWinRewardTokens,
                "XWallet" => WalletType.XWallet,
                "TransferWallet" => WalletType.TransferWallet,
                "SharesWallet" => WalletType.SharesWallet,
                _ => null,
            };
        }
    }
}