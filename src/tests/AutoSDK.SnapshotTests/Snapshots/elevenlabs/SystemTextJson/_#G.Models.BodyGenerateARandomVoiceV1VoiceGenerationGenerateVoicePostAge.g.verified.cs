//HintName: G.Models.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
    /// </summary>
    public enum BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge
    {
        /// <summary>
        /// young, middle_aged, old.
        /// </summary>
        Young,
        /// <summary>
        /// young, middle_aged, old.
        /// </summary>
        MiddleAged,
        /// <summary>
        /// young, middle_aged, old.
        /// </summary>
        Old,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge value)
        {
            return value switch
            {
                BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.Young => "young",
                BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.MiddleAged => "middle_aged",
                BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.Old => "old",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge? ToEnum(string value)
        {
            return value switch
            {
                "young" => BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.Young,
                "middle_aged" => BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.MiddleAged,
                "old" => BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge.Old,
                _ => null,
            };
        }
    }
}