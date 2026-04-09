//HintName: G.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType>
    {
        /// <inheritdoc />
        public override global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType existingValue,
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
                        return global::G.TopicAutomationConfigFacetFunctionVariant2GlobalTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TopicAutomationConfigFacetFunctionVariant2GlobalType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TopicAutomationConfigFacetFunctionVariant2GlobalTypeExtensions.ToValueString(value));
        }
    }
}
