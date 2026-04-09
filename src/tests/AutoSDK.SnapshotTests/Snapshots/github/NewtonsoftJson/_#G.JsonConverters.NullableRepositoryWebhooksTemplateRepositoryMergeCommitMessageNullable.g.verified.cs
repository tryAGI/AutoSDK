//HintName: G.JsonConverters.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessageNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessageNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage?>
    {
        /// <inheritdoc />
        public override global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage? existingValue,
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
                        return global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessageExtensions.ToValueString(value.Value));
            }
        }
    }
}
