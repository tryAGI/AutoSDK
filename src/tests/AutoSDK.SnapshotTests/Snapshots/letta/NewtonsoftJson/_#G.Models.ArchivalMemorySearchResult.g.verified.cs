//HintName: G.Models.ArchivalMemorySearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArchivalMemorySearchResult
    {
        /// <summary>
        /// Unique identifier of the archival memory passage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Timestamp of when the memory was created, formatted in agent's timezone
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Text content of the archival memory passage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// List of tags associated with this memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the archival memory passage
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of when the memory was created, formatted in agent's timezone
        /// </param>
        /// <param name="content">
        /// Text content of the archival memory passage
        /// </param>
        /// <param name="tags">
        /// List of tags associated with this memory
        /// </param>
        public ArchivalMemorySearchResult(
            string id,
            string timestamp,
            string content,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResult" /> class.
        /// </summary>
        public ArchivalMemorySearchResult()
        {
        }
    }
}