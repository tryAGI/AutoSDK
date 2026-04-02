//HintName: G.JsonConverters.MessageOrToolCall.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageOrToolCallJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageOrToolCall>
    {
        /// <inheritdoc />
        public override global::G.MessageOrToolCall Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("created_timestamp")) __score0++;
            if (__jsonProps.Contains("message_id")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("arguments")) __score1++;
            if (__jsonProps.Contains("created_timestamp")) __score1++;
            if (__jsonProps.Contains("message_id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("thought_signature")) __score1++;
            if (__jsonProps.Contains("tool_call_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("created_timestamp")) __score2++;
            if (__jsonProps.Contains("message_id")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("successful")) __score2++;
            if (__jsonProps.Contains("tool_call_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("created_timestamp")) __score3++;
            if (__jsonProps.Contains("former_node_id")) __score3++;
            if (__jsonProps.Contains("former_node_name")) __score3++;
            if (__jsonProps.Contains("message_id")) __score3++;
            if (__jsonProps.Contains("new_node_id")) __score3++;
            if (__jsonProps.Contains("new_node_name")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("created_timestamp")) __score4++;
            if (__jsonProps.Contains("former_state_name")) __score4++;
            if (__jsonProps.Contains("message_id")) __score4++;
            if (__jsonProps.Contains("new_state_name")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.Message? message = default;
            global::G.ToolCallInvocationMessage? invocation = default;
            global::G.ToolCallResultMessage? result = default;
            global::G.NodeTransitionMessage? nodeTransition = default;
            global::G.StateTransitionMessage? stateTransition = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Message), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Message> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Message).Name}");
                        message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationMessage).Name}");
                        invocation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultMessage).Name}");
                        result = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionMessage).Name}");
                        nodeTransition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateTransitionMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateTransitionMessage).Name}");
                        stateTransition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message == null && invocation == null && result == null && nodeTransition == null && stateTransition == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Message), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Message> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Message).Name}");
                    message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationMessage).Name}");
                    invocation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultMessage).Name}");
                    result = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionMessage).Name}");
                    nodeTransition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateTransitionMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateTransitionMessage).Name}");
                    stateTransition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MessageOrToolCall(
                message,

                invocation,

                result,

                nodeTransition,

                stateTransition
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageOrToolCall value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Message), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Message?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Message).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsInvocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Invocation!, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result!, typeInfo);
            }
            else if (value.IsNodeTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeTransition!, typeInfo);
            }
            else if (value.IsStateTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StateTransitionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StateTransitionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StateTransitionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateTransition!, typeInfo);
            }
        }
    }
}