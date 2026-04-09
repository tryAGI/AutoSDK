//HintName: G.JsonConverters.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners existingValue,
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
                        return global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToValueString(value));
        }
    }
}
