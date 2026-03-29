//HintName: G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf1CacheControlTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestToolsItemsOneOf1CacheControlType>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolsItemsOneOf1CacheControlType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.MessagesRequestToolsItemsOneOf1CacheControlTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MessagesRequestToolsItemsOneOf1CacheControlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MessagesRequestToolsItemsOneOf1CacheControlType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestToolsItemsOneOf1CacheControlType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.MessagesRequestToolsItemsOneOf1CacheControlTypeExtensions.ToValueString(value));
        }
    }
}
