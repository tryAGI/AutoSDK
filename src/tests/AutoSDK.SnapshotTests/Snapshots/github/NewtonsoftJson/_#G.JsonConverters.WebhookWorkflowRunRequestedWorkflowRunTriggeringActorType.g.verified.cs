//HintName: G.JsonConverters.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunRequestedWorkflowRunTriggeringActorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType existingValue,
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
                        return global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorTypeExtensions.ToValueString(value));
        }
    }
}
