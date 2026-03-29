//HintName: G.Models.OpenAPIVersionMetaInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIVersionMetaInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::G.OpenAPIUserInfo? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::G.OpenAPIWorkflowInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::G.OpenAPIWorkflowOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIVersionMetaInfo" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="description"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        /// <param name="workflowId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIVersionMetaInfo(
            string? createdAt,
            global::G.OpenAPIUserInfo? creator,
            string? description,
            global::G.OpenAPIWorkflowInput? input,
            global::G.OpenAPIWorkflowOutput? output,
            string? updatedAt,
            string? version,
            string? workflowId)
        {
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Description = description;
            this.Input = input;
            this.Output = output;
            this.UpdatedAt = updatedAt;
            this.Version = version;
            this.WorkflowId = workflowId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIVersionMetaInfo" /> class.
        /// </summary>
        public OpenAPIVersionMetaInfo()
        {
        }
    }
}