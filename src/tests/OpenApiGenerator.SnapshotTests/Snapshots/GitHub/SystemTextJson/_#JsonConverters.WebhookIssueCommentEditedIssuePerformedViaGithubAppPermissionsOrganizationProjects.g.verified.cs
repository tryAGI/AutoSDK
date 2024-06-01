//HintName: JsonConverters.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjects.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjects>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjects Read(
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
                        return global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjectsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjects)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjects value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationProjectsExtensions.ToValueString(value));
        }
    }
}
