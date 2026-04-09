//HintName: G.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListMyAgentsResponseAgentVariant1LlmDIdProviderNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider?>
    {
        /// <inheritdoc />
        public override global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider? existingValue,
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
                        return global::G.ListMyAgentsResponseAgentVariant1LlmDIdProviderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListMyAgentsResponseAgentVariant1LlmDIdProvider? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ListMyAgentsResponseAgentVariant1LlmDIdProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
