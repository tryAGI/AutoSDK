//HintName: G.Models.Corpus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A `Corpus` is a collection of `Document`s. A project can create up to 10 corpora.
    /// </summary>
    public sealed partial class Corpus
    {
        /// <summary>
        /// Output only. Immutable. Identifier. The `Corpus` resource name. The ID (name excluding the "corpora/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `corpora/my-awesome-corpora-123a456b789c`<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. The human-readable display name for the `Corpus`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `Corpus` was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. The Timestamp of when the `Corpus` was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Corpus" /> class.
        /// </summary>
        /// <param name="name">
        /// Output only. Immutable. Identifier. The `Corpus` resource name. The ID (name excluding the "corpora/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `corpora/my-awesome-corpora-123a456b789c`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `Corpus`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="createTime">
        /// Output only. The Timestamp of when the `Corpus` was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The Timestamp of when the `Corpus` was last updated.<br/>
        /// Included only in responses
        /// </param>
        public Corpus(
            string? name,
            string? displayName,
            string? createTime,
            string? updateTime)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Corpus" /> class.
        /// </summary>
        public Corpus()
        {
        }
    }
}