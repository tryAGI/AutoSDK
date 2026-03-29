//HintName: G.Models.UpdateToolTemplateDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateToolTemplateDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>))]
        public global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerDetails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>))]
        public global::G.OneOf<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>? ProviderDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ToolTemplateMetadata? Metadata { get; set; }

        /// <summary>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateToolTemplateDTOVisibilityJsonConverter))]
        public global::G.UpdateToolTemplateDTOVisibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.UpdateToolTemplateDTOType.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateToolTemplateDTOTypeJsonConverter))]
        public global::G.UpdateToolTemplateDTOType Type { get; set; } = global::G.UpdateToolTemplateDTOType.Tool;

        /// <summary>
        /// The name of the template. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateToolTemplateDTOProviderJsonConverter))]
        public global::G.UpdateToolTemplateDTOProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolTemplateDTO" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateToolTemplateDTO(
            global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? details,
            global::G.OneOf<global::G.MakeToolProviderDetails, global::G.GhlToolProviderDetails, global::G.FunctionToolProviderDetails, global::G.GoogleCalendarCreateEventToolProviderDetails, global::G.GoogleSheetsRowAppendToolProviderDetails, global::G.GoHighLevelCalendarAvailabilityToolProviderDetails, global::G.GoHighLevelCalendarEventCreateToolProviderDetails, global::G.GoHighLevelContactCreateToolProviderDetails, global::G.GoHighLevelContactGetToolProviderDetails>? providerDetails,
            global::G.ToolTemplateMetadata? metadata,
            global::G.UpdateToolTemplateDTOVisibility? visibility,
            string? name,
            global::G.UpdateToolTemplateDTOProvider? provider,
            global::G.UpdateToolTemplateDTOType type = global::G.UpdateToolTemplateDTOType.Tool)
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
        /// Initializes a new instance of the <see cref="UpdateToolTemplateDTO" /> class.
        /// </summary>
        public UpdateToolTemplateDTO()
        {
        }
    }
}