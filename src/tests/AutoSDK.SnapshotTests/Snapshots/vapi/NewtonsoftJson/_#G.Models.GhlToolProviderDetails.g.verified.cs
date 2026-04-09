//HintName: G.Models.GhlToolProviderDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GhlToolProviderDetails
    {
        /// <summary>
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateUrl")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setupInstructions")]
        public global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? SetupInstructions { get; set; }

        /// <summary>
        /// The type of tool. "ghl" for GHL tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GhlToolProviderDetailsTypeJsonConverter))]
        public global::G.GhlToolProviderDetailsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowName")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhookHookId")]
        public string? WebhookHookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhookHookName")]
        public string? WebhookHookName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locationId")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GhlToolProviderDetails" /> class.
        /// </summary>
        /// <param name="templateUrl">
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </param>
        /// <param name="setupInstructions"></param>
        /// <param name="type">
        /// The type of tool. "ghl" for GHL tool.
        /// </param>
        /// <param name="workflowId"></param>
        /// <param name="workflowName"></param>
        /// <param name="webhookHookId"></param>
        /// <param name="webhookHookName"></param>
        /// <param name="locationId"></param>
        public GhlToolProviderDetails(
            string? templateUrl,
            global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? setupInstructions,
            global::G.GhlToolProviderDetailsType type,
            string? workflowId,
            string? workflowName,
            string? webhookHookId,
            string? webhookHookName,
            string? locationId)
        {
            this.TemplateUrl = templateUrl;
            this.SetupInstructions = setupInstructions;
            this.Type = type;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
            this.WebhookHookId = webhookHookId;
            this.WebhookHookName = webhookHookName;
            this.LocationId = locationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GhlToolProviderDetails" /> class.
        /// </summary>
        public GhlToolProviderDetails()
        {
        }
    }
}