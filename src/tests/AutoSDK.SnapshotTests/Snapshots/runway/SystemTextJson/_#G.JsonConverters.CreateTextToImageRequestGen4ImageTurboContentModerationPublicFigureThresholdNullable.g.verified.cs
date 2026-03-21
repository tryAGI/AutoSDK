//HintName: G.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold?>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold? Read(
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
                        return global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdExtensions.ToValueString(value.Value));
            }
        }
    }
}
