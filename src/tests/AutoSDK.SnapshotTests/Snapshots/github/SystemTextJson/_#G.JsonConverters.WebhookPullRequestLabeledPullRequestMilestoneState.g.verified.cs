//HintName: G.JsonConverters.WebhookPullRequestLabeledPullRequestMilestoneState.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestLabeledPullRequestMilestoneStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestLabeledPullRequestMilestoneState>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestLabeledPullRequestMilestoneState Read(
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
                        return global::G.WebhookPullRequestLabeledPullRequestMilestoneStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestLabeledPullRequestMilestoneState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookPullRequestLabeledPullRequestMilestoneState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestLabeledPullRequestMilestoneState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestLabeledPullRequestMilestoneStateExtensions.ToValueString(value));
        }
    }
}
