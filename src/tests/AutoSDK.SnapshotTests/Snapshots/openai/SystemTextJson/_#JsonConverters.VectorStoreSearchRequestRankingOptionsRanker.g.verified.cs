//HintName: JsonConverters.VectorStoreSearchRequestRankingOptionsRanker.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VectorStoreSearchRequestRankingOptionsRankerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VectorStoreSearchRequestRankingOptionsRanker>
    {
        /// <inheritdoc />
        public override global::G.VectorStoreSearchRequestRankingOptionsRanker Read(
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
                        return global::G.VectorStoreSearchRequestRankingOptionsRankerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.VectorStoreSearchRequestRankingOptionsRanker)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VectorStoreSearchRequestRankingOptionsRanker value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.VectorStoreSearchRequestRankingOptionsRankerExtensions.ToValueString(value));
        }
    }
}
