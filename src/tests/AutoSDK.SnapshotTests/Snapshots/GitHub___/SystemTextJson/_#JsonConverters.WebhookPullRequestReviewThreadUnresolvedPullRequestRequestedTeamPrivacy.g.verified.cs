//HintName: JsonConverters.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacy Read(
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
                        return global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamPrivacyExtensions.ToValueString(value));
        }
    }
}
