//HintName: G.Models.CreateTranslationRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
    /// Default Value: json
    /// </summary>
    public enum CreateTranslationRequestResponseFormat
    {
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        Json,
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        Text,
        /// <summary>
        /// `json`, `text`, or `verbose_json`.
        /// </summary>
        VerboseJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranslationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationRequestResponseFormat value)
        {
            return value switch
            {
                CreateTranslationRequestResponseFormat.Json => "json",
                CreateTranslationRequestResponseFormat.Text => "text",
                CreateTranslationRequestResponseFormat.VerboseJson => "verbose_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateTranslationRequestResponseFormat.Json,
                "text" => CreateTranslationRequestResponseFormat.Text,
                "verbose_json" => CreateTranslationRequestResponseFormat.VerboseJson,
                _ => null,
            };
        }
    }
}