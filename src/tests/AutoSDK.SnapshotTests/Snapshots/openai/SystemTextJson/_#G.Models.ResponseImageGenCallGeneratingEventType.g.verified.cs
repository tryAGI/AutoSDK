//HintName: G.Models.ResponseImageGenCallGeneratingEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.generating'.
    /// </summary>
    public enum ResponseImageGenCallGeneratingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallGenerating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseImageGenCallGeneratingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseImageGenCallGeneratingEventType value)
        {
            return value switch
            {
                ResponseImageGenCallGeneratingEventType.ResponseImageGenerationCallGenerating => "response.image_generation_call.generating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseImageGenCallGeneratingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.generating" => ResponseImageGenCallGeneratingEventType.ResponseImageGenerationCallGenerating,
                _ => null,
            };
        }
    }
}