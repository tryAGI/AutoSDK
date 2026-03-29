//HintName: G.JsonConverters.ReturnPagedChatGroupsPaginationDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReturnPagedChatGroupsPaginationDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReturnPagedChatGroupsPaginationDirection>
    {
        /// <inheritdoc />
        public override global::G.ReturnPagedChatGroupsPaginationDirection Read(
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
                        return global::G.ReturnPagedChatGroupsPaginationDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReturnPagedChatGroupsPaginationDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReturnPagedChatGroupsPaginationDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReturnPagedChatGroupsPaginationDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReturnPagedChatGroupsPaginationDirectionExtensions.ToValueString(value));
        }
    }
}
