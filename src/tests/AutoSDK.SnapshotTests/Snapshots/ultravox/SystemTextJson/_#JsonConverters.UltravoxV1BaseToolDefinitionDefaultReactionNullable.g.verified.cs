//HintName: JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1BaseToolDefinitionDefaultReactionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UltravoxV1BaseToolDefinitionDefaultReaction?>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1BaseToolDefinitionDefaultReaction? Read(
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
                        return global::G.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UltravoxV1BaseToolDefinitionDefaultReaction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UltravoxV1BaseToolDefinitionDefaultReaction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToValueString(value.Value));
            }
        }
    }
}
