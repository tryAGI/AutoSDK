//HintName: G.Models.OpenAPIWorkflowBasic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIWorkflowBasic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowBasic" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="description"></param>
        /// <param name="iconUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="workflowId"></param>
        /// <param name="workflowName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIWorkflowBasic(
            string? appId,
            string? createdAt,
            global::G.OpenAPIUserInfo? creator,
            string? description,
            string? iconUrl,
            string? updatedAt,
            string? workflowId,
            string? workflowName)
        {
            this.AppId = appId;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.UpdatedAt = updatedAt;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowBasic" /> class.
        /// </summary>
        public OpenAPIWorkflowBasic()
        {
        }
    }
}