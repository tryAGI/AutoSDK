//HintName: G.JsonConverters.GoHighLevelCalendarAvailabilityToolWithToolCallTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoHighLevelCalendarAvailabilityToolWithToolCallTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GoHighLevelCalendarAvailabilityToolWithToolCallType?>
    {
        /// <inheritdoc />
        public override global::G.GoHighLevelCalendarAvailabilityToolWithToolCallType? Read(
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
                        return global::G.GoHighLevelCalendarAvailabilityToolWithToolCallTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GoHighLevelCalendarAvailabilityToolWithToolCallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GoHighLevelCalendarAvailabilityToolWithToolCallType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GoHighLevelCalendarAvailabilityToolWithToolCallType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GoHighLevelCalendarAvailabilityToolWithToolCallTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
