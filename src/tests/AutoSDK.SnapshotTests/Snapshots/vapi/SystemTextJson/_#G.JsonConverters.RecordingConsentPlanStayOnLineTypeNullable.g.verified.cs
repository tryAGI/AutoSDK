//HintName: G.JsonConverters.RecordingConsentPlanStayOnLineTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RecordingConsentPlanStayOnLineTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RecordingConsentPlanStayOnLineType?>
    {
        /// <inheritdoc />
        public override global::G.RecordingConsentPlanStayOnLineType? Read(
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
                        return global::G.RecordingConsentPlanStayOnLineTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RecordingConsentPlanStayOnLineType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RecordingConsentPlanStayOnLineType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RecordingConsentPlanStayOnLineType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RecordingConsentPlanStayOnLineTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
