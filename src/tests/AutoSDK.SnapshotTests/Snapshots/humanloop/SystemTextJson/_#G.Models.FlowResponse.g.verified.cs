//HintName: G.Models.FlowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a Flow.
    /// </summary>
    public sealed partial class FlowResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FlowResponseTypeJsonConverter))]
        public global::G.FlowResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="versionId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="directoryId"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowResponse(
            string path,
            string id,
            string name,
            string versionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            string? directoryId,
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.FlowResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            string? versionName,
            string? versionDescription,
            object? attributes)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Readme = readme;
            this.Tags = tags;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Type = type;
            this.Environments = environments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowResponse" /> class.
        /// </summary>
        public FlowResponse()
        {
        }
    }
}