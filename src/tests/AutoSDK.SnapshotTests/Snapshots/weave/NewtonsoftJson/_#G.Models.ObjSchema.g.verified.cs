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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_latest", Required = global::Newtonsoft.Json.Required.Always)]
        public int IsLatest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_object_class")]
        public string? BaseObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaf_object_class")]
        public string? LeafObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public object Val { get; set; } = default!;

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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