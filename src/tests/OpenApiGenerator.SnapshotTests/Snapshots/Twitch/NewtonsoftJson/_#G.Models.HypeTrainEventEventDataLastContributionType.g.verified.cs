//HintName: G.Models.HypeTrainEventEventDataLastContributionType.g.cs

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
    [global::System.Runtime.Serialization.DataContract]
    public enum HypeTrainEventEventDataLastContributionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BITS")]
        BITS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUBS")]
        SUBS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OTHER")]
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