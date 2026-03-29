//HintName: G.Models.TranslateRequestSpeakerGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gender of the speaker for better translations
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestSpeakerGender
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Female")]
        Female,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Male")]
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestSpeakerGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestSpeakerGender value)
        {
            return value switch
            {
                TranslateRequestSpeakerGender.Female => "Female",
                TranslateRequestSpeakerGender.Male => "Male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestSpeakerGender? ToEnum(string value)
        {
            return value switch
            {
                "Female" => TranslateRequestSpeakerGender.Female,
                "Male" => TranslateRequestSpeakerGender.Male,
                _ => null,
            };
        }
    }
}