//HintName: G.JsonConverters.WebhookDeploymentReviewRejectedWorkflowRunActorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentReviewRejectedWorkflowRunActorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookDeploymentReviewRejectedWorkflowRunActorType>
    {
        /// <inheritdoc />
        public override global::G.WebhookDeploymentReviewRejectedWorkflowRunActorType Read(
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
                        return global::G.WebhookDeploymentReviewRejectedWorkflowRunActorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookDeploymentReviewRejectedWorkflowRunActorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookDeploymentReviewRejectedWorkflowRunActorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookDeploymentReviewRejectedWorkflowRunActorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookDeploymentReviewRejectedWorkflowRunActorTypeExtensions.ToValueString(value));
        }
    }
}
