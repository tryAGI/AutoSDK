//HintName: G.Models.OpenAIFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
    /// </summary>
    public abstract class OpenAIFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Uploaded = "uploaded";
        /// <summary>
        /// 
        /// </summary>
        public const string Processed = "processed";
        /// <summary>
        /// 
        /// </summary>
        public const string Error = "error";
    }
}