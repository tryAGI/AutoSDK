//HintName: G.Models.ApiVoiceGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiVoiceGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        NonBinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiVoiceGender value)
        {
            return value switch
            {
                ApiVoiceGender.Female => "Female",
                ApiVoiceGender.Male => "Male",
                ApiVoiceGender.NonBinary => "NonBinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "Female" => ApiVoiceGender.Female,
                "Male" => ApiVoiceGender.Male,
                "NonBinary" => ApiVoiceGender.NonBinary,
                _ => null,
            };
        }
    }
}