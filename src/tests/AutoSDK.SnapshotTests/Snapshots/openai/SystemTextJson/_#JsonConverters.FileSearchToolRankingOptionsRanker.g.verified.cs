//HintName: JsonConverters.FileSearchToolRankingOptionsRanker.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FileSearchToolRankingOptionsRankerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FileSearchToolRankingOptionsRanker>
    {
        /// <inheritdoc />
        public override global::G.FileSearchToolRankingOptionsRanker Read(
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
                        return global::G.FileSearchToolRankingOptionsRankerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FileSearchToolRankingOptionsRanker)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FileSearchToolRankingOptionsRanker value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FileSearchToolRankingOptionsRankerExtensions.ToValueString(value));
        }
    }
}
