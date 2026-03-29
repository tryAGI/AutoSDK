//HintName: G.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersion.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchWebhookSubscriptionsByIdRequestVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PatchWebhookSubscriptionsByIdRequestVersion>
    {
        /// <inheritdoc />
        public override global::G.PatchWebhookSubscriptionsByIdRequestVersion Read(
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
                        return global::G.PatchWebhookSubscriptionsByIdRequestVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PatchWebhookSubscriptionsByIdRequestVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PatchWebhookSubscriptionsByIdRequestVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PatchWebhookSubscriptionsByIdRequestVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PatchWebhookSubscriptionsByIdRequestVersionExtensions.ToValueString(value));
        }
    }
}
