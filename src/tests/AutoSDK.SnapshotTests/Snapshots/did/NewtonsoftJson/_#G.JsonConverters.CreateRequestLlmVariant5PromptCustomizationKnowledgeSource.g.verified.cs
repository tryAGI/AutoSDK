//HintName: G.JsonConverters.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource>
    {
        /// <inheritdoc />
        public override global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource existingValue,
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
                        return global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceExtensions.ToValueString(value));
        }
    }
}
