//HintName: G.Models.AlertFilterErrorCodeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertFilterErrorCodeItem
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