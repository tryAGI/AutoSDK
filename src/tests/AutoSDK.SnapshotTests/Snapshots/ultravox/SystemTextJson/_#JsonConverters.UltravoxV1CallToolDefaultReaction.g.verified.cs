//HintName: JsonConverters.UltravoxV1CallToolDefaultReaction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1CallToolDefaultReactionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UltravoxV1CallToolDefaultReaction>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1CallToolDefaultReaction Read(
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
                        return global::G.UltravoxV1CallToolDefaultReactionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UltravoxV1CallToolDefaultReaction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UltravoxV1CallToolDefaultReaction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UltravoxV1CallToolDefaultReaction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.UltravoxV1CallToolDefaultReactionExtensions.ToValueString(value));
        }
    }
}
