//HintName: G.Models.ImportFieldsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportFieldsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldInfos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FieldInfo> FieldInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existingSetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExistingSetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newSetTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewSetTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFieldsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportFieldsRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            global::System.Guid existingSetId,
            string newSetTitle)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.FieldInfos = fieldInfos ?? throw new global::System.ArgumentNullException(nameof(fieldInfos));
            this.ExistingSetId = existingSetId;
            this.NewSetTitle = newSetTitle ?? throw new global::System.ArgumentNullException(nameof(newSetTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFieldsRequest" /> class.
        /// </summary>
        public ImportFieldsRequest()
        {
        }
    }
}