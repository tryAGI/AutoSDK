//HintName: G.JsonConverters.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessageJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage existingValue,
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
                        return global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessageExtensions.ToValueString(value));
        }
    }
}
