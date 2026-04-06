//HintName: G.JsonConverters.CreateSecretExternalLLMRequestDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateSecretExternalLLMRequestDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSecretExternalLLMRequestDto>
    {
        /// <inheritdoc />
        public override global::G.CreateSecretExternalLLMRequestDto Read(
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
            if (__jsonProps.Contains("api_key")) __score0++;
            if (__jsonProps.Contains("endpoint")) __score0++;
            if (__jsonProps.Contains("isStreaming")) __score0++;
            if (__jsonProps.Contains("maxMessages")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("api_key")) __score1++;
            if (__jsonProps.Contains("endpoint")) __score1++;
            if (__jsonProps.Contains("isStreaming")) __score1++;
            if (__jsonProps.Contains("maxMessages")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? openAIConfiguration = default;
            global::G.CreateSecretExternalLLMRequestDtoVariant2? createSecretExternalLLMRequestDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration).Name}");
                        openAIConfiguration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2).Name}");
                        createSecretExternalLLMRequestDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAIConfiguration == null && createSecretExternalLLMRequestDtoVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration).Name}");
                    openAIConfiguration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2).Name}");
                    createSecretExternalLLMRequestDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateSecretExternalLLMRequestDto(
                openAIConfiguration,

                createSecretExternalLLMRequestDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSecretExternalLLMRequestDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAIConfiguration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIConfiguration!, typeInfo);
            }
            else if (value.IsCreateSecretExternalLLMRequestDtoVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretExternalLLMRequestDtoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateSecretExternalLLMRequestDtoVariant2!, typeInfo);
            }
        }
    }
}