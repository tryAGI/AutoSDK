//HintName: G.JsonConverters.AgentResponseDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentResponseDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentResponseDto>
    {
        /// <inheritdoc />
        public override global::G.AgentResponseDto Read(
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
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("greetings")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("knowledge")) __score0++;
            if (__jsonProps.Contains("llm")) __score0++;
            if (__jsonProps.Contains("presenter")) __score0++;
            if (__jsonProps.Contains("preview_description")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("starter_message")) __score0++;
            if (__jsonProps.Contains("triggers")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("embed")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.AgentResponseDtoVariant1? agentResponseDtoVariant1 = default;
            global::G.AgentResponseDtoVariant2? agentResponseDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        agentResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentResponseDtoVariant1>(__rawJson, options);
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
                        agentResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentResponseDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agentResponseDtoVariant1 == null && agentResponseDtoVariant2 == null)
            {
                try
                {
                    agentResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentResponseDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentResponseDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AgentResponseDto(
                agentResponseDtoVariant1,

                agentResponseDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentResponseDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAgentResponseDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentResponseDtoVariant1, typeof(global::G.AgentResponseDtoVariant1), options);
            }
            else if (value.IsAgentResponseDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentResponseDtoVariant2, typeof(global::G.AgentResponseDtoVariant2), options);
            }
        }
    }
}