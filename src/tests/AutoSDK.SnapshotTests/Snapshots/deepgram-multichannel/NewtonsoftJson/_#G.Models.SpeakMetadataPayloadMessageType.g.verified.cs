//HintName: G.Models.SpeakMetadataPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeakMetadataPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speak_metadata")]
        SpeakMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakMetadataPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakMetadataPayloadMessageType value)
        {
            return value switch
            {
                SpeakMetadataPayloadMessageType.SpeakMetadata => "speak_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakMetadataPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "speak_metadata" => SpeakMetadataPayloadMessageType.SpeakMetadata,
                _ => null,
            };
        }
    }
}