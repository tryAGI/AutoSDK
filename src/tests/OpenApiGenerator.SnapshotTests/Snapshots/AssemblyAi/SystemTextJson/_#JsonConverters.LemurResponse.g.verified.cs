//HintName: JsonConverters.LemurResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class LemurResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LemurResponse>
    {
        /// <inheritdoc />
        public override global::G.LemurResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.LemurStringResponse? @string = default;
            try
            {
                @string = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LemurStringResponse>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LemurQuestionAnswerResponse? questionAnswer = default;
            try
            {
                questionAnswer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LemurQuestionAnswerResponse>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.LemurResponse(
                @string,
                questionAnswer
                );

            if (@string != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LemurStringResponse>(ref reader, options);
            }
            else if (questionAnswer != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LemurQuestionAnswerResponse>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LemurResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsString)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeof(global::G.LemurStringResponse), options);
            }
            else if (value.IsQuestionAnswer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QuestionAnswer, typeof(global::G.LemurQuestionAnswerResponse), options);
            }
        }
    }
}