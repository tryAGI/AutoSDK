//HintName: G.Models.BetaResponseCharLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: char_location
    /// </summary>
    public enum BetaResponseCharLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCharLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCharLocationCitationType value)
        {
            return value switch
            {
                BetaResponseCharLocationCitationType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCharLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaResponseCharLocationCitationType.CharLocation,
                _ => null,
            };
        }
    }
}