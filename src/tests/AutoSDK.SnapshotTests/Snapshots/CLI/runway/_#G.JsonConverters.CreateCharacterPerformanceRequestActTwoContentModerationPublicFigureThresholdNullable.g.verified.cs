//HintName: G.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold?>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? Read(
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
                        return global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdExtensions.ToValueString(value.Value));
            }
        }
    }
}
