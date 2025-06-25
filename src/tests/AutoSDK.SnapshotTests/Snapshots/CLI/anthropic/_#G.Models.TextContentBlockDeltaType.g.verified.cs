//HintName: G.Models.TextContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text_delta
    /// </summary>
    public enum TextContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextContentBlockDeltaType value)
        {
            return value switch
            {
                TextContentBlockDeltaType.TextDelta => "text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "text_delta" => TextContentBlockDeltaType.TextDelta,
                _ => null,
            };
        }
    }
}