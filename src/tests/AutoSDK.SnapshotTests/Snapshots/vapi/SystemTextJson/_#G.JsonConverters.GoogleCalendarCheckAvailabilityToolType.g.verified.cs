//HintName: G.JsonConverters.GoogleCalendarCheckAvailabilityToolType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleCalendarCheckAvailabilityToolTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GoogleCalendarCheckAvailabilityToolType>
    {
        /// <inheritdoc />
        public override global::G.GoogleCalendarCheckAvailabilityToolType Read(
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
                        return global::G.GoogleCalendarCheckAvailabilityToolTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GoogleCalendarCheckAvailabilityToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GoogleCalendarCheckAvailabilityToolType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GoogleCalendarCheckAvailabilityToolType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GoogleCalendarCheckAvailabilityToolTypeExtensions.ToValueString(value));
        }
    }
}
