//HintName: G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto Read(
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
                        return global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoExtensions.ToValueString(value));
        }
    }
}
