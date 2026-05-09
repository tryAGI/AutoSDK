//HintName: G.Models.CreateSoundEffectRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSoundEffectRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenTextToSoundV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSoundEffectRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSoundEffectRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateSoundEffectRequestDiscriminatorModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSoundEffectRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_text_to_sound_v2" => CreateSoundEffectRequestDiscriminatorModel.ElevenTextToSoundV2,
                _ => null,
            };
        }
    }
}