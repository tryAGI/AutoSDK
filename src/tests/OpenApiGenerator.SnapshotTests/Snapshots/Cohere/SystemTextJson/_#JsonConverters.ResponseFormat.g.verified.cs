//HintName: JsonConverters.ResponseFormat.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.TextResponseFormat? text = default;
            try
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextResponseFormat>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.JSONResponseFormat? jSON = default;
            try
            {
                jSON = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JSONResponseFormat>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ResponseFormat(
                text,
                jSON
                );

            if (text != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextResponseFormat>(ref reader, options);
            }
            else if (jSON != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.JSONResponseFormat>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextResponseFormat), options);
            }
            else if (value.IsJSON)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSON, typeof(global::G.JSONResponseFormat), options);
            }
        }
    }
}