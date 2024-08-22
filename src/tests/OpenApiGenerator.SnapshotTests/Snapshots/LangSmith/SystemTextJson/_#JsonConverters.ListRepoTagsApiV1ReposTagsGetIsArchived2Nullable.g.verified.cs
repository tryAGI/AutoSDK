//HintName: JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2Nullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2?>
    {
        /// <inheritdoc />
        public override global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2? Read(
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
                        return global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListRepoTagsApiV1ReposTagsGetIsArchived2Extensions.ToValueString(value.Value));
            }
        }
    }
}
