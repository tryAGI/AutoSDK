//HintName: G.JsonConverters.LLMConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LLMConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LLMConfig>
    {
        /// <inheritdoc />
        public override global::G.LLMConfig Read(
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
            if (__jsonProps.Contains("instructions")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("prompt_customization")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("template")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("instructions")) __score1++;
            if (__jsonProps.Contains("prompt_customization")) __score1++;
            if (__jsonProps.Contains("secretId")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("template")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("prompt_customization")) __score2++;
            if (__jsonProps.Contains("secretId")) __score2++;
            if (__jsonProps.Contains("temperature")) __score2++;
            if (__jsonProps.Contains("template")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("instructions")) __score3++;
            if (__jsonProps.Contains("model")) __score3++;
            if (__jsonProps.Contains("prompt_customization")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            if (__jsonProps.Contains("temperature")) __score3++;
            if (__jsonProps.Contains("template")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("instructions")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("prompt_customization")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            if (__jsonProps.Contains("temperature")) __score4++;
            if (__jsonProps.Contains("template")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.LLMConfigOpenAI? openAI = default;
            global::G.LLMConfigVariant2? value2 = default;
            global::G.LLMConfigVariant3? value3 = default;
            global::G.LLMConfigDId? dId = default;
            global::G.LLMConfigGoogle? google = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigOpenAI> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigOpenAI).Name}");
                        openAI = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant2).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant3).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigDId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigDId> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigDId).Name}");
                        dId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigGoogle> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigGoogle).Name}");
                        google = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAI == null && value2 == null && value3 == null && dId == null && google == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigOpenAI> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigOpenAI).Name}");
                    openAI = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant2).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant3).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigDId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigDId> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigDId).Name}");
                    dId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigGoogle> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigGoogle).Name}");
                    google = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.LLMConfig(
                openAI,

                value2,

                value3,

                dId,

                google
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LLMConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAI)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigOpenAI?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigOpenAI).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAI!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
            else if (value.IsDId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigDId), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigDId?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigDId).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DId!, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMConfigGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMConfigGoogle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMConfigGoogle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google!, typeInfo);
            }
        }
    }
}