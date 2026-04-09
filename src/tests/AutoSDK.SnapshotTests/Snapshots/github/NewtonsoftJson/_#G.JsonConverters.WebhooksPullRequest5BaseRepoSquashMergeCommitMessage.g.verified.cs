//HintName: G.JsonConverters.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPullRequest5BaseRepoSquashMergeCommitMessageJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage existingValue,
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
                        return global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhooksPullRequest5BaseRepoSquashMergeCommitMessageExtensions.ToValueString(value));
        }
    }
}
