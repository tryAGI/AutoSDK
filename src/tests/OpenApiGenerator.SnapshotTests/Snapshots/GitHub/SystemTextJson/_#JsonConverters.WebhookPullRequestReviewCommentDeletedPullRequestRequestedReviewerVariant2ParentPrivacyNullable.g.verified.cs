//HintName: JsonConverters.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacyNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacy?>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacy? Read(
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
                        return global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2ParentPrivacyExtensions.ToValueString(value.Value));
            }
        }
    }
}
