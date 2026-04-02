//HintName: G.JsonConverters.Tool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Tool>
    {
        /// <inheritdoc />
        public override global::G.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("execution_message_description")) __score0++;
            if (__jsonProps.Contains("execution_message_type")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("speak_during_execution")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom_sip_headers")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("execution_message_description")) __score1++;
            if (__jsonProps.Contains("execution_message_type")) __score1++;
            if (__jsonProps.Contains("ignore_e164_validation")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("speak_during_execution")) __score1++;
            if (__jsonProps.Contains("transfer_destination")) __score1++;
            if (__jsonProps.Contains("transfer_option")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cal_api_key")) __score2++;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("event_type_id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("timezone")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cal_api_key")) __score3++;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("event_type_id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("timezone")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("agent_id")) __score4++;
            if (__jsonProps.Contains("agent_version")) __score4++;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("execution_message_description")) __score4++;
            if (__jsonProps.Contains("execution_message_type")) __score4++;
            if (__jsonProps.Contains("keep_current_language")) __score4++;
            if (__jsonProps.Contains("keep_current_voice")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("post_call_analysis_setting")) __score4++;
            if (__jsonProps.Contains("speak_during_execution")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("webhook_setting")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("delay_ms")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("sms_content")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("args_at_root")) __score7++;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("execution_message_description")) __score7++;
            if (__jsonProps.Contains("execution_message_type")) __score7++;
            if (__jsonProps.Contains("headers")) __score7++;
            if (__jsonProps.Contains("method")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("parameters")) __score7++;
            if (__jsonProps.Contains("query_params")) __score7++;
            if (__jsonProps.Contains("response_variables")) __score7++;
            if (__jsonProps.Contains("speak_after_execution")) __score7++;
            if (__jsonProps.Contains("speak_during_execution")) __score7++;
            if (__jsonProps.Contains("timeout_ms")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code")) __score8++;
            if (__jsonProps.Contains("description")) __score8++;
            if (__jsonProps.Contains("execution_message_description")) __score8++;
            if (__jsonProps.Contains("execution_message_type")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("response_variables")) __score8++;
            if (__jsonProps.Contains("speak_after_execution")) __score8++;
            if (__jsonProps.Contains("speak_during_execution")) __score8++;
            if (__jsonProps.Contains("timeout_ms")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("description")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("variables")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("description")) __score10++;
            if (__jsonProps.Contains("execution_message_description")) __score10++;
            if (__jsonProps.Contains("execution_message_type")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("speak_during_execution")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("description")) __score11++;
            if (__jsonProps.Contains("execution_message_description")) __score11++;
            if (__jsonProps.Contains("execution_message_type")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("speak_during_execution")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("description")) __score12++;
            if (__jsonProps.Contains("execution_message_description")) __score12++;
            if (__jsonProps.Contains("execution_message_type")) __score12++;
            if (__jsonProps.Contains("input_schema")) __score12++;
            if (__jsonProps.Contains("mcp_id")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("response_variables")) __score12++;
            if (__jsonProps.Contains("speak_after_execution")) __score12++;
            if (__jsonProps.Contains("speak_during_execution")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::G.EndCallTool? endCall = default;
            global::G.TransferCallTool? transferCall = default;
            global::G.CheckAvailabilityCalTool? checkAvailabilityCal = default;
            global::G.BookAppointmentCalTool? bookAppointmentCal = default;
            global::G.AgentSwapTool? agentSwap = default;
            global::G.PressDigitTool? pressDigit = default;
            global::G.SendSMSTool? sendSM = default;
            global::G.CustomTool? custom = default;
            global::G.CodeTool? code = default;
            global::G.ExtractDynamicVariableTool? extractDynamicVariable = default;
            global::G.BridgeTransferTool? bridgeTransfer = default;
            global::G.CancelTransferTool? cancelTransfer = default;
            global::G.MCPTool? mcp = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallTool).Name}");
                        endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallTool).Name}");
                        transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckAvailabilityCalTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CheckAvailabilityCalTool).Name}");
                        checkAvailabilityCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BookAppointmentCalTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BookAppointmentCalTool).Name}");
                        bookAppointmentCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSwapTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSwapTool).Name}");
                        agentSwap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PressDigitTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PressDigitTool).Name}");
                        pressDigit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SendSMSTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SendSMSTool).Name}");
                        sendSM = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomTool).Name}");
                        custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeTool).Name}");
                        code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtractDynamicVariableTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtractDynamicVariableTool).Name}");
                        extractDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BridgeTransferTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BridgeTransferTool).Name}");
                        bridgeTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelTransferTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelTransferTool).Name}");
                        cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (endCall == null && transferCall == null && checkAvailabilityCal == null && bookAppointmentCal == null && agentSwap == null && pressDigit == null && sendSM == null && custom == null && code == null && extractDynamicVariable == null && bridgeTransfer == null && cancelTransfer == null && mcp == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallTool).Name}");
                    endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallTool).Name}");
                    transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckAvailabilityCalTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CheckAvailabilityCalTool).Name}");
                    checkAvailabilityCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BookAppointmentCalTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BookAppointmentCalTool).Name}");
                    bookAppointmentCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSwapTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSwapTool).Name}");
                    agentSwap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PressDigitTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PressDigitTool).Name}");
                    pressDigit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SendSMSTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SendSMSTool).Name}");
                    sendSM = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomTool).Name}");
                    custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeTool).Name}");
                    code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtractDynamicVariableTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtractDynamicVariableTool).Name}");
                    extractDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BridgeTransferTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BridgeTransferTool).Name}");
                    bridgeTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelTransferTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelTransferTool).Name}");
                    cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Tool(
                endCall,

                transferCall,

                checkAvailabilityCal,

                bookAppointmentCal,

                agentSwap,

                pressDigit,

                sendSM,

                custom,

                code,

                extractDynamicVariable,

                bridgeTransfer,

                cancelTransfer,

                mcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!, typeInfo);
            }
            else if (value.IsCheckAvailabilityCal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckAvailabilityCalTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CheckAvailabilityCalTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckAvailabilityCal!, typeInfo);
            }
            else if (value.IsBookAppointmentCal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BookAppointmentCalTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BookAppointmentCalTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BookAppointmentCal!, typeInfo);
            }
            else if (value.IsAgentSwap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSwapTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSwapTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSwap!, typeInfo);
            }
            else if (value.IsPressDigit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PressDigitTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PressDigitTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PressDigit!, typeInfo);
            }
            else if (value.IsSendSM)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SendSMSTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SendSMSTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SendSM!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsExtractDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExtractDynamicVariableTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExtractDynamicVariableTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractDynamicVariable!, typeInfo);
            }
            else if (value.IsBridgeTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BridgeTransferTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BridgeTransferTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BridgeTransfer!, typeInfo);
            }
            else if (value.IsCancelTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelTransferTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelTransferTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CancelTransfer!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
        }
    }
}