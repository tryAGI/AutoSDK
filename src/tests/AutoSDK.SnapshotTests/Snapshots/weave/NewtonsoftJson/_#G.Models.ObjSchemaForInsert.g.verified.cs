//HintName: G.Models.ObjSchemaForInsert.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjSchemaForInsert
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
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public object Val { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("builtin_object_class")]
        public string? BuiltinObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("set_base_object_class")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SetBaseObjectClass { get; set; }

        /// <summary>
        /// Client-computed digest for server-side validation. If provided, the server will verify it matches the server-computed digest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_digest")]
        public string? ExpectedDigest { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjSchemaForInsert" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="val"></param>
        /// <param name="builtinObjectClass"></param>
        /// <param name="expectedDigest">
        /// Client-computed digest for server-side validation. If provided, the server will verify it matches the server-computed digest.
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        public ObjSchemaForInsert(
            string projectId,
            string objectId,
            object val,
            string? builtinObjectClass,
            string? expectedDigest,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
            this.BuiltinObjectClass = builtinObjectClass;
            this.ExpectedDigest = expectedDigest;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjSchemaForInsert" /> class.
        /// </summary>
        public ObjSchemaForInsert()
        {
        }
    }
}