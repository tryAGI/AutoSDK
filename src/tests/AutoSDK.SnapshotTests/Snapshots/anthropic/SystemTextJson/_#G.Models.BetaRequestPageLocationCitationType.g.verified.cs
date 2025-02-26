//HintName: G.Models.BetaRequestPageLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestPageLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestPageLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestPageLocationCitationType value)
        {
            return value switch
            {
                BetaRequestPageLocationCitationType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestPageLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => BetaRequestPageLocationCitationType.PageLocation,
                _ => null,
            };
        }
    }
}