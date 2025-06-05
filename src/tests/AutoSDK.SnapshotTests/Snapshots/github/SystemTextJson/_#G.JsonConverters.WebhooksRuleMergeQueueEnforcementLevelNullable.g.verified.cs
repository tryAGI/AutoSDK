//HintName: G.JsonConverters.WebhooksRuleMergeQueueEnforcementLevelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksRuleMergeQueueEnforcementLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksRuleMergeQueueEnforcementLevel?>
    {
        /// <inheritdoc />
        public override global::G.WebhooksRuleMergeQueueEnforcementLevel? Read(
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
                        return global::G.WebhooksRuleMergeQueueEnforcementLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksRuleMergeQueueEnforcementLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhooksRuleMergeQueueEnforcementLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksRuleMergeQueueEnforcementLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhooksRuleMergeQueueEnforcementLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
