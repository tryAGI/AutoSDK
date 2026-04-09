//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type?>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type? existingValue,
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
                        return global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
