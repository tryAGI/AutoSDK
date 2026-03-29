//HintName: G.Models.PipelineFileStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineFileStatus2
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
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOT_STARTED")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineFileStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineFileStatus2 value)
        {
            return value switch
            {
                PipelineFileStatus2.Cancelled => "CANCELLED",
                PipelineFileStatus2.Error => "ERROR",
                PipelineFileStatus2.InProgress => "IN_PROGRESS",
                PipelineFileStatus2.NotStarted => "NOT_STARTED",
                PipelineFileStatus2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineFileStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineFileStatus2.Cancelled,
                "ERROR" => PipelineFileStatus2.Error,
                "IN_PROGRESS" => PipelineFileStatus2.InProgress,
                "NOT_STARTED" => PipelineFileStatus2.NotStarted,
                "SUCCESS" => PipelineFileStatus2.Success,
                _ => null,
            };
        }
    }
}