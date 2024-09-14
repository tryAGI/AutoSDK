//HintName: JsonConverters.ResponseFormat2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormat2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormat2>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormat2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.TextResponseFormat? textFormat = default;
            try
            {
                textFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextResponseFormat>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.JSONResponseFormat2? jSON = default;
            try
            {
                jSON = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JSONResponseFormat2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ResponseFormat2(
                textFormat,
                jSON
                );

            if (textFormat != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextResponseFormat>(ref reader, options);
            }
            else if (jSON != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JSONResponseFormat2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormat2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextFormat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextFormat, typeof(global::G.TextResponseFormat), options);
            }
            else if (value.IsJSON)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSON, typeof(global::G.JSONResponseFormat2), options);
            }
        }
    }
}