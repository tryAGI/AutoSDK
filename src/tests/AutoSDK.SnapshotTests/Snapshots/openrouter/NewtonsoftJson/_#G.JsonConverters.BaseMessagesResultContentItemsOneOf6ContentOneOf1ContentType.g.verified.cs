//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType existingValue,
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
                        return global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeExtensions.ToValueString(value));
        }
    }
}
