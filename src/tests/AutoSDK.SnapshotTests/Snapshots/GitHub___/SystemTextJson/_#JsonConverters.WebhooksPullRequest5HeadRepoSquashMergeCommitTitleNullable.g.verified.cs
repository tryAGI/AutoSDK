//HintName: JsonConverters.WebhooksPullRequest5HeadRepoSquashMergeCommitTitleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPullRequest5HeadRepoSquashMergeCommitTitleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitle?>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitle? Read(
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
                        return global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhooksPullRequest5HeadRepoSquashMergeCommitTitleExtensions.ToValueString(value.Value));
            }
        }
    }
}
