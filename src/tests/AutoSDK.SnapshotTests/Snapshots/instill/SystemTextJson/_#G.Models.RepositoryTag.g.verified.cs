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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The tag identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier, computed from the manifest the tag refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Tag update time, i.e. timestamp of the last push.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}