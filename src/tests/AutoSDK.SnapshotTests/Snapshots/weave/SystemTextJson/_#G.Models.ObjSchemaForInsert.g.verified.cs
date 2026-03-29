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
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Val { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin_object_class")]
        public string? BuiltinObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_base_object_class")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SetBaseObjectClass { get; set; }

        /// <summary>
        /// Client-computed digest for server-side validation. If provided, the server will verify it matches the server-computed digest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_digest")]
        public string? ExpectedDigest { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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