//HintName: JsonConverters.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2PrivacyNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2PrivacyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy?>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy? Read(
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
                        return global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2PrivacyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2PrivacyExtensions.ToValueString(value.Value));
            }
        }
    }
}
