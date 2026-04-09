//HintName: G.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType>
    {
        /// <inheritdoc />
        public override global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType existingValue,
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
                        return global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeExtensions.ToValueString(value));
        }
    }
}
