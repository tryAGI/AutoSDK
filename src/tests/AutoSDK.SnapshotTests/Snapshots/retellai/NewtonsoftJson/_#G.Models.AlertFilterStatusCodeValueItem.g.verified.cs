//HintName: G.Models.AlertFilterStatusCodeValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertFilterStatusCodeValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="400")]
        x400,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="401")]
        x401,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="402")]
        x402,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="403")]
        x403,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="404")]
        x404,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="409")]
        x409,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="422")]
        x422,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="429")]
        x429,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="500")]
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