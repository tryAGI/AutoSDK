//HintName: G.JsonConverters.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy Read(
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
                        return global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacyExtensions.ToValueString(value));
        }
    }
}
