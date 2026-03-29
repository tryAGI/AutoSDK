//HintName: G.Models.EmbeddingTaskResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the task.<br/>
    /// **Values**:<br/>
    /// - `processing`: The platform is creating the embeddings<br/>
    /// - `ready`: Processing is complete. Embeddings are available in the `data` field<br/>
    /// - `failed`: The task failed. The `data` field is `null`
    /// </summary>
    public enum EmbeddingTaskResponseStatus
    {
        /// <summary>
        /// The task failed. The `data` field is `null`
        /// </summary>
        Failed,
        /// <summary>
        /// The platform is creating the embeddings
        /// </summary>
        Processing,
        /// <summary>
        /// Processing is complete. Embeddings are available in the `data` field
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingTaskResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingTaskResponseStatus value)
        {
            return value switch
            {
                EmbeddingTaskResponseStatus.Failed => "failed",
                EmbeddingTaskResponseStatus.Processing => "processing",
                EmbeddingTaskResponseStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingTaskResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => EmbeddingTaskResponseStatus.Failed,
                "processing" => EmbeddingTaskResponseStatus.Processing,
                "ready" => EmbeddingTaskResponseStatus.Ready,
                _ => null,
            };
        }
    }
}