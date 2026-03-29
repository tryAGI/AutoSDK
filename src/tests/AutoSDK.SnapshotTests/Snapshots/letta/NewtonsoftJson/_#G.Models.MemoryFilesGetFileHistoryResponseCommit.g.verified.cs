//HintName: G.Models.MemoryFilesGetFileHistoryResponseCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryFilesGetFileHistoryResponseCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_name")]
        public string? AuthorName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesGetFileHistoryResponseCommit" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="authorName"></param>
        public MemoryFilesGetFileHistoryResponseCommit(
            string sha,
            string message,
            string timestamp,
            string? authorName)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.AuthorName = authorName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesGetFileHistoryResponseCommit" /> class.
        /// </summary>
        public MemoryFilesGetFileHistoryResponseCommit()
        {
        }
    }
}