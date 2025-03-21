//HintName: JsonConverters.CreateChatCompletionRequestVariant2ServiceTier.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionRequestVariant2ServiceTierJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateChatCompletionRequestVariant2ServiceTier>
    {
        /// <inheritdoc />
        public override global::G.CreateChatCompletionRequestVariant2ServiceTier Read(
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
                        return global::G.CreateChatCompletionRequestVariant2ServiceTierExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateChatCompletionRequestVariant2ServiceTier)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateChatCompletionRequestVariant2ServiceTier value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateChatCompletionRequestVariant2ServiceTierExtensions.ToValueString(value));
        }
    }
}
