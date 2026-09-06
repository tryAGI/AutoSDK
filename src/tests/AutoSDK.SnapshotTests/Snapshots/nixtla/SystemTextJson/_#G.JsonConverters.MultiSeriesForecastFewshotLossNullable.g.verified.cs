//HintName: G.JsonConverters.MultiSeriesForecastFewshotLossNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MultiSeriesForecastFewshotLossNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MultiSeriesForecastFewshotLoss?>
    {
        /// <inheritdoc />
        public override global::G.MultiSeriesForecastFewshotLoss? Read(
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
                        return global::G.MultiSeriesForecastFewshotLossExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MultiSeriesForecastFewshotLoss)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MultiSeriesForecastFewshotLoss?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MultiSeriesForecastFewshotLoss? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MultiSeriesForecastFewshotLossExtensions.ToValueString(value.Value));
            }
        }
    }
}
