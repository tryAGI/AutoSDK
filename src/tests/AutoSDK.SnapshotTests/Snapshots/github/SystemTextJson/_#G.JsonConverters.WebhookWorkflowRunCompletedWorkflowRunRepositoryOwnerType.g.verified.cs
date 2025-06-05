//HintName: G.JsonConverters.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType Read(
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
                        return global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerTypeExtensions.ToValueString(value));
        }
    }
}
