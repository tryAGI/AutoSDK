//HintName: G.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType existingValue,
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
                        return global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
