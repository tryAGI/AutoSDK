//HintName: G.JsonConverters.ChatEvalAssistantMessageEvaluationRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatEvalAssistantMessageEvaluationRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatEvalAssistantMessageEvaluationRole?>
    {
        /// <inheritdoc />
        public override global::G.ChatEvalAssistantMessageEvaluationRole? Read(
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
                        return global::G.ChatEvalAssistantMessageEvaluationRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatEvalAssistantMessageEvaluationRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatEvalAssistantMessageEvaluationRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatEvalAssistantMessageEvaluationRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChatEvalAssistantMessageEvaluationRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
