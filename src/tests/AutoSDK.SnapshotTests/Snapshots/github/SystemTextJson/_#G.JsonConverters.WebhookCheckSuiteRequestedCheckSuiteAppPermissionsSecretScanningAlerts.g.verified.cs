//HintName: G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts>
    {
        /// <inheritdoc />
        public override global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts Read(
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
                        return global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsExtensions.ToValueString(value));
        }
    }
}
