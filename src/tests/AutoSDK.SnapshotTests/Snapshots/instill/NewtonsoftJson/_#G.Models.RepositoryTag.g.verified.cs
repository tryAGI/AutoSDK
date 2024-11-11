//HintName: G.Models.RepositoryTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RepositoryTag contains information about the version of some content in a<br/>
    /// repository.
    /// </summary>
    public sealed partial class RepositoryTag
    {
        /// <summary>
        /// The name of the tag, defined by its parent repository and ID.<br/>
        /// - Format: `repositories/{repository.id}/tags/{tag.id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The tag identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier, computed from the manifest the tag refers to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Tag update time, i.e. timestamp of the last push.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryTag" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tag, defined by its parent repository and ID.<br/>
        /// - Format: `repositories/{repository.id}/tags/{tag.id}`.
        /// </param>
        /// <param name="id">
        /// The tag identifier.
        /// </param>
        /// <param name="digest">
        /// Unique identifier, computed from the manifest the tag refers to.
        /// </param>
        /// <param name="updateTime">
        /// Tag update time, i.e. timestamp of the last push.<br/>
        /// Included only in responses
        /// </param>
        public RepositoryTag(
            string? name,
            string? id,
            string? digest,
            global::System.DateTime? updateTime)
        {
            this.Name = name;
            this.Id = id;
            this.Digest = digest;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryTag" /> class.
        /// </summary>
        public RepositoryTag()
        {
        }
    }
}