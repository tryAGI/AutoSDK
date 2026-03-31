//HintName: G.JsonConverters.UpdateSecretRequestUpdateSecretRequest1ApiKeyType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyType>
    {
        /// <inheritdoc />
        public override global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyType Read(
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
                        return global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeExtensions.ToValueString(value));
        }
    }
}
