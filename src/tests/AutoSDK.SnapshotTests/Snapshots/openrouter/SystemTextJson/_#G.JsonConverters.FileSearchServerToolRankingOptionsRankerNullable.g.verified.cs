//HintName: G.JsonConverters.FileSearchServerToolRankingOptionsRankerNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FileSearchServerToolRankingOptionsRankerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FileSearchServerToolRankingOptionsRanker?>
    {
        /// <inheritdoc />
        public override global::G.FileSearchServerToolRankingOptionsRanker? Read(
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
                        return global::G.FileSearchServerToolRankingOptionsRankerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FileSearchServerToolRankingOptionsRanker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FileSearchServerToolRankingOptionsRanker?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FileSearchServerToolRankingOptionsRanker? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FileSearchServerToolRankingOptionsRankerExtensions.ToValueString(value.Value));
            }
        }
    }
}
