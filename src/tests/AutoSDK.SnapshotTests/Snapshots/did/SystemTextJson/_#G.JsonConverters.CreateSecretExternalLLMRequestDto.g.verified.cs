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
                        openAIConfiguration = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration>(__rawJson, options);
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
                        createSecretExternalLLMRequestDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretExternalLLMRequestDtoVariant2>(__rawJson, options);
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
                    openAIConfiguration = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createSecretExternalLLMRequestDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretExternalLLMRequestDtoVariant2>(__rawJson, options);
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

            if (value.IsOpenAIConfiguration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIConfiguration, typeof(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfiguration), options);
            }
            else if (value.IsCreateSecretExternalLLMRequestDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateSecretExternalLLMRequestDtoVariant2, typeof(global::G.CreateSecretExternalLLMRequestDtoVariant2), options);
            }
        }
    }
}