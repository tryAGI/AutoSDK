//HintName: G.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestSystemOneOf1ItemsCacheControlTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesRequestSystemOneOf1ItemsCacheControlType?>
    {
        /// <inheritdoc />
        public override global::G.MessagesRequestSystemOneOf1ItemsCacheControlType? Read(
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
                        return global::G.MessagesRequestSystemOneOf1ItemsCacheControlTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MessagesRequestSystemOneOf1ItemsCacheControlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MessagesRequestSystemOneOf1ItemsCacheControlType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesRequestSystemOneOf1ItemsCacheControlType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MessagesRequestSystemOneOf1ItemsCacheControlTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
