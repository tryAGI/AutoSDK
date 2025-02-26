//HintName: G.Models.BetaMessageBatchIndividualResponseResultDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageBatchIndividualResponseResultDiscriminatorType
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
    public static class BetaMessageBatchIndividualResponseResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageBatchIndividualResponseResultDiscriminatorType value)
        {
            return value switch
            {
                BetaMessageBatchIndividualResponseResultDiscriminatorType.Canceled => "canceled",
                BetaMessageBatchIndividualResponseResultDiscriminatorType.Errored => "errored",
                BetaMessageBatchIndividualResponseResultDiscriminatorType.Expired => "expired",
                BetaMessageBatchIndividualResponseResultDiscriminatorType.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageBatchIndividualResponseResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BetaMessageBatchIndividualResponseResultDiscriminatorType.Canceled,
                "errored" => BetaMessageBatchIndividualResponseResultDiscriminatorType.Errored,
                "expired" => BetaMessageBatchIndividualResponseResultDiscriminatorType.Expired,
                "succeeded" => BetaMessageBatchIndividualResponseResultDiscriminatorType.Succeeded,
                _ => null,
            };
        }
    }
}