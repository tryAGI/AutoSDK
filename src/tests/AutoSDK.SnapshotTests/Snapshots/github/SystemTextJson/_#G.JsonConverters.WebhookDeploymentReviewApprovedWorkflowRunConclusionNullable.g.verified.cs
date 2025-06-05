//HintName: G.JsonConverters.WebhookDeploymentReviewApprovedWorkflowRunConclusionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentReviewApprovedWorkflowRunConclusionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion?>
    {
        /// <inheritdoc />
        public override global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion? Read(
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
                        return global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions.ToValueString(value.Value));
            }
        }
    }
}
