//HintName: G.JsonConverters.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacyJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy existingValue,
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
                        return global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacyExtensions.ToValueString(value));
        }
    }
}
