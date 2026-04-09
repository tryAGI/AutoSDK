//HintName: G.JsonConverters.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource>
    {
        /// <inheritdoc />
        public override global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource existingValue,
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
                        return global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceExtensions.ToValueString(value));
        }
    }
}
