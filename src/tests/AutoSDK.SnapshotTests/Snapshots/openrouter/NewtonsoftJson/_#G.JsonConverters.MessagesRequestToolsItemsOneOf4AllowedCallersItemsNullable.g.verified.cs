//HintName: G.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf4AllowedCallersItemsNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems?>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems? existingValue,
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
                        return global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItemsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItemsExtensions.ToValueString(value.Value));
            }
        }
    }
}
