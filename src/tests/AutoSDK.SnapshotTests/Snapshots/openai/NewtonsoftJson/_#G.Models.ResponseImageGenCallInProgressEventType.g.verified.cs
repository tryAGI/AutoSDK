//HintName: G.Models.ResponseImageGenCallInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.in_progress'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseImageGenCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.image_generation_call.in_progress")]
        ResponseImageGenerationCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseImageGenCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseImageGenCallInProgressEventType value)
        {
            return value switch
            {
                ResponseImageGenCallInProgressEventType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseImageGenCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.in_progress" => ResponseImageGenCallInProgressEventType.ResponseImageGenerationCallInProgress,
                _ => null,
            };
        }
    }
}