//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type existingValue,
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
                        return global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeExtensions.ToValueString(value));
        }
    }
}
