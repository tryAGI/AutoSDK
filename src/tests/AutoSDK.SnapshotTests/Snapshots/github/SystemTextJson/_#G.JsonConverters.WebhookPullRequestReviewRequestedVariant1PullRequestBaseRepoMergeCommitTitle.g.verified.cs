//HintName: G.JsonConverters.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle Read(
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
                        return global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
