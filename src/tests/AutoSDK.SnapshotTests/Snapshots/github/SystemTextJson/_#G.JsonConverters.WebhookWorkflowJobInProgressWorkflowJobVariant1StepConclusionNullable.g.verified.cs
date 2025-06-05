//HintName: G.JsonConverters.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion?>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion? Read(
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
                        return global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusionExtensions.ToValueString(value.Value));
            }
        }
    }
}
