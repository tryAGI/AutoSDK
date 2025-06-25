//HintName: G.Models.ResponseOutputTextAnnotationAddedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.output_text_annotation.added'.
    /// </summary>
    public enum ResponseOutputTextAnnotationAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextAnnotationAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputTextAnnotationAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputTextAnnotationAddedEventType value)
        {
            return value switch
            {
                ResponseOutputTextAnnotationAddedEventType.ResponseOutputTextAnnotationAdded => "response.output_text_annotation.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputTextAnnotationAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text_annotation.added" => ResponseOutputTextAnnotationAddedEventType.ResponseOutputTextAnnotationAdded,
                _ => null,
            };
        }
    }
}