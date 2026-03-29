//HintName: G.Models.NoneProxyConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of proxy. Always 'none' for this config.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NoneProxyConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NoneProxyConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoneProxyConfigType value)
        {
            return value switch
            {
                NoneProxyConfigType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoneProxyConfigType? ToEnum(string value)
        {
            return value switch
            {
                "none" => NoneProxyConfigType.None,
                _ => null,
            };
        }
    }
}