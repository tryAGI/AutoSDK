//HintName: G.JsonConverters.ProducerConfig3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ProducerConfig3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ProducerConfig3>
    {
        /// <inheritdoc />
        public override global::G.ProducerConfig3 Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1? slackChannelReader = default;
            global::G.PipelinesPreviewPipelineRequestProducerConfigVariant2? customWebhook = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1>(__rawJson, options);
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
                        customWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (slackChannelReader == null && customWebhook == null)
            {
                try
                {
                    slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ProducerConfig3(
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ProducerConfig3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSlackChannelReader)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader, typeof(global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1), options);
            }
            else if (value.IsCustomWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook, typeof(global::G.PipelinesPreviewPipelineRequestProducerConfigVariant2), options);
            }
        }
    }
}