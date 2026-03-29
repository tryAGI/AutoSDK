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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolControllerCreateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolControllerCreateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolControllerCreateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateApiRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateApiRequestToolDTO)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCodeToolDTO? code = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCodeToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCodeToolDTO)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDtmfToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateDtmfToolDTO)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEndCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateEndCallToolDTO)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateFunctionToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateFunctionToolDTO)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTransferCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTransferCallToolDTO)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateHandoffToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateHandoffToolDTO)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateBashToolDTO? bash = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateBashToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateBashToolDTO)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateComputerToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateComputerToolDTO)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextEditorToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextEditorToolDTO)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateQueryToolDTO? query = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateQueryToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateQueryToolDTO)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarCreateEventToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleCalendarCreateEventToolDTO)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleSheetsRowAppendToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleSheetsRowAppendToolDTO)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackSendMessageToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSlackSendMessageToolDTO)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSmsToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSmsToolDTO)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMcpToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMcpToolDTO)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCalendarEventCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelContactCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelContactCreateToolDTO)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelContactGetToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelContactGetToolDTO)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSipRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSipRequestToolDTO)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerCreateRequestDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoicemailToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVoicemailToolDTO)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateApiRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateApiRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCodeToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCodeToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDtmfToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateDtmfToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEndCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateEndCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateFunctionToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateFunctionToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTransferCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTransferCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateHandoffToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateHandoffToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateBashToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateBashToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateComputerToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateComputerToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextEditorToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextEditorToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateQueryToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateQueryToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarCreateEventToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleCalendarCreateEventToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleSheetsRowAppendToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleSheetsRowAppendToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackSendMessageToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSlackSendMessageToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSmsToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSmsToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMcpToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateMcpToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCalendarEventCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelContactCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelContactCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelContactGetToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelContactGetToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSipRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSipRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVoicemailToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVoicemailToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeInfo);
            }
        }
    }
}