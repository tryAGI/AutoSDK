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

    public static class HypeTrainEventEventDataLastContributionTypeExtensions
    {
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
        public static HypeTrainEventEventDataLastContributionType ToEnum(string value)
        {
            return value switch
            {
                "BITS" => HypeTrainEventEventDataLastContributionType.BITS,
                "SUBS" => HypeTrainEventEventDataLastContributionType.SUBS,
                "OTHER" => HypeTrainEventEventDataLastContributionType.OTHER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static HypeTrainEventEventDataLastContributionType ToEnum(int value)
        {
            return value switch
            {
                0 => HypeTrainEventEventDataLastContributionType.BITS,
                1 => HypeTrainEventEventDataLastContributionType.SUBS,
                2 => HypeTrainEventEventDataLastContributionType.OTHER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}