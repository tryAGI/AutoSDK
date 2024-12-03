//HintName: JsonConverters.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessage>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessage Read(
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
                        return global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessage)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestSynchronizePullRequestBaseRepoMergeCommitMessageExtensions.ToValueString(value));
        }
    }
}
