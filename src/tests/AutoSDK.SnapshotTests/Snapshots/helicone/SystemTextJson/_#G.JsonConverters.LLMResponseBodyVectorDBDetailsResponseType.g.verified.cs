//HintName: G.JsonConverters.LLMResponseBodyVectorDBDetailsResponseType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LLMResponseBodyVectorDBDetailsResponseType>
    {
        /// <inheritdoc />
        public override global::G.LLMResponseBodyVectorDBDetailsResponseType Read(
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
                        return global::G.LLMResponseBodyVectorDBDetailsResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.LLMResponseBodyVectorDBDetailsResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.LLMResponseBodyVectorDBDetailsResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LLMResponseBodyVectorDBDetailsResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.LLMResponseBodyVectorDBDetailsResponseTypeExtensions.ToValueString(value));
        }
    }
}
