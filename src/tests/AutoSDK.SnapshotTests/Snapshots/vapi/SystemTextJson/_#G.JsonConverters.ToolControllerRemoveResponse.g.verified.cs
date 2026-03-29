//HintName: G.JsonConverters.ToolControllerRemoveResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::G.ToolControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolControllerRemoveResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolControllerRemoveResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolControllerRemoveResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ApiRequestTool? apiRequest = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiRequestTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApiRequestTool)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeTool? code = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeTool)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DtmfTool? dtmf = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DtmfTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DtmfTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DtmfTool)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.EndCallTool? endCall = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EndCallTool)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FunctionTool? function = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GhlTool? ghl = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Ghl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GhlTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GhlTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GhlTool)}");
                ghl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferCallTool? transferCall = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferCallTool)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HandoffTool? handoff = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HandoffTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HandoffTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HandoffTool)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BashTool? bash = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BashTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BashTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BashTool)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ComputerTool? computer = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ComputerTool)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextEditorTool? textEditor = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEditorTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEditorTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextEditorTool)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.QueryTool? query = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.QueryTool)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoogleCalendarCreateEventTool? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCalendarCreateEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCalendarCreateEventTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoogleCalendarCreateEventTool)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoogleSheetsRowAppendTool? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleSheetsRowAppendTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleSheetsRowAppendTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoogleSheetsRowAppendTool)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCalendarCheckAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCalendarCheckAvailabilityTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoogleCalendarCheckAvailabilityTool)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SlackSendMessageTool? slackMessageSend = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SlackSendMessageTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SlackSendMessageTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SlackSendMessageTool)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SmsTool? sms = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SmsTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SmsTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SmsTool)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpTool? mcp = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpTool)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelCalendarAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelCalendarAvailabilityTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoHighLevelCalendarAvailabilityTool)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelCalendarEventCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelCalendarEventCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoHighLevelCalendarEventCreateTool)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoHighLevelContactCreateTool? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelContactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelContactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoHighLevelContactCreateTool)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoHighLevelContactGetTool? gohighlevelContactGet = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelContactGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelContactGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoHighLevelContactGetTool)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SipRequestTool? sipRequest = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SipRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SipRequestTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SipRequestTool)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoicemailTool? voicemail = default;
            if (discriminator?.Type == global::G.ToolControllerRemoveResponseDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoicemailTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoicemailTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoicemailTool)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolControllerRemoveResponse(
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
            global::G.ToolControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiRequestTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApiRequestTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DtmfTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DtmfTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DtmfTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsGhl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GhlTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GhlTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GhlTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ghl, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HandoffTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HandoffTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HandoffTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BashTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BashTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BashTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEditorTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEditorTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEditorTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCalendarCreateEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCalendarCreateEventTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleCalendarCreateEventTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleSheetsRowAppendTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleSheetsRowAppendTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleSheetsRowAppendTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleCalendarCheckAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleCalendarCheckAvailabilityTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleCalendarCheckAvailabilityTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SlackSendMessageTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SlackSendMessageTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SlackSendMessageTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SmsTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SmsTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SmsTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelCalendarAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelCalendarAvailabilityTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoHighLevelCalendarAvailabilityTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelCalendarEventCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelCalendarEventCreateTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoHighLevelCalendarEventCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelContactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelContactCreateTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoHighLevelContactCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoHighLevelContactGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoHighLevelContactGetTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoHighLevelContactGetTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SipRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SipRequestTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SipRequestTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoicemailTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoicemailTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoicemailTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeInfo);
            }
        }
    }
}