//HintName: G.JsonConverters.ToolControllerUpdateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::G.ToolControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::G.UpdateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateApiRequestToolDTO>(ref reader, options);
            }
            global::G.UpdateCodeToolDTO? code = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateCodeToolDTO>(ref reader, options);
            }
            global::G.UpdateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateDtmfToolDTO>(ref reader, options);
            }
            global::G.UpdateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateEndCallToolDTO>(ref reader, options);
            }
            global::G.UpdateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateFunctionToolDTO>(ref reader, options);
            }
            global::G.UpdateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateTransferCallToolDTO>(ref reader, options);
            }
            global::G.UpdateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateHandoffToolDTO>(ref reader, options);
            }
            global::G.UpdateBashToolDTO? bash = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateBashToolDTO>(ref reader, options);
            }
            global::G.UpdateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateComputerToolDTO>(ref reader, options);
            }
            global::G.UpdateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateTextEditorToolDTO>(ref reader, options);
            }
            global::G.UpdateQueryToolDTO? query = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateQueryToolDTO>(ref reader, options);
            }
            global::G.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoogleCalendarCreateEventToolDTO>(ref reader, options);
            }
            global::G.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoogleSheetsRowAppendToolDTO>(ref reader, options);
            }
            global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO>(ref reader, options);
            }
            global::G.UpdateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateSlackSendMessageToolDTO>(ref reader, options);
            }
            global::G.UpdateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateSmsToolDTO>(ref reader, options);
            }
            global::G.UpdateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateMcpToolDTO>(ref reader, options);
            }
            global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO>(ref reader, options);
            }
            global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO>(ref reader, options);
            }
            global::G.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoHighLevelContactCreateToolDTO>(ref reader, options);
            }
            global::G.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateGoHighLevelContactGetToolDTO>(ref reader, options);
            }
            global::G.UpdateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateSipRequestToolDTO>(ref reader, options);
            }
            global::G.UpdateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateVoicemailToolDTO>(ref reader, options);
            }

            var __value = new global::G.ToolControllerUpdateRequest(
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
            global::G.ToolControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::G.UpdateApiRequestToolDTO), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.UpdateCodeToolDTO), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::G.UpdateDtmfToolDTO), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::G.UpdateEndCallToolDTO), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.UpdateFunctionToolDTO), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::G.UpdateTransferCallToolDTO), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::G.UpdateHandoffToolDTO), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::G.UpdateBashToolDTO), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::G.UpdateComputerToolDTO), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::G.UpdateTextEditorToolDTO), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::G.UpdateQueryToolDTO), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::G.UpdateGoogleCalendarCreateEventToolDTO), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::G.UpdateGoogleSheetsRowAppendToolDTO), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::G.UpdateSlackSendMessageToolDTO), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::G.UpdateSmsToolDTO), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.UpdateMcpToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::G.UpdateGoHighLevelContactCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::G.UpdateGoHighLevelContactGetToolDTO), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::G.UpdateSipRequestToolDTO), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::G.UpdateVoicemailToolDTO), options);
            }
        }
    }
}