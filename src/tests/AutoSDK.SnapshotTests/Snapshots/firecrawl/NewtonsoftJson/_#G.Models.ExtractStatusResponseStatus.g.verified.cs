//HintName: G.Models.ExtractStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the extract job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractStatusResponseStatus value)
        {
            return value switch
            {
                ExtractStatusResponseStatus.Cancelled => "cancelled",
                ExtractStatusResponseStatus.Completed => "completed",
                ExtractStatusResponseStatus.Failed => "failed",
                ExtractStatusResponseStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExtractStatusResponseStatus.Cancelled,
                "completed" => ExtractStatusResponseStatus.Completed,
                "failed" => ExtractStatusResponseStatus.Failed,
                "processing" => ExtractStatusResponseStatus.Processing,
                _ => null,
            };
        }
    }
}