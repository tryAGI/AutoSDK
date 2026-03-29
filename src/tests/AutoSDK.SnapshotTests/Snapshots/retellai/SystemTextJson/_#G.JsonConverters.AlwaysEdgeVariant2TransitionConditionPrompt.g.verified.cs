//HintName: G.JsonConverters.AlwaysEdgeVariant2TransitionConditionPrompt.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlwaysEdgeVariant2TransitionConditionPromptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AlwaysEdgeVariant2TransitionConditionPrompt>
    {
        /// <inheritdoc />
        public override global::G.AlwaysEdgeVariant2TransitionConditionPrompt Read(
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
                        return global::G.AlwaysEdgeVariant2TransitionConditionPromptExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AlwaysEdgeVariant2TransitionConditionPrompt)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AlwaysEdgeVariant2TransitionConditionPrompt);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AlwaysEdgeVariant2TransitionConditionPrompt value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AlwaysEdgeVariant2TransitionConditionPromptExtensions.ToValueString(value));
        }
    }
}
