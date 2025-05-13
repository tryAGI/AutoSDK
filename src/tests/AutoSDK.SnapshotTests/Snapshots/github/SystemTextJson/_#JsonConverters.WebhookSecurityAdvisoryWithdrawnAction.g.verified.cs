//HintName: JsonConverters.WebhookSecurityAdvisoryWithdrawnAction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookSecurityAdvisoryWithdrawnActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookSecurityAdvisoryWithdrawnAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookSecurityAdvisoryWithdrawnAction Read(
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
                        return global::G.WebhookSecurityAdvisoryWithdrawnActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookSecurityAdvisoryWithdrawnAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookSecurityAdvisoryWithdrawnAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookSecurityAdvisoryWithdrawnAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookSecurityAdvisoryWithdrawnActionExtensions.ToValueString(value));
        }
    }
}
