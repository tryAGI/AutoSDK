//HintName: G.Models.SummaryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of summary
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bullets")]
        Bullets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bullets_verbose")]
        BulletsVerbose,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gist")]
        Gist,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="headline")]
        Headline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paragraph")]
        Paragraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryType value)
        {
            return value switch
            {
                SummaryType.Bullets => "bullets",
                SummaryType.BulletsVerbose => "bullets_verbose",
                SummaryType.Gist => "gist",
                SummaryType.Headline => "headline",
                SummaryType.Paragraph => "paragraph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryType? ToEnum(string value)
        {
            return value switch
            {
                "bullets" => SummaryType.Bullets,
                "bullets_verbose" => SummaryType.BulletsVerbose,
                "gist" => SummaryType.Gist,
                "headline" => SummaryType.Headline,
                "paragraph" => SummaryType.Paragraph,
                _ => null,
            };
        }
    }
}