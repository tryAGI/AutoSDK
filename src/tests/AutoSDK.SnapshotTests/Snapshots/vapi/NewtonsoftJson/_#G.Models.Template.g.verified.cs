//HintName: G.Models.Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Template
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerDetails")]
        public global::G.OneOf<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>? ProviderDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ToolTemplateMetadata? Metadata { get; set; }

        /// <summary>
        /// Default Value: private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateVisibilityJsonConverter))]
        public global::G.TemplateVisibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.TemplateType.Tool</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateTypeJsonConverter))]
        public global::G.TemplateType Type { get; set; } = global::G.TemplateType.Tool;

        /// <summary>
        /// The name of the template. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateProviderJsonConverter))]
        public global::G.TemplateProvider? Provider { get; set; }

        /// <summary>
        /// The unique identifier for the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the organization that this template belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// The ISO 8601 date-time string of when the template was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ISO 8601 date-time string of when the template was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the template.
        /// </param>
        /// <param name="orgId">
        /// The unique identifier for the organization that this template belongs to.
        /// </param>
        /// <param name="createdAt">
        /// The ISO 8601 date-time string of when the template was created.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO 8601 date-time string of when the template was last updated.
        /// </param>
        /// <param name="details"></param>
        /// <param name="providerDetails"></param>
        /// <param name="metadata"></param>
        /// <param name="visibility">
        /// Default Value: private
        /// </param>
        /// <param name="name">
        /// The name of the template. This is just for your own reference.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
        public Template(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? details,
            global::G.OneOf<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>? providerDetails,
            global::G.ToolTemplateMetadata? metadata,
            global::G.TemplateVisibility? visibility,
            string? name,
            global::G.TemplateProvider? provider,
            global::G.TemplateType type = global::G.TemplateType.Tool)
        {
            this.Details = details;
            this.ProviderDetails = providerDetails;
            this.Metadata = metadata;
            this.Visibility = visibility;
            this.Type = type;
            this.Name = name;
            this.Provider = provider;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
        }
    }
}