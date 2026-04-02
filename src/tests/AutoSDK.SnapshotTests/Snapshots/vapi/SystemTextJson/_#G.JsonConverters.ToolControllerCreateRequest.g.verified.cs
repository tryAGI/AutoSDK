//HintName: G.JsonConverters.ToolControllerCreateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolControllerCreateRequest>
    {
        /// <inheritdoc />
        public override global::G.ToolControllerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolControllerCreateRequestDiscriminator>(ref readerCopy, options);

            global::G.CreateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateApiRequestToolDTO>(ref reader, options);
            }
            global::G.CreateCodeToolDTO? code = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCodeToolDTO>(ref reader, options);
            }
            global::G.CreateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateDtmfToolDTO>(ref reader, options);
            }
            global::G.CreateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateEndCallToolDTO>(ref reader, options);
            }
            global::G.CreateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateFunctionToolDTO>(ref reader, options);
            }
            global::G.CreateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTransferCallToolDTO>(ref reader, options);
            }
            global::G.CreateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateHandoffToolDTO>(ref reader, options);
            }
            global::G.CreateBashToolDTO? bash = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateBashToolDTO>(ref reader, options);
            }
            global::G.CreateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateComputerToolDTO>(ref reader, options);
            }
            global::G.CreateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTextEditorToolDTO>(ref reader, options);
            }
            global::G.CreateQueryToolDTO? query = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateQueryToolDTO>(ref reader, options);
            }
            global::G.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleCalendarCreateEventToolDTO>(ref reader, options);
            }
            global::G.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleSheetsRowAppendToolDTO>(ref reader, options);
            }
            global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO>(ref reader, options);
            }
            global::G.CreateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSlackSendMessageToolDTO>(ref reader, options);
            }
            global::G.CreateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSmsToolDTO>(ref reader, options);
            }
            global::G.CreateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateMcpToolDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelCalendarEventCreateToolDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelContactCreateToolDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelContactGetToolDTO>(ref reader, options);
            }
            global::G.CreateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSipRequestToolDTO>(ref reader, options);
            }
            global::G.CreateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVoicemailToolDTO>(ref reader, options);
            }

            var __value = new global::G.ToolControllerCreateRequest(
                discriminator?.Type,
                apiRequest,

                code,

                dtmf,

                endCall,

                function,

                transferCall,

                handoff,

                bash,

                computer,

                textEditor,

                query,

                googleCalendarEventCreate,

                googleSheetsRowAppend,

                googleCalendarAvailabilityCheck,

                slackMessageSend,

                sms,

                mcp,

                gohighlevelCalendarAvailabilityCheck,

                gohighlevelCalendarEventCreate,

                gohighlevelContactCreate,

                gohighlevelContactGet,

                sipRequest,

                voicemail
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolControllerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::G.CreateApiRequestToolDTO), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.CreateCodeToolDTO), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::G.CreateDtmfToolDTO), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::G.CreateEndCallToolDTO), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.CreateFunctionToolDTO), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::G.CreateTransferCallToolDTO), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::G.CreateHandoffToolDTO), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::G.CreateBashToolDTO), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::G.CreateComputerToolDTO), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::G.CreateTextEditorToolDTO), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::G.CreateQueryToolDTO), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::G.CreateGoogleCalendarCreateEventToolDTO), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::G.CreateGoogleSheetsRowAppendToolDTO), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::G.CreateSlackSendMessageToolDTO), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::G.CreateSmsToolDTO), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.CreateMcpToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::G.CreateGoHighLevelContactCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::G.CreateGoHighLevelContactGetToolDTO), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::G.CreateSipRequestToolDTO), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::G.CreateVoicemailToolDTO), options);
            }
        }
    }
}