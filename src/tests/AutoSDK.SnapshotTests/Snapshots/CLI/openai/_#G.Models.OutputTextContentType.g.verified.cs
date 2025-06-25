//HintName: G.Models.OutputTextContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the output text. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum OutputTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextContentType value)
        {
            return value switch
            {
                OutputTextContentType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputTextContentType.OutputText,
                _ => null,
            };
        }
    }
}