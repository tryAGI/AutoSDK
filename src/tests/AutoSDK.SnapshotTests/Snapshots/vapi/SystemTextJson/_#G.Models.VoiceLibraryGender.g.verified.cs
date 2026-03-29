//HintName: G.Models.VoiceLibraryGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The gender of the voice.
    /// </summary>
    public enum VoiceLibraryGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceLibraryGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceLibraryGender value)
        {
            return value switch
            {
                VoiceLibraryGender.Female => "female",
                VoiceLibraryGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceLibraryGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => VoiceLibraryGender.Female,
                "male" => VoiceLibraryGender.Male,
                _ => null,
            };
        }
    }
}