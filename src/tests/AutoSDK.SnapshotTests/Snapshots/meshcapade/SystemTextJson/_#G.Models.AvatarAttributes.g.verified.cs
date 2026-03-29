//HintName: G.Models.AvatarAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetStateJsonConverter))]
        public global::G.AssetState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetTypeJsonConverter))]
        public global::G.AssetType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BuildMethodJsonConverter))]
        public global::G.BuildMethod? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSourceJsonConverter))]
        public global::G.FileSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_build_id")]
        public string? SourceBuildId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public global::G.URLResponse? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.AvatarMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarAttributes" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="state"></param>
        /// <param name="type"></param>
        /// <param name="origin"></param>
        /// <param name="source"></param>
        /// <param name="sourceBuildId"></param>
        /// <param name="url"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvatarAttributes(
            long? createdAt,
            long? updatedAt,
            string? name,
            string? owner,
            global::G.AssetState? state,
            global::G.AssetType? type,
            global::G.BuildMethod? origin,
            global::G.FileSource? source,
            string? sourceBuildId,
            global::G.URLResponse? url,
            global::G.AvatarMetadata? metadata)
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Owner = owner;
            this.State = state;
            this.Type = type;
            this.Origin = origin;
            this.Source = source;
            this.SourceBuildId = sourceBuildId;
            this.Url = url;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarAttributes" /> class.
        /// </summary>
        public AvatarAttributes()
        {
        }
    }
}