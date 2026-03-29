//HintName: G.Models.PropertiesModelInfoConfigCacheType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 缓存配置
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesModelInfoConfigCacheType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefix")]
        Prefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesModelInfoConfigCacheTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesModelInfoConfigCacheType value)
        {
            return value switch
            {
                PropertiesModelInfoConfigCacheType.Closed => "closed",
                PropertiesModelInfoConfigCacheType.Prefix => "prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesModelInfoConfigCacheType? ToEnum(string value)
        {
            return value switch
            {
                "closed" => PropertiesModelInfoConfigCacheType.Closed,
                "prefix" => PropertiesModelInfoConfigCacheType.Prefix,
                _ => null,
            };
        }
    }
}