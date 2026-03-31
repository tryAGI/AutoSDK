//HintName: G.Models.CreateProjectAutomationConfigVariant2Format.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to export the results in
    /// </summary>
    public enum CreateProjectAutomationConfigVariant2Format
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
    public static class CreateProjectAutomationConfigVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2Format value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2Format.Jsonl => "jsonl",
                CreateProjectAutomationConfigVariant2Format.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => CreateProjectAutomationConfigVariant2Format.Jsonl,
                "parquet" => CreateProjectAutomationConfigVariant2Format.Parquet,
                _ => null,
            };
        }
    }
}