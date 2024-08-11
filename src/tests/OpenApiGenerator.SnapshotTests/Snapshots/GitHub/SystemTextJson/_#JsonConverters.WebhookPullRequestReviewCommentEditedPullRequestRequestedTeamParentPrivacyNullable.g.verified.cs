//HintName: JsonConverters.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacyNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacy?>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacy? Read(
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
                        return global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamParentPrivacyExtensions.ToValueString(value.Value));
            }
        }
    }
}
