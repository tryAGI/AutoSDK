//HintName: G.JsonConverters.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy existingValue,
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
                        return global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyExtensions.ToValueString(value));
        }
    }
}
