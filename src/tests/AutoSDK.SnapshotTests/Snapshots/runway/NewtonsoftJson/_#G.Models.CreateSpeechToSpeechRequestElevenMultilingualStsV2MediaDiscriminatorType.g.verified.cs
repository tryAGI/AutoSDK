//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType value)
        {
            return value switch
            {
                CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.Audio => "audio",
                CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.Audio,
                "video" => CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}