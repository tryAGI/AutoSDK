//HintName: G.JsonConverters.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlertsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlertsNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlerts? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToValueString(value.Value));
            }
        }
    }
}
