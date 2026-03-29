//HintName: G.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpsertVideoTranslationsApiRequestAutoGenerateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpsertVideoTranslationsApiRequestAutoGenerate?>
    {
        /// <inheritdoc />
        public override global::G.UpsertVideoTranslationsApiRequestAutoGenerate? Read(
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
                        return global::G.UpsertVideoTranslationsApiRequestAutoGenerateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpsertVideoTranslationsApiRequestAutoGenerate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpsertVideoTranslationsApiRequestAutoGenerate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpsertVideoTranslationsApiRequestAutoGenerate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UpsertVideoTranslationsApiRequestAutoGenerateExtensions.ToValueString(value.Value));
            }
        }
    }
}
