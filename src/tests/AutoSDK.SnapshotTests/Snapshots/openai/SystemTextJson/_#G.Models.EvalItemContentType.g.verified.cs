//HintName: G.Models.EvalItemContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum EvalItemContentType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemContentType value)
        {
            return value switch
            {
                EvalItemContentType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemContentType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => EvalItemContentType.OutputText,
                _ => null,
            };
        }
    }
}