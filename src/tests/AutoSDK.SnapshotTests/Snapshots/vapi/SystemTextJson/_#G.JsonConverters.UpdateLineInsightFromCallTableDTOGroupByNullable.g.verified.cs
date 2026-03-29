//HintName: G.JsonConverters.UpdateLineInsightFromCallTableDTOGroupByNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateLineInsightFromCallTableDTOGroupByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateLineInsightFromCallTableDTOGroupBy?>
    {
        /// <inheritdoc />
        public override global::G.UpdateLineInsightFromCallTableDTOGroupBy? Read(
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
                        return global::G.UpdateLineInsightFromCallTableDTOGroupByExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdateLineInsightFromCallTableDTOGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UpdateLineInsightFromCallTableDTOGroupBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateLineInsightFromCallTableDTOGroupBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UpdateLineInsightFromCallTableDTOGroupByExtensions.ToValueString(value.Value));
            }
        }
    }
}
