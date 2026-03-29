//HintName: G.Models.CreateGlossaryParametersEntriesFormat.g.cs

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
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGlossaryParametersEntriesFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csv")]
        Csv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tsv")]
        Tsv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGlossaryParametersEntriesFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGlossaryParametersEntriesFormat value)
        {
            return value switch
            {
                CreateGlossaryParametersEntriesFormat.Csv => "csv",
                CreateGlossaryParametersEntriesFormat.Tsv => "tsv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGlossaryParametersEntriesFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => CreateGlossaryParametersEntriesFormat.Csv,
                "tsv" => CreateGlossaryParametersEntriesFormat.Tsv,
                _ => null,
            };
        }
    }
}