//HintName: G.JsonConverters.StartSpeakingPlanSmartEndpointingEnabledNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class StartSpeakingPlanSmartEndpointingEnabledNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StartSpeakingPlanSmartEndpointingEnabled?>
    {
        /// <inheritdoc />
        public override global::G.StartSpeakingPlanSmartEndpointingEnabled? Read(
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
                        return global::G.StartSpeakingPlanSmartEndpointingEnabledExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.StartSpeakingPlanSmartEndpointingEnabled)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.StartSpeakingPlanSmartEndpointingEnabled?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StartSpeakingPlanSmartEndpointingEnabled? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.StartSpeakingPlanSmartEndpointingEnabledExtensions.ToValueString(value.Value));
            }
        }
    }
}
