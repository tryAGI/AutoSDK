//HintName: G.Models.HypeTrainEventEventDataLastContributionType.g.cs

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
    public enum HypeTrainEventEventDataLastContributionType
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
    public static class HypeTrainEventEventDataLastContributionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HypeTrainEventEventDataLastContributionType value)
        {
            return value switch
            {
                HypeTrainEventEventDataLastContributionType.BITS => "BITS",
                HypeTrainEventEventDataLastContributionType.SUBS => "SUBS",
                HypeTrainEventEventDataLastContributionType.OTHER => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HypeTrainEventEventDataLastContributionType? ToEnum(string value)
        {
            return value switch
            {
                "BITS" => HypeTrainEventEventDataLastContributionType.BITS,
                "SUBS" => HypeTrainEventEventDataLastContributionType.SUBS,
                "OTHER" => HypeTrainEventEventDataLastContributionType.OTHER,
                _ => null,
            };
        }
    }
}