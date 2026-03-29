//HintName: G.Models.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterPhotoAvatarVoiceElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestPresenterPhotoAvatarVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterPhotoAvatarVoiceElevenLabsType value)
        {
            return value switch
            {
                CreateRequestPresenterPhotoAvatarVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterPhotoAvatarVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateRequestPresenterPhotoAvatarVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}