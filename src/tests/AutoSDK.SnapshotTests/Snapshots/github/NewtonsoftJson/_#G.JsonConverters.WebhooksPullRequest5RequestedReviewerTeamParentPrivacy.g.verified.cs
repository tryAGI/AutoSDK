//HintName: G.JsonConverters.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPullRequest5RequestedReviewerTeamParentPrivacyJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy existingValue,
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
                        return global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhooksPullRequest5RequestedReviewerTeamParentPrivacyExtensions.ToValueString(value));
        }
    }
}
