//HintName: G.JsonConverters.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType>
    {
        /// <inheritdoc />
        public override global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType existingValue,
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
                        return global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerTypeExtensions.ToValueString(value));
        }
    }
}
