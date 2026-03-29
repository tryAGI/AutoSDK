//HintName: G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType>
    {
        /// <inheritdoc />
        public override global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType Read(
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
                        return global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeExtensions.ToValueString(value));
        }
    }
}
