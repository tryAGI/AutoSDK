//HintName: G.JsonConverters.WebhookConfigurationWebhookEventsVariant1Item.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookConfigurationWebhookEventsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookConfigurationWebhookEventsVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.WebhookConfigurationWebhookEventsVariant1Item Read(
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
                        return global::G.WebhookConfigurationWebhookEventsVariant1ItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookConfigurationWebhookEventsVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookConfigurationWebhookEventsVariant1Item);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookConfigurationWebhookEventsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookConfigurationWebhookEventsVariant1ItemExtensions.ToValueString(value));
        }
    }
}
