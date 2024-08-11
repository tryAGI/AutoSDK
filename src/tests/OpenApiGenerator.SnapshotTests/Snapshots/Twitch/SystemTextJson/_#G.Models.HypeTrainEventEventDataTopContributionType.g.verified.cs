//HintName: G.Models.HypeTrainEventEventDataTopContributionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The contribution method used. Possible values are:  <br/>
    ///   <br/>
    /// * BITS — Cheering with Bits.<br/>
    /// * SUBS — Subscription activity like subscribing or gifting subscriptions.<br/>
    /// * OTHER — Covers other contribution methods not listed.
    /// </summary>
    public enum HypeTrainEventEventDataTopContributionType
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
    public static class HypeTrainEventEventDataTopContributionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HypeTrainEventEventDataTopContributionType value)
        {
            return value switch
            {
                HypeTrainEventEventDataTopContributionType.BITS => "BITS",
                HypeTrainEventEventDataTopContributionType.SUBS => "SUBS",
                HypeTrainEventEventDataTopContributionType.OTHER => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HypeTrainEventEventDataTopContributionType? ToEnum(string value)
        {
            return value switch
            {
                "BITS" => HypeTrainEventEventDataTopContributionType.BITS,
                "SUBS" => HypeTrainEventEventDataTopContributionType.SUBS,
                "OTHER" => HypeTrainEventEventDataTopContributionType.OTHER,
                _ => null,
            };
        }
    }
}