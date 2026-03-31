//HintName: G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh Read(
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
                        return global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHighExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHighExtensions.ToValueString(value));
        }
    }
}
