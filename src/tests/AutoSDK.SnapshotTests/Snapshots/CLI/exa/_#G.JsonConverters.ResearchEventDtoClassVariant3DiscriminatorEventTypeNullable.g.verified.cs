//HintName: G.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant3DiscriminatorEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchEventDtoClassVariant3DiscriminatorEventType?>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant3DiscriminatorEventType? Read(
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
                        return global::G.ResearchEventDtoClassVariant3DiscriminatorEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ResearchEventDtoClassVariant3DiscriminatorEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ResearchEventDtoClassVariant3DiscriminatorEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchEventDtoClassVariant3DiscriminatorEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ResearchEventDtoClassVariant3DiscriminatorEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
