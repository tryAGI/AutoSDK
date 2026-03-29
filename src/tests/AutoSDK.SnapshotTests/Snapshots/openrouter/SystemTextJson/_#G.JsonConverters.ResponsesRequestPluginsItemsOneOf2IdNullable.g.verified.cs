//HintName: G.JsonConverters.ResponsesRequestPluginsItemsOneOf2IdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponsesRequestPluginsItemsOneOf2IdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponsesRequestPluginsItemsOneOf2Id?>
    {
        /// <inheritdoc />
        public override global::G.ResponsesRequestPluginsItemsOneOf2Id? Read(
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
                        return global::G.ResponsesRequestPluginsItemsOneOf2IdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ResponsesRequestPluginsItemsOneOf2Id)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ResponsesRequestPluginsItemsOneOf2Id?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponsesRequestPluginsItemsOneOf2Id? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ResponsesRequestPluginsItemsOneOf2IdExtensions.ToValueString(value.Value));
            }
        }
    }
}
