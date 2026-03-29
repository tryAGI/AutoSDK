//HintName: G.Models.StreamingResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// "queued": the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
    /// </summary>
    public enum StreamingResponseStatus
    {
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Done,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Error,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Processing,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseStatus value)
        {
            return value switch
            {
                StreamingResponseStatus.Done => "done",
                StreamingResponseStatus.Error => "error",
                StreamingResponseStatus.Processing => "processing",
                StreamingResponseStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => StreamingResponseStatus.Done,
                "error" => StreamingResponseStatus.Error,
                "processing" => StreamingResponseStatus.Processing,
                "queued" => StreamingResponseStatus.Queued,
                _ => null,
            };
        }
    }
}