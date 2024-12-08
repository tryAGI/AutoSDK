//HintName: G.Models.BetaMessageBatchResultDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageBatchResultDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errored")]
        Errored,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageBatchResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageBatchResultDiscriminatorType value)
        {
            return value switch
            {
                BetaMessageBatchResultDiscriminatorType.Canceled => "canceled",
                BetaMessageBatchResultDiscriminatorType.Errored => "errored",
                BetaMessageBatchResultDiscriminatorType.Expired => "expired",
                BetaMessageBatchResultDiscriminatorType.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageBatchResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BetaMessageBatchResultDiscriminatorType.Canceled,
                "errored" => BetaMessageBatchResultDiscriminatorType.Errored,
                "expired" => BetaMessageBatchResultDiscriminatorType.Expired,
                "succeeded" => BetaMessageBatchResultDiscriminatorType.Succeeded,
                _ => null,
            };
        }
    }
}