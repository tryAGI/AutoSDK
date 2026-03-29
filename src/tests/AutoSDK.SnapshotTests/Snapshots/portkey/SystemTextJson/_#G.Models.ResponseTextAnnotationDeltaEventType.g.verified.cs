//HintName: G.Models.ResponseTextAnnotationDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.output_text.annotation.added`.
    /// </summary>
    public enum ResponseTextAnnotationDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextAnnotationAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextAnnotationDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextAnnotationDeltaEventType value)
        {
            return value switch
            {
                ResponseTextAnnotationDeltaEventType.ResponseOutputTextAnnotationAdded => "response.output_text.annotation.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextAnnotationDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.annotation.added" => ResponseTextAnnotationDeltaEventType.ResponseOutputTextAnnotationAdded,
                _ => null,
            };
        }
    }
}