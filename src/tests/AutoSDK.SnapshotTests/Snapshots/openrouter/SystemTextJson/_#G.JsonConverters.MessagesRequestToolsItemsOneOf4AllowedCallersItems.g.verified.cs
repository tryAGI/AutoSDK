//HintName: G.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItems.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf4AllowedCallersItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems Read(
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
                        return global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItemsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItemsExtensions.ToValueString(value));
        }
    }
}
