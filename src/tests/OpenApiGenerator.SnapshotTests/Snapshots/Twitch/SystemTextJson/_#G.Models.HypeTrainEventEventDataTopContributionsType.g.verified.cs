//HintName: G.Models.HypeTrainEventEventDataTopContributionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The contribution method used. Possible values are:  
    ///   
    /// * BITS — Cheering with Bits.
    /// * SUBS — Subscription activity like subscribing or gifting subscriptions.
    /// * OTHER — Covers other contribution methods not listed.
    /// </summary>
    public enum HypeTrainEventEventDataTopContributionsType
    {
        /// <summary>
        /// 
        /// </summary>
        BITS,
        /// <summary>
        /// 
        /// </summary>
        SUBS,
        /// <summary>
        /// 
        /// </summary>
        OTHER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HypeTrainEventEventDataTopContributionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HypeTrainEventEventDataTopContributionsType value)
        {
            return value switch
            {
                HypeTrainEventEventDataTopContributionsType.BITS => "BITS",
                HypeTrainEventEventDataTopContributionsType.SUBS => "SUBS",
                HypeTrainEventEventDataTopContributionsType.OTHER => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HypeTrainEventEventDataTopContributionsType? ToEnum(string value)
        {
            return value switch
            {
                "BITS" => HypeTrainEventEventDataTopContributionsType.BITS,
                "SUBS" => HypeTrainEventEventDataTopContributionsType.SUBS,
                "OTHER" => HypeTrainEventEventDataTopContributionsType.OTHER,
                _ => null,
            };
        }
    }
}