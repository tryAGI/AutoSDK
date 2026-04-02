//HintName: G.JsonConverters.ToolControllerFindOneResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerFindOneResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolControllerFindOneResponse>
    {
        /// <inheritdoc />
        public override global::G.ToolControllerFindOneResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolControllerFindOneResponseDiscriminator>(ref readerCopy, options);

            global::G.ApiRequestTool? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApiRequestTool>(ref reader, options);
            }
            global::G.CodeTool? code = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeTool>(ref reader, options);
            }
            global::G.DtmfTool? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DtmfTool>(ref reader, options);
            }
            global::G.EndCallTool? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EndCallTool>(ref reader, options);
            }
            global::G.FunctionTool? function = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionTool>(ref reader, options);
            }
            global::G.GhlTool? ghl = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Ghl)
            {
                ghl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GhlTool>(ref reader, options);
            }
            global::G.TransferCallTool? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferCallTool>(ref reader, options);
            }
            global::G.HandoffTool? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HandoffTool>(ref reader, options);
            }
            global::G.BashTool? bash = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BashTool>(ref reader, options);
            }
            global::G.ComputerTool? computer = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerTool>(ref reader, options);
            }
            global::G.TextEditorTool? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextEditorTool>(ref reader, options);
            }
            global::G.QueryTool? query = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::G.QueryTool>(ref reader, options);
            }
            global::G.GoogleCalendarCreateEventTool? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleCalendarCreateEventTool>(ref reader, options);
            }
            global::G.GoogleSheetsRowAppendTool? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleSheetsRowAppendTool>(ref reader, options);
            }
            global::G.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleCalendarCheckAvailabilityTool>(ref reader, options);
            }
            global::G.SlackSendMessageTool? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SlackSendMessageTool>(ref reader, options);
            }
            global::G.SmsTool? sms = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SmsTool>(ref reader, options);
            }
            global::G.McpTool? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpTool>(ref reader, options);
            }
            global::G.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoHighLevelCalendarAvailabilityTool>(ref reader, options);
            }
            global::G.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoHighLevelCalendarEventCreateTool>(ref reader, options);
            }
            global::G.GoHighLevelContactCreateTool? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoHighLevelContactCreateTool>(ref reader, options);
            }
            global::G.GoHighLevelContactGetTool? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoHighLevelContactGetTool>(ref reader, options);
            }
            global::G.SipRequestTool? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SipRequestTool>(ref reader, options);
            }
            global::G.VoicemailTool? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerFindOneResponseDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoicemailTool>(ref reader, options);
            }

            var __value = new global::G.ToolControllerFindOneResponse(
                discriminator?.Type,
                apiRequest,

                code,

                dtmf,

                endCall,

                function,

                ghl,

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
            global::G.ToolControllerFindOneResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::G.ApiRequestTool), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.CodeTool), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::G.DtmfTool), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::G.EndCallTool), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.FunctionTool), options);
            }
            else if (value.IsGhl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ghl, typeof(global::G.GhlTool), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::G.TransferCallTool), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::G.HandoffTool), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::G.BashTool), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::G.ComputerTool), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::G.TextEditorTool), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::G.QueryTool), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::G.GoogleCalendarCreateEventTool), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::G.GoogleSheetsRowAppendTool), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::G.GoogleCalendarCheckAvailabilityTool), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::G.SlackSendMessageTool), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::G.SmsTool), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.McpTool), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::G.GoHighLevelCalendarAvailabilityTool), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::G.GoHighLevelCalendarEventCreateTool), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::G.GoHighLevelContactCreateTool), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::G.GoHighLevelContactGetTool), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::G.SipRequestTool), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::G.VoicemailTool), options);
            }
        }
    }
}