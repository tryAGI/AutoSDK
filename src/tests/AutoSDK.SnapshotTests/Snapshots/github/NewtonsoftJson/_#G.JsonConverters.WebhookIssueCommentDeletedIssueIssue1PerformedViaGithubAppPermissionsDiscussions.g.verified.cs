//HintName: G.JsonConverters.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions existingValue,
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
                        return global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussions value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToValueString(value));
        }
    }
}
