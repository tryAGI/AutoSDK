//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType existingValue,
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
                        return global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeExtensions.ToValueString(value));
        }
    }
}
