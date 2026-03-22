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
        Bits,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Subs,
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
                HypeTrainEventEventDataTopContributionType.Bits => "BITS",
                HypeTrainEventEventDataTopContributionType.Other => "OTHER",
                HypeTrainEventEventDataTopContributionType.Subs => "SUBS",
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
                "BITS" => HypeTrainEventEventDataTopContributionType.Bits,
                "OTHER" => HypeTrainEventEventDataTopContributionType.Other,
                "SUBS" => HypeTrainEventEventDataTopContributionType.Subs,
                _ => null,
            };
        }
    }
}