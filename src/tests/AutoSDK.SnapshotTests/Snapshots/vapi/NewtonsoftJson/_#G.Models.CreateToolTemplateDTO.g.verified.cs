//HintName: G.Models.CreateToolTemplateDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolTemplateDTO
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
        public global::G.CreateToolTemplateDTOVisibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.CreateToolTemplateDTOType.Tool</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateToolTemplateDTOType Type { get; set; } = global::G.CreateToolTemplateDTOType.Tool;

        /// <summary>
        /// The name of the template. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateToolTemplateDTOProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolTemplateDTO" /> class.
        /// </summary>
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
        public CreateToolTemplateDTO(
            global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? details,
            global::G.OneOf<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>? providerDetails,
            global::G.ToolTemplateMetadata? metadata,
            global::G.CreateToolTemplateDTOVisibility? visibility,
            string? name,
            global::G.CreateToolTemplateDTOProvider? provider,
            global::G.CreateToolTemplateDTOType type = global::G.CreateToolTemplateDTOType.Tool)
        {
            this.Details = details;
            this.ProviderDetails = providerDetails;
            this.Metadata = metadata;
            this.Visibility = visibility;
            this.Type = type;
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolTemplateDTO" /> class.
        /// </summary>
        public CreateToolTemplateDTO()
        {
        }
    }
}