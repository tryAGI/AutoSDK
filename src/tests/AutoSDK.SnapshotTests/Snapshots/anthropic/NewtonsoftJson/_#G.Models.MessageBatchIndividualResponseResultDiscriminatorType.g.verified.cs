//HintName: G.Models.MessageBatchIndividualResponseResultDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageBatchIndividualResponseResultDiscriminatorType
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
    public static class MessageBatchIndividualResponseResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageBatchIndividualResponseResultDiscriminatorType value)
        {
            return value switch
            {
                MessageBatchIndividualResponseResultDiscriminatorType.Canceled => "canceled",
                MessageBatchIndividualResponseResultDiscriminatorType.Errored => "errored",
                MessageBatchIndividualResponseResultDiscriminatorType.Expired => "expired",
                MessageBatchIndividualResponseResultDiscriminatorType.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageBatchIndividualResponseResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => MessageBatchIndividualResponseResultDiscriminatorType.Canceled,
                "errored" => MessageBatchIndividualResponseResultDiscriminatorType.Errored,
                "expired" => MessageBatchIndividualResponseResultDiscriminatorType.Expired,
                "succeeded" => MessageBatchIndividualResponseResultDiscriminatorType.Succeeded,
                _ => null,
            };
        }
    }
}