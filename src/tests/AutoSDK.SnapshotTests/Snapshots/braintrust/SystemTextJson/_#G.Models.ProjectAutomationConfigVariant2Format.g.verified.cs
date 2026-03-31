//HintName: G.Models.ProjectAutomationConfigVariant2Format.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to export the results in
    /// </summary>
    public enum ProjectAutomationConfigVariant2Format
    {
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2Format value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2Format.Jsonl => "jsonl",
                ProjectAutomationConfigVariant2Format.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => ProjectAutomationConfigVariant2Format.Jsonl,
                "parquet" => ProjectAutomationConfigVariant2Format.Parquet,
                _ => null,
            };
        }
    }
}