//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType Read(
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
                        return global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeExtensions.ToValueString(value));
        }
    }
}
