//HintName: G.Models.BaseMessagesResultUsageServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultUsageServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priority")]
        Priority,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultUsageServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultUsageServiceTier value)
        {
            return value switch
            {
                BaseMessagesResultUsageServiceTier.Batch => "batch",
                BaseMessagesResultUsageServiceTier.Priority => "priority",
                BaseMessagesResultUsageServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultUsageServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BaseMessagesResultUsageServiceTier.Batch,
                "priority" => BaseMessagesResultUsageServiceTier.Priority,
                "standard" => BaseMessagesResultUsageServiceTier.Standard,
                _ => null,
            };
        }
    }
}