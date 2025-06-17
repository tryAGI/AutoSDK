//HintName: G.Models.SIPTrunkTransportEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SIPTrunkTransportEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="udp")]
        Udp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tcp")]
        Tcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tls")]
        Tls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTrunkTransportEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkTransportEnum value)
        {
            return value switch
            {
                SIPTrunkTransportEnum.Auto => "auto",
                SIPTrunkTransportEnum.Udp => "udp",
                SIPTrunkTransportEnum.Tcp => "tcp",
                SIPTrunkTransportEnum.Tls => "tls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkTransportEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SIPTrunkTransportEnum.Auto,
                "udp" => SIPTrunkTransportEnum.Udp,
                "tcp" => SIPTrunkTransportEnum.Tcp,
                "tls" => SIPTrunkTransportEnum.Tls,
                _ => null,
            };
        }
    }
}