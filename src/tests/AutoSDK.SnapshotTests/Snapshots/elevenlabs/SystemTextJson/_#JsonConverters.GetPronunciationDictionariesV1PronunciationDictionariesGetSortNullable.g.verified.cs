//HintName: JsonConverters.GetPronunciationDictionariesV1PronunciationDictionariesGetSortNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPronunciationDictionariesV1PronunciationDictionariesGetSortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort?>
    {
        /// <inheritdoc />
        public override global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? Read(
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
                        return global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSortExtensions.ToValueString(value.Value));
            }
        }
    }
}
