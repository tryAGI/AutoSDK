//HintName: G.Models.BatchReferenceResponseVariant2ResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SUCCESS
    /// </summary>
    public enum BatchReferenceResponseVariant2ResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
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
                BatchReferenceResponseVariant2ResultStatus.Failed => "FAILED",
                BatchReferenceResponseVariant2ResultStatus.Pending => "PENDING",
                BatchReferenceResponseVariant2ResultStatus.Success => "SUCCESS",
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
                "FAILED" => BatchReferenceResponseVariant2ResultStatus.Failed,
                "PENDING" => BatchReferenceResponseVariant2ResultStatus.Pending,
                "SUCCESS" => BatchReferenceResponseVariant2ResultStatus.Success,
                _ => null,
            };
        }
    }
}