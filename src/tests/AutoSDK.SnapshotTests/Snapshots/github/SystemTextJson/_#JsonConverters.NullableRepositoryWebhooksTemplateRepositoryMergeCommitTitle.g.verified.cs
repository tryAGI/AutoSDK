//HintName: JsonConverters.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle Read(
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
                        return global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
