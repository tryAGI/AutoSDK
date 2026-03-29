//HintName: G.JsonConverters.SpanExperimentItemBulkWriteViewSourceNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpanExperimentItemBulkWriteViewSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpanExperimentItemBulkWriteViewSource?>
    {
        /// <inheritdoc />
        public override global::G.SpanExperimentItemBulkWriteViewSource? Read(
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
                        return global::G.SpanExperimentItemBulkWriteViewSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SpanExperimentItemBulkWriteViewSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SpanExperimentItemBulkWriteViewSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpanExperimentItemBulkWriteViewSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SpanExperimentItemBulkWriteViewSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
