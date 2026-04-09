//HintName: G.JsonConverters.WebhookWorkflowRunRequestedWorkflowRunStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunRequestedWorkflowRunStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookWorkflowRunRequestedWorkflowRunStatus>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunRequestedWorkflowRunStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookWorkflowRunRequestedWorkflowRunStatus existingValue,
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
                        return global::G.WebhookWorkflowRunRequestedWorkflowRunStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookWorkflowRunRequestedWorkflowRunStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookWorkflowRunRequestedWorkflowRunStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookWorkflowRunRequestedWorkflowRunStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookWorkflowRunRequestedWorkflowRunStatusExtensions.ToValueString(value));
        }
    }
}
