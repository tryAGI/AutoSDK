//HintName: G.Models.CitationOptionsMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to `"accurate"`.<br/>
    /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
    /// **Note**: `command-r7b-12-2024` and `command-a-03-2025` only support `"fast"` and `"off"` modes. The default is `"fast"`.
    /// </summary>
    public enum CitationOptionsMode
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationOptionsMode value)
        {
            return value switch
            {
                CitationOptionsMode.Fast => "FAST",
                CitationOptionsMode.Accurate => "ACCURATE",
                CitationOptionsMode.Off => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "FAST" => CitationOptionsMode.Fast,
                "ACCURATE" => CitationOptionsMode.Accurate,
                "OFF" => CitationOptionsMode.Off,
                _ => null,
            };
        }
    }
}