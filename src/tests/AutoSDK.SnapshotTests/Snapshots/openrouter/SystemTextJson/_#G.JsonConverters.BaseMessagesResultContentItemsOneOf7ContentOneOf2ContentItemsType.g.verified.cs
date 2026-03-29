//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType Read(
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
                        return global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeExtensions.ToValueString(value));
        }
    }
}
