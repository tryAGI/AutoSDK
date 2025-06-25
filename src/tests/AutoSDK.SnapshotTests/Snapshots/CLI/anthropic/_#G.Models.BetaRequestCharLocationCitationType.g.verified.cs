//HintName: G.Models.BetaRequestCharLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCharLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCharLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCharLocationCitationType value)
        {
            return value switch
            {
                BetaRequestCharLocationCitationType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCharLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaRequestCharLocationCitationType.CharLocation,
                _ => null,
            };
        }
    }
}