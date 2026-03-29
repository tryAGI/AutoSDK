//HintName: G.Models.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType
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
    public static class CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType value)
        {
            return value switch
            {
                CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}