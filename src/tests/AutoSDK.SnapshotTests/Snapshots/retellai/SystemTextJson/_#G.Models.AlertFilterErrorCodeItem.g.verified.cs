//HintName: G.Models.AlertFilterErrorCodeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertFilterErrorCodeItem
    {
        /// <summary>
        /// 
        /// </summary>
        x400,
        /// <summary>
        /// 
        /// </summary>
        x401,
        /// <summary>
        /// 
        /// </summary>
        x402,
        /// <summary>
        /// 
        /// </summary>
        x403,
        /// <summary>
        /// 
        /// </summary>
        x404,
        /// <summary>
        /// 
        /// </summary>
        x409,
        /// <summary>
        /// 
        /// </summary>
        x422,
        /// <summary>
        /// 
        /// </summary>
        x429,
        /// <summary>
        /// 
        /// </summary>
        x500,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertFilterErrorCodeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertFilterErrorCodeItem value)
        {
            return value switch
            {
                AlertFilterErrorCodeItem.x400 => "400",
                AlertFilterErrorCodeItem.x401 => "401",
                AlertFilterErrorCodeItem.x402 => "402",
                AlertFilterErrorCodeItem.x403 => "403",
                AlertFilterErrorCodeItem.x404 => "404",
                AlertFilterErrorCodeItem.x409 => "409",
                AlertFilterErrorCodeItem.x422 => "422",
                AlertFilterErrorCodeItem.x429 => "429",
                AlertFilterErrorCodeItem.x500 => "500",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertFilterErrorCodeItem? ToEnum(string value)
        {
            return value switch
            {
                "400" => AlertFilterErrorCodeItem.x400,
                "401" => AlertFilterErrorCodeItem.x401,
                "402" => AlertFilterErrorCodeItem.x402,
                "403" => AlertFilterErrorCodeItem.x403,
                "404" => AlertFilterErrorCodeItem.x404,
                "409" => AlertFilterErrorCodeItem.x409,
                "422" => AlertFilterErrorCodeItem.x422,
                "429" => AlertFilterErrorCodeItem.x429,
                "500" => AlertFilterErrorCodeItem.x500,
                _ => null,
            };
        }
    }
}