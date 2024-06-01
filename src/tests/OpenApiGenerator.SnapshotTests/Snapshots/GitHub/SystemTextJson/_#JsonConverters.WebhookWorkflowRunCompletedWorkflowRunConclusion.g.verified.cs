//HintName: JsonConverters.WebhookWorkflowRunCompletedWorkflowRunConclusion.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunCompletedWorkflowRunConclusionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion Read(
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
                        return global::G.WebhookWorkflowRunCompletedWorkflowRunConclusionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookWorkflowRunCompletedWorkflowRunConclusionExtensions.ToValueString(value));
        }
    }
}
