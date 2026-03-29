//HintName: G.Models.GenderPresentation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenderPresentation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feminine")]
        Feminine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gender_neutral")]
        GenderNeutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="masculine")]
        Masculine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenderPresentationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenderPresentation value)
        {
            return value switch
            {
                GenderPresentation.Feminine => "feminine",
                GenderPresentation.GenderNeutral => "gender_neutral",
                GenderPresentation.Masculine => "masculine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenderPresentation? ToEnum(string value)
        {
            return value switch
            {
                "feminine" => GenderPresentation.Feminine,
                "gender_neutral" => GenderPresentation.GenderNeutral,
                "masculine" => GenderPresentation.Masculine,
                _ => null,
            };
        }
    }
}