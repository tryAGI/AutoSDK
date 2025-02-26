//HintName: G.Models.BetaResponsePageLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: page_location
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponsePageLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_location")]
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponsePageLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponsePageLocationCitationType value)
        {
            return value switch
            {
                BetaResponsePageLocationCitationType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponsePageLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => BetaResponsePageLocationCitationType.PageLocation,
                _ => null,
            };
        }
    }
}