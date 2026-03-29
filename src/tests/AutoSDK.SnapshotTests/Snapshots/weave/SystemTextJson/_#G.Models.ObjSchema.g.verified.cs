//HintName: G.Models.ObjSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IsLatest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_object_class")]
        public string? BaseObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaf_object_class")]
        public string? LeafObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Val { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjSchema" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="createdAt"></param>
        /// <param name="digest"></param>
        /// <param name="versionIndex"></param>
        /// <param name="isLatest"></param>
        /// <param name="kind"></param>
        /// <param name="val"></param>
        /// <param name="deletedAt"></param>
        /// <param name="baseObjectClass"></param>
        /// <param name="leafObjectClass"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="sizeBytes"></param>
        /// <param name="tags"></param>
        /// <param name="aliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjSchema(
            string projectId,
            string objectId,
            global::System.DateTime createdAt,
            string digest,
            int versionIndex,
            int isLatest,
            string kind,
            object val,
            global::System.DateTime? deletedAt,
            string? baseObjectClass,
            string? leafObjectClass,
            string? wbUserId,
            long? sizeBytes,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionIndex = versionIndex;
            this.IsLatest = isLatest;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.BaseObjectClass = baseObjectClass;
            this.LeafObjectClass = leafObjectClass;
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
            this.WbUserId = wbUserId;
            this.SizeBytes = sizeBytes;
            this.Tags = tags;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjSchema" /> class.
        /// </summary>
        public ObjSchema()
        {
        }
    }
}