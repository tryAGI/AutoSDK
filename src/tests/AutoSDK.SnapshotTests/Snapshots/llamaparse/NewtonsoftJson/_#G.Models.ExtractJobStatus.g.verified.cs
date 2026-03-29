//HintName: G.Models.ExtractJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the extraction job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIAL_SUCCESS")]
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractJobStatus value)
        {
            return value switch
            {
                ExtractJobStatus.Cancelled => "CANCELLED",
                ExtractJobStatus.Error => "ERROR",
                ExtractJobStatus.PartialSuccess => "PARTIAL_SUCCESS",
                ExtractJobStatus.Pending => "PENDING",
                ExtractJobStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ExtractJobStatus.Cancelled,
                "ERROR" => ExtractJobStatus.Error,
                "PARTIAL_SUCCESS" => ExtractJobStatus.PartialSuccess,
                "PENDING" => ExtractJobStatus.Pending,
                "SUCCESS" => ExtractJobStatus.Success,
                _ => null,
            };
        }
    }
}