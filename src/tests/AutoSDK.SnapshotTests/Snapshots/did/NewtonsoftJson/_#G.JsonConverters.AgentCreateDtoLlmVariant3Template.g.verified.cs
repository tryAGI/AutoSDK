//HintName: G.JsonConverters.AgentCreateDtoLlmVariant3Template.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentCreateDtoLlmVariant3TemplateJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentCreateDtoLlmVariant3Template>
    {
        /// <inheritdoc />
        public override global::G.AgentCreateDtoLlmVariant3Template ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentCreateDtoLlmVariant3Template existingValue,
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
                        return global::G.AgentCreateDtoLlmVariant3TemplateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentCreateDtoLlmVariant3Template)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentCreateDtoLlmVariant3Template);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentCreateDtoLlmVariant3Template value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AgentCreateDtoLlmVariant3TemplateExtensions.ToValueString(value));
        }
    }
}
