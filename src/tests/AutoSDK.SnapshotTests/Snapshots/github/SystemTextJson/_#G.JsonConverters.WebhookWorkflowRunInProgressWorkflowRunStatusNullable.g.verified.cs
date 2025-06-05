//HintName: G.JsonConverters.WebhookWorkflowRunInProgressWorkflowRunStatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunInProgressWorkflowRunStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookWorkflowRunInProgressWorkflowRunStatus?>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunInProgressWorkflowRunStatus? Read(
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
                        return global::G.WebhookWorkflowRunInProgressWorkflowRunStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookWorkflowRunInProgressWorkflowRunStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookWorkflowRunInProgressWorkflowRunStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookWorkflowRunInProgressWorkflowRunStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookWorkflowRunInProgressWorkflowRunStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
