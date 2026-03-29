//HintName: G.JsonConverters.GoogleCalendarOAuth2ClientCredentialProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleCalendarOAuth2ClientCredentialProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GoogleCalendarOAuth2ClientCredentialProvider?>
    {
        /// <inheritdoc />
        public override global::G.GoogleCalendarOAuth2ClientCredentialProvider? Read(
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
                        return global::G.GoogleCalendarOAuth2ClientCredentialProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GoogleCalendarOAuth2ClientCredentialProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GoogleCalendarOAuth2ClientCredentialProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GoogleCalendarOAuth2ClientCredentialProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GoogleCalendarOAuth2ClientCredentialProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
