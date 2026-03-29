//HintName: G.Models.InsightRunFormatPlanFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the format of the data to return.<br/>
    /// If not provided, defaults to "raw".<br/>
    /// Raw provides the data as fetched from the database, with formulas evaluated.<br/>
    /// Recharts provides the data in a format that can is ready to be used by recharts.js to render charts.<br/>
    /// Example: raw
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InsightRunFormatPlanFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="raw")]
        Raw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="recharts")]
        Recharts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InsightRunFormatPlanFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightRunFormatPlanFormat value)
        {
            return value switch
            {
                InsightRunFormatPlanFormat.Raw => "raw",
                InsightRunFormatPlanFormat.Recharts => "recharts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightRunFormatPlanFormat? ToEnum(string value)
        {
            return value switch
            {
                "raw" => InsightRunFormatPlanFormat.Raw,
                "recharts" => InsightRunFormatPlanFormat.Recharts,
                _ => null,
            };
        }
    }
}