//HintName: G.JsonConverters.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners existingValue,
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
                        return global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToValueString(value));
        }
    }
}
