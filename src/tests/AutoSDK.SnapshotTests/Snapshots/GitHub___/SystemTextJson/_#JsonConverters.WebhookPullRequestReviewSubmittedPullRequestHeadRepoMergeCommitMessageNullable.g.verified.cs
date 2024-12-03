//HintName: JsonConverters.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessageNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessage?>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessage? Read(
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
                        return global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessage)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookPullRequestReviewSubmittedPullRequestHeadRepoMergeCommitMessageExtensions.ToValueString(value.Value));
            }
        }
    }
}
