//HintName: JsonConverters.WebhookCodeScanningAlertClosedByUserAction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCodeScanningAlertClosedByUserActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCodeScanningAlertClosedByUserAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookCodeScanningAlertClosedByUserAction Read(
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
                        return global::G.WebhookCodeScanningAlertClosedByUserActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCodeScanningAlertClosedByUserAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCodeScanningAlertClosedByUserAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookCodeScanningAlertClosedByUserActionExtensions.ToValueString(value));
        }
    }
}
