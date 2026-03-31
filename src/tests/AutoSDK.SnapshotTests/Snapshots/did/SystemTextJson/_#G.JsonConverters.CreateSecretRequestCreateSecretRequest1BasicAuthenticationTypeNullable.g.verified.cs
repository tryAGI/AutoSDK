//HintName: G.JsonConverters.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType?>
    {
        /// <inheritdoc />
        public override global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType? Read(
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
                        return global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
