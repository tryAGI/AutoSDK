//HintName: G.JsonConverters.AzureOpenAIExternalLLMCreateDtoTemplate.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureOpenAIExternalLLMCreateDtoTemplateJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AzureOpenAIExternalLLMCreateDtoTemplate>
    {
        /// <inheritdoc />
        public override global::G.AzureOpenAIExternalLLMCreateDtoTemplate ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AzureOpenAIExternalLLMCreateDtoTemplate existingValue,
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
                        return global::G.AzureOpenAIExternalLLMCreateDtoTemplateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AzureOpenAIExternalLLMCreateDtoTemplate)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AzureOpenAIExternalLLMCreateDtoTemplate);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AzureOpenAIExternalLLMCreateDtoTemplate value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AzureOpenAIExternalLLMCreateDtoTemplateExtensions.ToValueString(value));
        }
    }
}
