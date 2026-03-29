//HintName: G.Models.Gender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Gender
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FEMALE")]
        Female,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MALE")]
        Male,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEUTRAL")]
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