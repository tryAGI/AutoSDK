//HintName: JsonConverters.PullRequestWebhookVariant2SquashMergeCommitTitle.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public sealed class PullRequestWebhookVariant2SquashMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PullRequestWebhookVariant2SquashMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.PullRequestWebhookVariant2SquashMergeCommitTitle Read(
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
                        return global::G.PullRequestWebhookVariant2SquashMergeCommitTitleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PullRequestWebhookVariant2SquashMergeCommitTitle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PullRequestWebhookVariant2SquashMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PullRequestWebhookVariant2SquashMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
