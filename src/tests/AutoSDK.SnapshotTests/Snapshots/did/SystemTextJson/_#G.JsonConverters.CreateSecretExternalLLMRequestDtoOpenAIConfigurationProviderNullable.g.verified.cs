//HintName: G.JsonConverters.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider?>
    {
        /// <inheritdoc />
        public override global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider? Read(
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
                        return global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
