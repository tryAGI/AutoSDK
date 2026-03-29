//HintName: G.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject?>
    {
        /// <inheritdoc />
        public override global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject? Read(
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
                        return global::G.GetAnalyticsGraphsFeedbacksScoresResponseObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetAnalyticsGraphsFeedbacksScoresResponseObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
