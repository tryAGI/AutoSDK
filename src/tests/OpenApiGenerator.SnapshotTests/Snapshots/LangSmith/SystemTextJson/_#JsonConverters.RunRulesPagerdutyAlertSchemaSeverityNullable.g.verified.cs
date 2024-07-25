//HintName: JsonConverters.RunRulesPagerdutyAlertSchemaSeverityNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunRulesPagerdutyAlertSchemaSeverityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunRulesPagerdutyAlertSchemaSeverity?>
    {
        /// <inheritdoc />
        public override global::G.RunRulesPagerdutyAlertSchemaSeverity? Read(
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
                        return global::G.RunRulesPagerdutyAlertSchemaSeverityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RunRulesPagerdutyAlertSchemaSeverity)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunRulesPagerdutyAlertSchemaSeverity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RunRulesPagerdutyAlertSchemaSeverityExtensions.ToValueString(value.Value));
            }
        }
    }
}
