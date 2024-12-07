//HintName: G.Models.ContentBlockDeltaEventDeltaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentBlockDeltaEventDeltaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputJsonDelta,
        /// <summary>
        /// 
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockDeltaEventDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockDeltaEventDeltaDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta => "input_json_delta",
                ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta => "text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockDeltaEventDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_json_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta,
                "text_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta,
                _ => null,
            };
        }
    }
}