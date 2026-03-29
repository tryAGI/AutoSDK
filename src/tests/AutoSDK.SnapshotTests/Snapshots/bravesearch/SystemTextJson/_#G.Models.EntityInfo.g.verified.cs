//HintName: G.Models.EntityInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a named entity in the summary.
    /// </summary>
    public sealed partial class EntityInfo
    {
        /// <summary>
        /// Data provider for the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Short description of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// URL for more info about the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityInfo" /> class.
        /// </summary>
        /// <param name="provider">
        /// Data provider for the entity.
        /// </param>
        /// <param name="description">
        /// Short description of the entity.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="url">
        /// URL for more info about the entity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityInfo(
            string? provider,
            string? description,
            global::G.Thumbnail? thumbnail,
            string? url)
        {
            this.Provider = provider;
            this.Description = description;
            this.Thumbnail = thumbnail;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityInfo" /> class.
        /// </summary>
        public EntityInfo()
        {
        }
    }
}