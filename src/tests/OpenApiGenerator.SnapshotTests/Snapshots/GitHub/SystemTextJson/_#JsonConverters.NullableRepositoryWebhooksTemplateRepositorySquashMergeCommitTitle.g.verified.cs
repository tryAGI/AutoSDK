//HintName: JsonConverters.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitle.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitle Read(
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
                        return global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
