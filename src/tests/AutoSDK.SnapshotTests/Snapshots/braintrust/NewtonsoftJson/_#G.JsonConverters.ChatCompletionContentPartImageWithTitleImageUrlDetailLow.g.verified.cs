//HintName: G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLow.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLowExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLowExtensions.ToValueString(value));
        }
    }
}
