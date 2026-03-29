//HintName: G.Models.CreateArchivalMemory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateArchivalMemory
    {
        /// <summary>
        /// Text to write to archival memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Optional list of tags to attach to the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional timestamp for the memory (defaults to current UTC time).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArchivalMemory" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to write to archival memory.
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to attach to the memory.
        /// </param>
        /// <param name="createdAt">
        /// Optional timestamp for the memory (defaults to current UTC time).
        /// </param>
        public CreateArchivalMemory(
            string text,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? createdAt)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tags = tags;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArchivalMemory" /> class.
        /// </summary>
        public CreateArchivalMemory()
        {
        }
    }
}