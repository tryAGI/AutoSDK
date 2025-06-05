//HintName: G.JsonConverters.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails Read(
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
                        return global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmailsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEmailsExtensions.ToValueString(value));
        }
    }
}
