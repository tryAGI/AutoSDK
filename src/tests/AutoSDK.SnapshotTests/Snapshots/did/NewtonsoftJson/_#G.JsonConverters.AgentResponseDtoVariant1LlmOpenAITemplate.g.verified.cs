//HintName: G.JsonConverters.AgentResponseDtoVariant1LlmOpenAITemplate.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentResponseDtoVariant1LlmOpenAITemplateJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentResponseDtoVariant1LlmOpenAITemplate>
    {
        /// <inheritdoc />
        public override global::G.AgentResponseDtoVariant1LlmOpenAITemplate ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentResponseDtoVariant1LlmOpenAITemplate existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.AgentResponseDtoVariant1LlmOpenAITemplateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentResponseDtoVariant1LlmOpenAITemplate)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentResponseDtoVariant1LlmOpenAITemplate);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentResponseDtoVariant1LlmOpenAITemplate value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AgentResponseDtoVariant1LlmOpenAITemplateExtensions.ToValueString(value));
        }
    }
}
