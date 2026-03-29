//HintName: G.Models.ResponseOutputTextContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum ResponseOutputTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputTextContentType value)
        {
            return value switch
            {
                ResponseOutputTextContentType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponseOutputTextContentType.OutputText,
                _ => null,
            };
        }
    }
}