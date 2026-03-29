//HintName: G.Models.FeedsSubscribeAgentResponseMergeStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedsSubscribeAgentResponseMergeStrategy
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
    public static class FeedsSubscribeAgentResponseMergeStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsSubscribeAgentResponseMergeStrategy value)
        {
            return value switch
            {
                FeedsSubscribeAgentResponseMergeStrategy.CombineIntoSingleMessage => "combine-into-single-message",
                FeedsSubscribeAgentResponseMergeStrategy.UniqueMessages => "unique-messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsSubscribeAgentResponseMergeStrategy? ToEnum(string value)
        {
            return value switch
            {
                "combine-into-single-message" => FeedsSubscribeAgentResponseMergeStrategy.CombineIntoSingleMessage,
                "unique-messages" => FeedsSubscribeAgentResponseMergeStrategy.UniqueMessages,
                _ => null,
            };
        }
    }
}