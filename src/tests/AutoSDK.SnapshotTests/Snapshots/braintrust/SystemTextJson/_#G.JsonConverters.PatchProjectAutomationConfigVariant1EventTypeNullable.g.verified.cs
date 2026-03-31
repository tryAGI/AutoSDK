//HintName: G.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PatchProjectAutomationConfigVariant1EventType?>
    {
        /// <inheritdoc />
        public override global::G.PatchProjectAutomationConfigVariant1EventType? Read(
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
                        return global::G.PatchProjectAutomationConfigVariant1EventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PatchProjectAutomationConfigVariant1EventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PatchProjectAutomationConfigVariant1EventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PatchProjectAutomationConfigVariant1EventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PatchProjectAutomationConfigVariant1EventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
