//HintName: G.JsonConverters.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatusExtensions.ToValueString(value));
        }
    }
}
