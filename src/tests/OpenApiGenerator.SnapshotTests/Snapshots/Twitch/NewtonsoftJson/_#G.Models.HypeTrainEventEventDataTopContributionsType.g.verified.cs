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
    [global::System.Runtime.Serialization.DataContract]
    public enum HypeTrainEventEventDataTopContributionsType
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

    public static class HypeTrainEventEventDataTopContributionsTypeExtensions
    {
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
        public static HypeTrainEventEventDataTopContributionsType ToEnum(string value)
        {
            return value switch
            {
                "BITS" => HypeTrainEventEventDataTopContributionsType.BITS,
                "SUBS" => HypeTrainEventEventDataTopContributionsType.SUBS,
                "OTHER" => HypeTrainEventEventDataTopContributionsType.OTHER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static HypeTrainEventEventDataTopContributionsType ToEnum(int value)
        {
            return value switch
            {
                0 => HypeTrainEventEventDataTopContributionsType.BITS,
                1 => HypeTrainEventEventDataTopContributionsType.SUBS,
                2 => HypeTrainEventEventDataTopContributionsType.OTHER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}