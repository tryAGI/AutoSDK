//HintName: G.Models.GlossaryEntriesFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the glossary entries are provided. Formats currently available:<br/>
    /// - `tsv` (default) - tab-separated values<br/>
    /// - `csv` - comma-separated values<br/>
    /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
    /// Default Value: tsv<br/>
    /// Example: tsv
    /// </summary>
    public enum GlossaryEntriesFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Tsv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlossaryEntriesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlossaryEntriesFormat value)
        {
            return value switch
            {
                GlossaryEntriesFormat.Csv => "csv",
                GlossaryEntriesFormat.Tsv => "tsv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlossaryEntriesFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => GlossaryEntriesFormat.Csv,
                "tsv" => GlossaryEntriesFormat.Tsv,
                _ => null,
            };
        }
    }
}