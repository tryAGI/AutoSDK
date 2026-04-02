//HintName: G.JsonConverters.TemplatesCreateTemplateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TemplatesCreateTemplateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplatesCreateTemplateRequest>
    {
        /// <inheritdoc />
        public override global::G.TemplatesCreateTemplateRequest Read(
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
            if (__jsonProps.Contains("agent_id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agent_file")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("update_existing_tools")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.TemplatesCreateTemplateRequestVariant1? agent = default;
            global::G.TemplatesCreateTemplateRequestVariant2? agentFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        agent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TemplatesCreateTemplateRequestVariant1>(__rawJson, options);
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
                        agentFile = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TemplatesCreateTemplateRequestVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agent == null && agentFile == null)
            {
                try
                {
                    agent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TemplatesCreateTemplateRequestVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentFile = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TemplatesCreateTemplateRequestVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TemplatesCreateTemplateRequest(
                agent,

                agentFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplatesCreateTemplateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent, typeof(global::G.TemplatesCreateTemplateRequestVariant1), options);
            }
            else if (value.IsAgentFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentFile, typeof(global::G.TemplatesCreateTemplateRequestVariant2), options);
            }
        }
    }
}