//HintName: G.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIModelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListMyAgentsResponseAgentVariant1LlmOpenAIModelNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel?>
    {
        /// <inheritdoc />
        public override global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel? existingValue,
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
                        return global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModel? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ListMyAgentsResponseAgentVariant1LlmOpenAIModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
