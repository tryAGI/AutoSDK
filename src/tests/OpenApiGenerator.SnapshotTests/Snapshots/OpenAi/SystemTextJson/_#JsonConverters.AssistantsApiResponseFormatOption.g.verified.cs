//HintName: JsonConverters.AssistantsApiResponseFormatOption.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class AssistantsApiResponseFormatOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantsApiResponseFormatOption>
    {
        /// <inheritdoc />
        public override global::G.AssistantsApiResponseFormatOption Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.AssistantsApiResponseFormatOptionEnum? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantsApiResponseFormatOptionEnum>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFormatText? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatText>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFormatJsonObject? value3 = default;
            try
            {
                value3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonObject>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFormatJsonSchema? value4 = default;
            try
            {
                value4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonSchema>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.AssistantsApiResponseFormatOption(
                value1,

                value2,

                value3,

                value4
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::G.AssistantsApiResponseFormatOptionEnum).Name}, {typeof(global::G.ResponseFormatText).Name}, {typeof(global::G.ResponseFormatJsonObject).Name}, {typeof(global::G.ResponseFormatJsonSchema).Name}>");
            }

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantsApiResponseFormatOptionEnum>(ref reader, options);
            }

            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatText>(ref reader, options);
            }

            else if (value3 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonObject>(ref reader, options);
            }

            else if (value4 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonSchema>(ref reader, options);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantsApiResponseFormatOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::G.AssistantsApiResponseFormatOptionEnum).Name}, {typeof(global::G.ResponseFormatText).Name}, {typeof(global::G.ResponseFormatJsonObject).Name}, {typeof(global::G.ResponseFormatJsonSchema).Name}> object.");
            }

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.AssistantsApiResponseFormatOptionEnum), options);
            }

            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.ResponseFormatText), options);
            }

            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(global::G.ResponseFormatJsonObject), options);
            }

            else if (value.IsValue4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeof(global::G.ResponseFormatJsonSchema), options);
            }
        }
    }
}