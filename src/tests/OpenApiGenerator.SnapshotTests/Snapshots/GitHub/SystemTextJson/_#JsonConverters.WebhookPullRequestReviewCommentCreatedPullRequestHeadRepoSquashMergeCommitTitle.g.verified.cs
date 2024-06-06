﻿//HintName: JsonConverters.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle Read(
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
                        return global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}