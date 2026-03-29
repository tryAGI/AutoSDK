//HintName: G.Models.AlertFilterStatusCodeValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertFilterStatusCodeValueItem
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
    public static class AlertFilterStatusCodeValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertFilterStatusCodeValueItem value)
        {
            return value switch
            {
                AlertFilterStatusCodeValueItem.x400 => "400",
                AlertFilterStatusCodeValueItem.x401 => "401",
                AlertFilterStatusCodeValueItem.x402 => "402",
                AlertFilterStatusCodeValueItem.x403 => "403",
                AlertFilterStatusCodeValueItem.x404 => "404",
                AlertFilterStatusCodeValueItem.x409 => "409",
                AlertFilterStatusCodeValueItem.x422 => "422",
                AlertFilterStatusCodeValueItem.x429 => "429",
                AlertFilterStatusCodeValueItem.x500 => "500",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertFilterStatusCodeValueItem? ToEnum(string value)
        {
            return value switch
            {
                "400" => AlertFilterStatusCodeValueItem.x400,
                "401" => AlertFilterStatusCodeValueItem.x401,
                "402" => AlertFilterStatusCodeValueItem.x402,
                "403" => AlertFilterStatusCodeValueItem.x403,
                "404" => AlertFilterStatusCodeValueItem.x404,
                "409" => AlertFilterStatusCodeValueItem.x409,
                "422" => AlertFilterStatusCodeValueItem.x422,
                "429" => AlertFilterStatusCodeValueItem.x429,
                "500" => AlertFilterStatusCodeValueItem.x500,
                _ => null,
            };
        }
    }
}