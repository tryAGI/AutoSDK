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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UpdateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateApiRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateApiRequestToolDTO)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateCodeToolDTO? code = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateCodeToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateCodeToolDTO)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateDtmfToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateDtmfToolDTO)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateEndCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateEndCallToolDTO)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateFunctionToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateFunctionToolDTO)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTransferCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateTransferCallToolDTO)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateHandoffToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateHandoffToolDTO)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateBashToolDTO? bash = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateBashToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateBashToolDTO)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateComputerToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateComputerToolDTO)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTextEditorToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateTextEditorToolDTO)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateQueryToolDTO? query = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateQueryToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateQueryToolDTO)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleCalendarCreateEventToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoogleCalendarCreateEventToolDTO)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleSheetsRowAppendToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoogleSheetsRowAppendToolDTO)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSlackSendMessageToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateSlackSendMessageToolDTO)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSmsToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateSmsToolDTO)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateMcpToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateMcpToolDTO)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelContactCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoHighLevelContactCreateToolDTO)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelContactGetToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateGoHighLevelContactGetToolDTO)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSipRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateSipRequestToolDTO)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerUpdateRequestDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVoicemailToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateVoicemailToolDTO)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateApiRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateApiRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateCodeToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateCodeToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateDtmfToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateDtmfToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf!, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateEndCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateEndCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateFunctionToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateFunctionToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTransferCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateTransferCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateHandoffToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateHandoffToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff!, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateBashToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateBashToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash!, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateComputerToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateComputerToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer!, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTextEditorToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateTextEditorToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor!, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateQueryToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateQueryToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query!, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleCalendarCreateEventToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoogleCalendarCreateEventToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleSheetsRowAppendToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoogleSheetsRowAppendToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend!, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSlackSendMessageToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateSlackSendMessageToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend!, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSmsToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateSmsToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateMcpToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateMcpToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelContactCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoHighLevelContactCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateGoHighLevelContactGetToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateGoHighLevelContactGetToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet!, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateSipRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateSipRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest!, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVoicemailToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateVoicemailToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail!, typeInfo);
            }
        }
    }
}