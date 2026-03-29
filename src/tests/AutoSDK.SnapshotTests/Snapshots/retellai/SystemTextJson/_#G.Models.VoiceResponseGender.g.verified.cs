//HintName: G.Models.VoiceResponseGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gender of voice.<br/>
    /// Example: male
    /// </summary>
    public enum VoiceResponseGender
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
    public static class VoiceResponseGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseGender value)
        {
            return value switch
            {
                VoiceResponseGender.Female => "female",
                VoiceResponseGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => VoiceResponseGender.Female,
                "male" => VoiceResponseGender.Male,
                _ => null,
            };
        }
    }
}