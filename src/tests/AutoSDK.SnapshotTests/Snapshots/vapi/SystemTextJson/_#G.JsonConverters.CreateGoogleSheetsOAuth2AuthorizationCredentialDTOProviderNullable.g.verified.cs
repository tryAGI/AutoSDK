//HintName: G.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider?>
    {
        /// <inheritdoc />
        public override global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Read(
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
                        return global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
