//HintName: G.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ViewOptionsTableViewOptionsExcludedMeasureType?>
    {
        /// <inheritdoc />
        public override global::G.ViewOptionsTableViewOptionsExcludedMeasureType? Read(
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
                        return global::G.ViewOptionsTableViewOptionsExcludedMeasureTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ViewOptionsTableViewOptionsExcludedMeasureType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ViewOptionsTableViewOptionsExcludedMeasureType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ViewOptionsTableViewOptionsExcludedMeasureType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ViewOptionsTableViewOptionsExcludedMeasureTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
