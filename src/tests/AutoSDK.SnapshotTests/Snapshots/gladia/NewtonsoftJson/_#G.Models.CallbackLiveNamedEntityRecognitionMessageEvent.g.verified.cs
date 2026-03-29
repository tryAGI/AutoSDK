//HintName: G.Models.CallbackLiveNamedEntityRecognitionMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.named_entity_recognition<br/>
    /// Example: live.named_entity_recognition
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLiveNamedEntityRecognitionMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.named_entity_recognition")]
        LiveNamedEntityRecognition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveNamedEntityRecognitionMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveNamedEntityRecognitionMessageEvent value)
        {
            return value switch
            {
                CallbackLiveNamedEntityRecognitionMessageEvent.LiveNamedEntityRecognition => "live.named_entity_recognition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveNamedEntityRecognitionMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.named_entity_recognition" => CallbackLiveNamedEntityRecognitionMessageEvent.LiveNamedEntityRecognition,
                _ => null,
            };
        }
    }
}