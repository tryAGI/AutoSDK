//HintName: G.JsonConverters.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets existingValue,
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
                        return global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecretsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecrets value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSecretsExtensions.ToValueString(value));
        }
    }
}
