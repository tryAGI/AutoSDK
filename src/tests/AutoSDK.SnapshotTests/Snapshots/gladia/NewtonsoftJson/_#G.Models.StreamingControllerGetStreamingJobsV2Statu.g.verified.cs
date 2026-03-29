//HintName: G.Models.StreamingControllerGetStreamingJobsV2Statu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingControllerGetStreamingJobsV2Statu
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingControllerGetStreamingJobsV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingControllerGetStreamingJobsV2Statu value)
        {
            return value switch
            {
                StreamingControllerGetStreamingJobsV2Statu.Done => "done",
                StreamingControllerGetStreamingJobsV2Statu.Error => "error",
                StreamingControllerGetStreamingJobsV2Statu.Processing => "processing",
                StreamingControllerGetStreamingJobsV2Statu.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingControllerGetStreamingJobsV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "done" => StreamingControllerGetStreamingJobsV2Statu.Done,
                "error" => StreamingControllerGetStreamingJobsV2Statu.Error,
                "processing" => StreamingControllerGetStreamingJobsV2Statu.Processing,
                "queued" => StreamingControllerGetStreamingJobsV2Statu.Queued,
                _ => null,
            };
        }
    }
}