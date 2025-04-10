//HintName: G.Models.CryptoOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CryptoOption
    {
        /// <summary>
        /// 
        /// </summary>
        Btc,
        /// <summary>
        /// 
        /// </summary>
        EthErc20,
        /// <summary>
        /// 
        /// </summary>
        UsdTErc20,
        /// <summary>
        /// 
        /// </summary>
        UsdCErc20,
        /// <summary>
        /// 
        /// </summary>
        TUSDT,
        /// <summary>
        /// 
        /// </summary>
        BUSDT,
        /// <summary>
        /// 
        /// </summary>
        LTC,
        /// <summary>
        /// 
        /// </summary>
        XRP,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CryptoOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CryptoOption value)
        {
            return value switch
            {
                CryptoOption.Btc => "Btc",
                CryptoOption.EthErc20 => "EthErc20",
                CryptoOption.UsdTErc20 => "UsdTErc20",
                CryptoOption.UsdCErc20 => "UsdCErc20",
                CryptoOption.TUSDT => "TUSDT",
                CryptoOption.BUSDT => "BUSDT",
                CryptoOption.LTC => "LTC",
                CryptoOption.XRP => "XRP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CryptoOption? ToEnum(string value)
        {
            return value switch
            {
                "Btc" => CryptoOption.Btc,
                "EthErc20" => CryptoOption.EthErc20,
                "UsdTErc20" => CryptoOption.UsdTErc20,
                "UsdCErc20" => CryptoOption.UsdCErc20,
                "TUSDT" => CryptoOption.TUSDT,
                "BUSDT" => CryptoOption.BUSDT,
                "LTC" => CryptoOption.LTC,
                "XRP" => CryptoOption.XRP,
                _ => null,
            };
        }
    }
}