//HintName: G.JsonConverters.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource>
    {
        /// <inheritdoc />
        public override global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource existingValue,
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
                        return global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceExtensions.ToValueString(value));
        }
    }
}
