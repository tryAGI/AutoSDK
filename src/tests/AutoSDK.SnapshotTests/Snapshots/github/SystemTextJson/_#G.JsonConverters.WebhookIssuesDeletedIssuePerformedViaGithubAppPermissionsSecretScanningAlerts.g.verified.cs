//HintName: G.JsonConverters.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts Read(
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
                        return global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToValueString(value));
        }
    }
}
