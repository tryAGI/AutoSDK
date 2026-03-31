//HintName: G.JsonConverters.OutputItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItems>
    {
        /// <inheritdoc />
        public override global::G.OutputItems Read(
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
            if (__jsonProps.Contains("format")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("signature")) __score1++;
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
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::G.OutputMessageItem? outputMessageItem = default;
            global::G.OutputReasoningItem? outputReasoningItem = default;
            global::G.OutputFunctionCallItem? outputFunctionCallItem = default;
            global::G.OutputWebSearchCallItem? outputWebSearchCallItem = default;
            global::G.OutputFileSearchCallItem? outputFileSearchCallItem = default;
            global::G.OutputImageGenerationCallItem? outputImageGenerationCallItem = default;
            global::G.OutputServerToolItem? outputServerToolItem = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageItem).Name}");
                        outputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputReasoningItem).Name}");
                        outputReasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                        outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                        outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                        outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                        outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                        outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessageItem == null && outputReasoningItem == null && outputFunctionCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputServerToolItem == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageItem).Name}");
                    outputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputReasoningItem).Name}");
                    outputReasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                    outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                    outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                    outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                    outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                    outputServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItems(
                outputMessageItem,

                outputReasoningItem,

                outputFunctionCallItem,

                outputWebSearchCallItem,

                outputFileSearchCallItem,

                outputImageGenerationCallItem,

                outputServerToolItem
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputMessageItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageItem!, typeInfo);
            }
            else if (value.IsOutputReasoningItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputReasoningItem!, typeInfo);
            }
            else if (value.IsOutputFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFunctionCallItem!, typeInfo);
            }
            else if (value.IsOutputWebSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputWebSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputWebSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputFileSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputFileSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputFileSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFileSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputImageGenerationCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputImageGenerationCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputImageGenerationCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputImageGenerationCallItem!, typeInfo);
            }
            else if (value.IsOutputServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputServerToolItem!, typeInfo);
            }
        }
    }
}