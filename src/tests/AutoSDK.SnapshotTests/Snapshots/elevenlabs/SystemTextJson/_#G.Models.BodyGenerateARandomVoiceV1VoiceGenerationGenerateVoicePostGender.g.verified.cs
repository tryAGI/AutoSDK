//HintName: G.Models.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Category code corresponding to the gender of the generated voice. Possible values: female, male.
    /// </summary>
    public enum BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender
    {
        /// <summary>
        /// female, male.
        /// </summary>
        Female,
        /// <summary>
        /// female, male.
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender value)
        {
            return value switch
            {
                BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.Female => "female",
                BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.Female,
                "male" => BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.Male,
                _ => null,
            };
        }
    }
}