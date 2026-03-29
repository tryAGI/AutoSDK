//HintName: G.Models.FeedsUpdateSubscriptionResponseMergeStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedsUpdateSubscriptionResponseMergeStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="combine-into-single-message")]
        CombineIntoSingleMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique-messages")]
        UniqueMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsUpdateSubscriptionResponseMergeStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsUpdateSubscriptionResponseMergeStrategy value)
        {
            return value switch
            {
                FeedsUpdateSubscriptionResponseMergeStrategy.CombineIntoSingleMessage => "combine-into-single-message",
                FeedsUpdateSubscriptionResponseMergeStrategy.UniqueMessages => "unique-messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsUpdateSubscriptionResponseMergeStrategy? ToEnum(string value)
        {
            return value switch
            {
                "combine-into-single-message" => FeedsUpdateSubscriptionResponseMergeStrategy.CombineIntoSingleMessage,
                "unique-messages" => FeedsUpdateSubscriptionResponseMergeStrategy.UniqueMessages,
                _ => null,
            };
        }
    }
}