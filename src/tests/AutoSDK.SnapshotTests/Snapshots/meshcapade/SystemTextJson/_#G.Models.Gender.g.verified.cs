//HintName: G.Models.Gender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Gender
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
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gender value)
        {
            return value switch
            {
                Gender.Female => "FEMALE",
                Gender.Male => "MALE",
                Gender.Neutral => "NEUTRAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gender? ToEnum(string value)
        {
            return value switch
            {
                "FEMALE" => Gender.Female,
                "MALE" => Gender.Male,
                "NEUTRAL" => Gender.Neutral,
                _ => null,
            };
        }
    }
}