//HintName: G.JsonConverters.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects existingValue,
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
                        return global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToValueString(value));
        }
    }
}
