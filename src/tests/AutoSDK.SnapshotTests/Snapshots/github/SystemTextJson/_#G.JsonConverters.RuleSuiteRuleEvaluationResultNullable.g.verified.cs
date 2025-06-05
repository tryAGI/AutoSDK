//HintName: G.JsonConverters.RuleSuiteRuleEvaluationResultNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RuleSuiteRuleEvaluationResultNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RuleSuiteRuleEvaluationResult?>
    {
        /// <inheritdoc />
        public override global::G.RuleSuiteRuleEvaluationResult? Read(
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
                        return global::G.RuleSuiteRuleEvaluationResultExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RuleSuiteRuleEvaluationResult)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RuleSuiteRuleEvaluationResult?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RuleSuiteRuleEvaluationResult? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RuleSuiteRuleEvaluationResultExtensions.ToValueString(value.Value));
            }
        }
    }
}
