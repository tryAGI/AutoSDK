//HintName: G.Models.BatchReferenceResponseVariant2ResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SUCCESS
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchReferenceResponseVariant2ResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchReferenceResponseVariant2ResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchReferenceResponseVariant2ResultStatus value)
        {
            return value switch
            {
                BatchReferenceResponseVariant2ResultStatus.Success => "SUCCESS",
                BatchReferenceResponseVariant2ResultStatus.Pending => "PENDING",
                BatchReferenceResponseVariant2ResultStatus.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchReferenceResponseVariant2ResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => BatchReferenceResponseVariant2ResultStatus.Success,
                "PENDING" => BatchReferenceResponseVariant2ResultStatus.Pending,
                "FAILED" => BatchReferenceResponseVariant2ResultStatus.Failed,
                _ => null,
            };
        }
    }
}