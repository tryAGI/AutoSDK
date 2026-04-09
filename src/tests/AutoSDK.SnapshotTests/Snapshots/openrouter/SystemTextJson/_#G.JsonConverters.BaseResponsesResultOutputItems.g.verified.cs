//HintName: G.JsonConverters.BaseResponsesResultOutputItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseResponsesResultOutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseResponsesResultOutputItems>
    {
        /// <inheritdoc />
        public override global::G.BaseResponsesResultOutputItems Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("encrypted_content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("summary")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("queries")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("result")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.OutputMessage? outputMessage = default;
            global::G.OutputItemReasoning? outputItemReasoning = default;
            global::G.OutputItemFunctionCall? outputItemFunctionCall = default;
            global::G.OutputItemWebSearchCall? outputItemWebSearchCall = default;
            global::G.OutputItemFileSearchCall? outputItemFileSearchCall = default;
            global::G.OutputItemImageGenerationCall? outputItemImageGenerationCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                        outputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoning).Name}");
                        outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFunctionCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFunctionCall).Name}");
                        outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCall).Name}");
                        outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFileSearchCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFileSearchCall).Name}");
                        outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemImageGenerationCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemImageGenerationCall).Name}");
                        outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessage == null && outputItemReasoning == null && outputItemFunctionCall == null && outputItemWebSearchCall == null && outputItemFileSearchCall == null && outputItemImageGenerationCall == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                    outputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoning).Name}");
                    outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFunctionCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFunctionCall).Name}");
                    outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCall).Name}");
                    outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFileSearchCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFileSearchCall).Name}");
                    outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemImageGenerationCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemImageGenerationCall).Name}");
                    outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseResponsesResultOutputItems(
                outputMessage,

                outputItemReasoning,

                outputItemFunctionCall,

                outputItemWebSearchCall,

                outputItemFileSearchCall,

                outputItemImageGenerationCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseResponsesResultOutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage!, typeInfo);
            }
            else if (value.IsOutputItemReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoning!, typeInfo);
            }
            else if (value.IsOutputItemFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFunctionCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFunctionCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCall!, typeInfo);
            }
            else if (value.IsOutputItemWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemWebSearchCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemWebSearchCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCall!, typeInfo);
            }
            else if (value.IsOutputItemFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemFileSearchCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemFileSearchCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFileSearchCall!, typeInfo);
            }
            else if (value.IsOutputItemImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemImageGenerationCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemImageGenerationCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemImageGenerationCall!, typeInfo);
            }
        }
    }
}