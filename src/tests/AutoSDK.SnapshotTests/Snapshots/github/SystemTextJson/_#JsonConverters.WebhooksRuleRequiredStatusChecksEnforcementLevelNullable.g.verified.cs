//HintName: JsonConverters.WebhooksRuleRequiredStatusChecksEnforcementLevelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksRuleRequiredStatusChecksEnforcementLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel?>
    {
        /// <inheritdoc />
        public override global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel? Read(
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
                        return global::G.WebhooksRuleRequiredStatusChecksEnforcementLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksRuleRequiredStatusChecksEnforcementLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhooksRuleRequiredStatusChecksEnforcementLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
