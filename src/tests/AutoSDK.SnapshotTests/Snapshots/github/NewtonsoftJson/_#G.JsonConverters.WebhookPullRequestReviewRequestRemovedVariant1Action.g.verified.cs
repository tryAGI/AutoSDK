//HintName: G.JsonConverters.WebhookPullRequestReviewRequestRemovedVariant1Action.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestRemovedVariant1ActionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookPullRequestReviewRequestRemovedVariant1Action>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestRemovedVariant1Action ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookPullRequestReviewRequestRemovedVariant1Action existingValue,
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
                        return global::G.WebhookPullRequestReviewRequestRemovedVariant1ActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookPullRequestReviewRequestRemovedVariant1Action)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookPullRequestReviewRequestRemovedVariant1Action);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestRemovedVariant1Action value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookPullRequestReviewRequestRemovedVariant1ActionExtensions.ToValueString(value));
        }
    }
}
