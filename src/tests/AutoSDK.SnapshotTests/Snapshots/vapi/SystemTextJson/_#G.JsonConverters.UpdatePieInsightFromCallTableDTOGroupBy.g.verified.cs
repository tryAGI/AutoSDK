//HintName: G.JsonConverters.UpdatePieInsightFromCallTableDTOGroupBy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdatePieInsightFromCallTableDTOGroupByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdatePieInsightFromCallTableDTOGroupBy>
    {
        /// <inheritdoc />
        public override global::G.UpdatePieInsightFromCallTableDTOGroupBy Read(
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
                        return global::G.UpdatePieInsightFromCallTableDTOGroupByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdatePieInsightFromCallTableDTOGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpdatePieInsightFromCallTableDTOGroupBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdatePieInsightFromCallTableDTOGroupBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.UpdatePieInsightFromCallTableDTOGroupByExtensions.ToValueString(value));
        }
    }
}
