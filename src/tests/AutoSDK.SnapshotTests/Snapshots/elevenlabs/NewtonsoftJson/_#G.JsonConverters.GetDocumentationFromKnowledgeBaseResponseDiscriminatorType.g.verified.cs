//HintName: G.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType existingValue,
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
                        return global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
