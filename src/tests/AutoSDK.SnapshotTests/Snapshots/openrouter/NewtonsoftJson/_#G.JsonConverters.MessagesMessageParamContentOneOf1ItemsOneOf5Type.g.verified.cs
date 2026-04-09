//HintName: G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesMessageParamContentOneOf1ItemsOneOf5TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type>
    {
        /// <inheritdoc />
        public override global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type existingValue,
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
                        return global::G.MessagesMessageParamContentOneOf1ItemsOneOf5TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf5Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesMessageParamContentOneOf1ItemsOneOf5TypeExtensions.ToValueString(value));
        }
    }
}
