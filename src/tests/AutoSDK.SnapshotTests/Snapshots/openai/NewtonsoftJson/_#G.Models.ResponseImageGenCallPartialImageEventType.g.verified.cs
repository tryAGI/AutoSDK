//HintName: G.Models.ResponseImageGenCallPartialImageEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.partial_image'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseImageGenCallPartialImageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.image_generation_call.partial_image")]
        ResponseImageGenerationCallPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseImageGenCallPartialImageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseImageGenCallPartialImageEventType value)
        {
            return value switch
            {
                ResponseImageGenCallPartialImageEventType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseImageGenCallPartialImageEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.partial_image" => ResponseImageGenCallPartialImageEventType.ResponseImageGenerationCallPartialImage,
                _ => null,
            };
        }
    }
}