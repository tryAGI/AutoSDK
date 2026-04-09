//HintName: G.JsonConverters.MessagesRequestThinkingOneOf1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestThinkingOneOf1TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesRequestThinkingOneOf1Type>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestThinkingOneOf1Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesRequestThinkingOneOf1Type existingValue,
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
                        return global::G.MessagesRequestThinkingOneOf1TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesRequestThinkingOneOf1Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesRequestThinkingOneOf1Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesRequestThinkingOneOf1Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesRequestThinkingOneOf1TypeExtensions.ToValueString(value));
        }
    }
}
