//HintName: G.JsonConverters.WebhookCodeScanningAlertReopenedByUserAlertStateNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCodeScanningAlertReopenedByUserAlertStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCodeScanningAlertReopenedByUserAlertState?>
    {
        /// <inheritdoc />
        public override global::G.WebhookCodeScanningAlertReopenedByUserAlertState? Read(
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
                        return global::G.WebhookCodeScanningAlertReopenedByUserAlertStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCodeScanningAlertReopenedByUserAlertState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookCodeScanningAlertReopenedByUserAlertState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookCodeScanningAlertReopenedByUserAlertStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
