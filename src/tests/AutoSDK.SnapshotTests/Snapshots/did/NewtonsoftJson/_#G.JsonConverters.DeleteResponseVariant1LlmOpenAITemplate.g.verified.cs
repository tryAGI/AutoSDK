//HintName: G.JsonConverters.DeleteResponseVariant1LlmOpenAITemplate.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteResponseVariant1LlmOpenAITemplateJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DeleteResponseVariant1LlmOpenAITemplate>
    {
        /// <inheritdoc />
        public override global::G.DeleteResponseVariant1LlmOpenAITemplate ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DeleteResponseVariant1LlmOpenAITemplate existingValue,
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
                        return global::G.DeleteResponseVariant1LlmOpenAITemplateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DeleteResponseVariant1LlmOpenAITemplate)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DeleteResponseVariant1LlmOpenAITemplate);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DeleteResponseVariant1LlmOpenAITemplate value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.DeleteResponseVariant1LlmOpenAITemplateExtensions.ToValueString(value));
        }
    }
}
