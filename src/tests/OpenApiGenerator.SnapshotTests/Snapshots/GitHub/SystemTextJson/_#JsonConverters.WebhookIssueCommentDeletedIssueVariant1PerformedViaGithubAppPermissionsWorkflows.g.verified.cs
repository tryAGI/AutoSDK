//HintName: JsonConverters.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflows.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflowsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflows>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflows Read(
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
                        return global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflowsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflows)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflows value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsWorkflowsExtensions.ToValueString(value));
        }
    }
}
