//HintName: G.JsonConverters.AgentResponseDtoVariant1LlmGoogleTemplateNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentResponseDtoVariant1LlmGoogleTemplateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentResponseDtoVariant1LlmGoogleTemplate?>
    {
        /// <inheritdoc />
        public override global::G.AgentResponseDtoVariant1LlmGoogleTemplate? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.AgentResponseDtoVariant1LlmGoogleTemplateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AgentResponseDtoVariant1LlmGoogleTemplate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AgentResponseDtoVariant1LlmGoogleTemplate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentResponseDtoVariant1LlmGoogleTemplate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AgentResponseDtoVariant1LlmGoogleTemplateExtensions.ToValueString(value.Value));
            }
        }
    }
}
