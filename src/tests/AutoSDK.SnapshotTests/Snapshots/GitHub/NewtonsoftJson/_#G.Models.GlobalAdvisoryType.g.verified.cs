//HintName: G.Models.GlobalAdvisoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalAdvisoryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reviewed")]
        Reviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unreviewed")]
        Unreviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="malware")]
        Malware,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalAdvisoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalAdvisoryType value)
        {
            return value switch
            {
                GlobalAdvisoryType.Reviewed => "reviewed",
                GlobalAdvisoryType.Unreviewed => "unreviewed",
                GlobalAdvisoryType.Malware => "malware",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalAdvisoryType? ToEnum(string value)
        {
            return value switch
            {
                "reviewed" => GlobalAdvisoryType.Reviewed,
                "unreviewed" => GlobalAdvisoryType.Unreviewed,
                "malware" => GlobalAdvisoryType.Malware,
                _ => null,
            };
        }
    }
}