//HintName: JsonConverters.RuleSuiteRuleEvaluationsEnforcementNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RuleSuiteRuleEvaluationsEnforcementNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RuleSuiteRuleEvaluationsEnforcement?>
    {
        /// <inheritdoc />
        public override global::G.RuleSuiteRuleEvaluationsEnforcement? Read(
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
                        return global::G.RuleSuiteRuleEvaluationsEnforcementExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RuleSuiteRuleEvaluationsEnforcement)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RuleSuiteRuleEvaluationsEnforcement? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RuleSuiteRuleEvaluationsEnforcementExtensions.ToValueString(value.Value));
            }
        }
    }
}
