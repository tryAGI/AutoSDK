//HintName: G.Models.GlobalAdvisoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory.<br/>
    /// Included only in responses
    /// </summary>
    public enum GlobalAdvisoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Malware,
        /// <summary>
        /// 
        /// </summary>
        Reviewed,
        /// <summary>
        /// 
        /// </summary>
        Unreviewed,
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
                GlobalAdvisoryType.Malware => "malware",
                GlobalAdvisoryType.Reviewed => "reviewed",
                GlobalAdvisoryType.Unreviewed => "unreviewed",
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
                "malware" => GlobalAdvisoryType.Malware,
                "reviewed" => GlobalAdvisoryType.Reviewed,
                "unreviewed" => GlobalAdvisoryType.Unreviewed,
                _ => null,
            };
        }
    }
}