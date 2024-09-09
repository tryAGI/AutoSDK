//HintName: JsonConverters.GenerateStreamedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateStreamedResponse>
    {
        /// <inheritdoc />
        public override global::G.GenerateStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.GenerateStreamText? streamText = default;
            try
            {
                streamText = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamText>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.GenerateStreamEnd? streamEnd = default;
            try
            {
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEnd>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.GenerateStreamError? streamError = default;
            try
            {
                streamError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamError>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.GenerateStreamedResponse(
                streamText,
                streamEnd,
                streamError
                );

            if (streamText != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamText>(ref reader, options);
            }
            else if (streamEnd != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEnd>(ref reader, options);
            }
            else if (streamError != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamError>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStreamText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamText, typeof(global::G.GenerateStreamText), options);
            }
            else if (value.IsStreamEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeof(global::G.GenerateStreamEnd), options);
            }
            else if (value.IsStreamError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamError, typeof(global::G.GenerateStreamError), options);
            }
        }
    }
}