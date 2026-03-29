//HintName: G.Models.UpdateLineInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `line` to create a line insight.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateLineInsightFromCallTableDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLineInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLineInsightFromCallTableDTOType value)
        {
            return value switch
            {
                UpdateLineInsightFromCallTableDTOType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLineInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "line" => UpdateLineInsightFromCallTableDTOType.Line,
                _ => null,
            };
        }
    }
}