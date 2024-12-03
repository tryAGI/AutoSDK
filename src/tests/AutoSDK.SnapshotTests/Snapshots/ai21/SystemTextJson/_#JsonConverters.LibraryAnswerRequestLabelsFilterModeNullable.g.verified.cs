//HintName: JsonConverters.LibraryAnswerRequestLabelsFilterModeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LibraryAnswerRequestLabelsFilterModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LibraryAnswerRequestLabelsFilterMode?>
    {
        /// <inheritdoc />
        public override global::G.LibraryAnswerRequestLabelsFilterMode? Read(
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
                        return global::G.LibraryAnswerRequestLabelsFilterModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.LibraryAnswerRequestLabelsFilterMode)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LibraryAnswerRequestLabelsFilterMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.LibraryAnswerRequestLabelsFilterModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
