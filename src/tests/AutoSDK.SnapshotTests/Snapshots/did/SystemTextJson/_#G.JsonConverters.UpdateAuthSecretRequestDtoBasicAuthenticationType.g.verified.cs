//HintName: G.JsonConverters.UpdateAuthSecretRequestDtoBasicAuthenticationType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAuthSecretRequestDtoBasicAuthenticationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType>
    {
        /// <inheritdoc />
        public override global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType Read(
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
                        return global::G.UpdateAuthSecretRequestDtoBasicAuthenticationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.UpdateAuthSecretRequestDtoBasicAuthenticationTypeExtensions.ToValueString(value));
        }
    }
}
