﻿//HintName: G.JsonConverters.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlertsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlertsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts? Read(
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
                        return global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToValueString(value.Value));
            }
        }
    }
}
