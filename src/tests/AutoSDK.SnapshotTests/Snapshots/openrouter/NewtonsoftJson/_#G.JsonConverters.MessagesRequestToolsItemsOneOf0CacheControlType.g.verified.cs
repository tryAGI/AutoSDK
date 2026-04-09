//HintName: G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf0CacheControlTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MessagesRequestToolsItemsOneOf0CacheControlType>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolsItemsOneOf0CacheControlType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MessagesRequestToolsItemsOneOf0CacheControlType existingValue,
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
                        return global::G.MessagesRequestToolsItemsOneOf0CacheControlTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MessagesRequestToolsItemsOneOf0CacheControlType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MessagesRequestToolsItemsOneOf0CacheControlType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MessagesRequestToolsItemsOneOf0CacheControlType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MessagesRequestToolsItemsOneOf0CacheControlTypeExtensions.ToValueString(value));
        }
    }
}
