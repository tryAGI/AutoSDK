//HintName: G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListReposApiV1ReposGetSortDirectionVariant2?>
    {
        /// <inheritdoc />
        public override global::G.ListReposApiV1ReposGetSortDirectionVariant2? Read(
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
                        return global::G.ListReposApiV1ReposGetSortDirectionVariant2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListReposApiV1ReposGetSortDirectionVariant2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListReposApiV1ReposGetSortDirectionVariant2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListReposApiV1ReposGetSortDirectionVariant2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListReposApiV1ReposGetSortDirectionVariant2Extensions.ToValueString(value.Value));
            }
        }
    }
}
