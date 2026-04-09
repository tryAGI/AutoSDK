//HintName: G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf3CacheControlTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesRequestToolsItemsOneOf3CacheControlType>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolsItemsOneOf3CacheControlType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesRequestToolsItemsOneOf3CacheControlType existingValue,
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
                        return global::G.MessagesRequestToolsItemsOneOf3CacheControlTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesRequestToolsItemsOneOf3CacheControlType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesRequestToolsItemsOneOf3CacheControlType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesRequestToolsItemsOneOf3CacheControlType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesRequestToolsItemsOneOf3CacheControlTypeExtensions.ToValueString(value));
        }
    }
}
