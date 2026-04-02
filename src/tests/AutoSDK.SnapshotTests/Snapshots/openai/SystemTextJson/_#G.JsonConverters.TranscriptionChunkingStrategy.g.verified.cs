//HintName: G.JsonConverters.TranscriptionChunkingStrategy.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptionChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranscriptionChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::G.TranscriptionChunkingStrategy Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("prefix_padding_ms")) __score1++;
            if (__jsonProps.Contains("silence_duration_ms")) __score1++;
            if (__jsonProps.Contains("threshold")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.TranscriptionChunkingStrategyEnum? @enum = default;
            global::G.VadConfig? vadConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptionChunkingStrategyEnum>(__rawJson, options);
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
                        vadConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VadConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@enum == null && vadConfig == null)
            {
                try
                {
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptionChunkingStrategyEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    vadConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VadConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TranscriptionChunkingStrategy(
                @enum,

                vadConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranscriptionChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeof(global::G.TranscriptionChunkingStrategyEnum), options);
            }
            else if (value.IsVadConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VadConfig, typeof(global::G.VadConfig), options);
            }
        }
    }
}