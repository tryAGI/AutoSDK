//HintName: G.JsonConverters.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy Read(
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
                        return global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacyExtensions.ToValueString(value));
        }
    }
}
