//HintName: G.JsonConverters.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion?>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? existingValue,
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
                        return global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionExtensions.ToValueString(value.Value));
            }
        }
    }
}
