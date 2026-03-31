//HintName: G.Models.AISecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AISecret
    {
        /// <summary>
        /// Unique identifier for the AI secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Date of AI secret creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of last AI secret update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Name of the AI secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_secret")]
        public string? PreviewSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AISecret" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the AI secret
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="created">
        /// Date of AI secret creation
        /// </param>
        /// <param name="updatedAt">
        /// Date of last AI secret update
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="previewSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AISecret(
            global::System.Guid id,
            global::System.Guid orgId,
            string name,
            global::System.DateTime? created,
            global::System.DateTime? updatedAt,
            string? type,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            string? previewSecret)
        {
            this.Id = id;
            this.Created = created;
            this.UpdatedAt = updatedAt;
            this.OrgId = orgId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Metadata = metadata;
            this.PreviewSecret = previewSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AISecret" /> class.
        /// </summary>
        public AISecret()
        {
        }
    }
}