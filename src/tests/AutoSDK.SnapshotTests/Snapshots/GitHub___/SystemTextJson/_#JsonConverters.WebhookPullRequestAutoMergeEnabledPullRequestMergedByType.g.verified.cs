//HintName: JsonConverters.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestAutoMergeEnabledPullRequestMergedByTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType Read(
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
                        return global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedByTypeExtensions.ToValueString(value));
        }
    }
}
