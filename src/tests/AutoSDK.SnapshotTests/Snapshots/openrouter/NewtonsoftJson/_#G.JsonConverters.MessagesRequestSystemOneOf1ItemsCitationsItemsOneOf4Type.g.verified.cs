//HintName: G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type existingValue,
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
                        return global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeExtensions.ToValueString(value));
        }
    }
}
