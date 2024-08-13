//HintName: JsonConverters.ChatCompletionToolChoiceOption.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionToolChoiceOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionToolChoiceOption>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionToolChoiceOption Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatCompletionToolChoiceOptionEnum? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionToolChoiceOptionEnum>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionNamedToolChoice? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionNamedToolChoice>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.ChatCompletionToolChoiceOption(
                value1,

                value2
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.ChatCompletionToolChoiceOptionEnum).Name}, {typeof(global::G.ChatCompletionNamedToolChoice).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionToolChoiceOptionEnum>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionNamedToolChoice>(ref reader, options);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionToolChoiceOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.ChatCompletionToolChoiceOptionEnum).Name}, {typeof(global::G.ChatCompletionNamedToolChoice).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.ChatCompletionToolChoiceOptionEnum), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.ChatCompletionNamedToolChoice), options);
            }
        }
    }
}