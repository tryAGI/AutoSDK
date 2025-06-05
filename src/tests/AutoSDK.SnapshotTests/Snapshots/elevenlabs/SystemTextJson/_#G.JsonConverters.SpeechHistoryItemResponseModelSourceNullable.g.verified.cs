//HintName: G.JsonConverters.SpeechHistoryItemResponseModelSourceNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechHistoryItemResponseModelSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpeechHistoryItemResponseModelSource?>
    {
        /// <inheritdoc />
        public override global::G.SpeechHistoryItemResponseModelSource? Read(
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
                        return global::G.SpeechHistoryItemResponseModelSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SpeechHistoryItemResponseModelSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SpeechHistoryItemResponseModelSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpeechHistoryItemResponseModelSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SpeechHistoryItemResponseModelSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
