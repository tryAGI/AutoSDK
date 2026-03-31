//HintName: G.Models.GenderPresentation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenderPresentation
    {
        /// <summary>
        /// 
        /// </summary>
        Feminine,
        /// <summary>
        /// 
        /// </summary>
        GenderNeutral,
        /// <summary>
        /// 
        /// </summary>
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