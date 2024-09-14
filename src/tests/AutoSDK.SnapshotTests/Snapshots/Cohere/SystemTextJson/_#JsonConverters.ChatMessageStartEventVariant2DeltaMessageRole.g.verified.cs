//HintName: JsonConverters.ChatMessageStartEventVariant2DeltaMessageRole.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatMessageStartEventVariant2DeltaMessageRole>
    {
        /// <inheritdoc />
        public override global::G.ChatMessageStartEventVariant2DeltaMessageRole Read(
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
                        return global::G.ChatMessageStartEventVariant2DeltaMessageRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatMessageStartEventVariant2DeltaMessageRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatMessageStartEventVariant2DeltaMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ChatMessageStartEventVariant2DeltaMessageRoleExtensions.ToValueString(value));
        }
    }
}
