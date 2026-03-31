//HintName: G.JsonConverters.UtteranceOrToolCall.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UtteranceOrToolCallJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UtteranceOrToolCall>
    {
        /// <inheritdoc />
        public override global::G.UtteranceOrToolCall Read(
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
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("words")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("arguments")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("thought_signature")) __score1++;
            if (__jsonProps.Contains("tool_call_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("successful")) __score2++;
            if (__jsonProps.Contains("tool_call_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("former_node_id")) __score3++;
            if (__jsonProps.Contains("former_node_name")) __score3++;
            if (__jsonProps.Contains("new_node_id")) __score3++;
            if (__jsonProps.Contains("new_node_name")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("digit")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.Utterance? value1 = default;
            global::G.ToolCallInvocationUtterance? value2 = default;
            global::G.ToolCallResultUtterance? value3 = default;
            global::G.NodeTransitionUtterance? value4 = default;
            global::G.DTMFUtterance? value5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Utterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Utterance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Utterance).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationUtterance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationUtterance).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultUtterance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultUtterance).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionUtterance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionUtterance).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DTMFUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DTMFUtterance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DTMFUtterance).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Utterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Utterance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Utterance).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationUtterance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationUtterance).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultUtterance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultUtterance).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionUtterance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionUtterance).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DTMFUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DTMFUtterance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DTMFUtterance).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.UtteranceOrToolCall(
                value1,

                value2,

                value3,

                value4,

                value5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UtteranceOrToolCall value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Utterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Utterance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Utterance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallInvocationUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallInvocationUtterance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallInvocationUtterance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallResultUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallResultUtterance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallResultUtterance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeTransitionUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeTransitionUtterance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeTransitionUtterance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DTMFUtterance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DTMFUtterance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DTMFUtterance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5!, typeInfo);
            }
        }
    }
}