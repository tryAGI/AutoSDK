//HintName: G.JsonConverters.CreateGoogleCalendarCheckAvailabilityToolDTOTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGoogleCalendarCheckAvailabilityToolDTOTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateGoogleCalendarCheckAvailabilityToolDTOType?>
    {
        /// <inheritdoc />
        public override global::G.CreateGoogleCalendarCheckAvailabilityToolDTOType? Read(
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
                        return global::G.CreateGoogleCalendarCheckAvailabilityToolDTOTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateGoogleCalendarCheckAvailabilityToolDTOType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateGoogleCalendarCheckAvailabilityToolDTOType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateGoogleCalendarCheckAvailabilityToolDTOType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateGoogleCalendarCheckAvailabilityToolDTOTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
