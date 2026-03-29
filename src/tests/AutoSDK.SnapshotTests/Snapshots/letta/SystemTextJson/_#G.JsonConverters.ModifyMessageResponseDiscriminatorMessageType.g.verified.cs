//HintName: G.JsonConverters.ModifyMessageResponseDiscriminatorMessageType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModifyMessageResponseDiscriminatorMessageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModifyMessageResponseDiscriminatorMessageType>
    {
        /// <inheritdoc />
        public override global::G.ModifyMessageResponseDiscriminatorMessageType Read(
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
                        return global::G.ModifyMessageResponseDiscriminatorMessageTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ModifyMessageResponseDiscriminatorMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ModifyMessageResponseDiscriminatorMessageType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModifyMessageResponseDiscriminatorMessageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ModifyMessageResponseDiscriminatorMessageTypeExtensions.ToValueString(value));
        }
    }
}
