//HintName: JsonConverters.ChatCompletionMessageParamDiscriminatorRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionMessageParamDiscriminatorRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionMessageParamDiscriminatorRole?>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageParamDiscriminatorRole? Read(
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
                        return global::G.ChatCompletionMessageParamDiscriminatorRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatCompletionMessageParamDiscriminatorRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionMessageParamDiscriminatorRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChatCompletionMessageParamDiscriminatorRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
