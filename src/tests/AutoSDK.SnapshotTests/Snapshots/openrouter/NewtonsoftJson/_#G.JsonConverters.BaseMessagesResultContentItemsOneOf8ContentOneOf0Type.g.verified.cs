//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type existingValue,
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
                        return global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeExtensions.ToValueString(value));
        }
    }
}
