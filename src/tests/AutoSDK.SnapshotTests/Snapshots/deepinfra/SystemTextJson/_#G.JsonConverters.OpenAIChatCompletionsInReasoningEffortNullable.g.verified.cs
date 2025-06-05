//HintName: G.JsonConverters.OpenAIChatCompletionsInReasoningEffortNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIChatCompletionsInReasoningEffortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OpenAIChatCompletionsInReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::G.OpenAIChatCompletionsInReasoningEffort? Read(
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
                        return global::G.OpenAIChatCompletionsInReasoningEffortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OpenAIChatCompletionsInReasoningEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.OpenAIChatCompletionsInReasoningEffort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OpenAIChatCompletionsInReasoningEffort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.OpenAIChatCompletionsInReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
