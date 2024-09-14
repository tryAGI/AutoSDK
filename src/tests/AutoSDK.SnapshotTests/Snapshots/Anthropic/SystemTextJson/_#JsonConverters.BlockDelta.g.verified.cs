//HintName: JsonConverters.BlockDelta.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BlockDeltaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BlockDelta>
    {
        /// <inheritdoc />
        public override global::G.BlockDelta Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.TextBlockDelta? text = default;
            try
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextBlockDelta>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.InputJsonBlockDelta? inputJson = default;
            try
            {
                inputJson = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputJsonBlockDelta>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.BlockDelta(
                text,
                inputJson
                );

            if (text != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextBlockDelta>(ref reader, options);
            }
            else if (inputJson != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputJsonBlockDelta>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BlockDelta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextBlockDelta), options);
            }
            else if (value.IsInputJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJson, typeof(global::G.InputJsonBlockDelta), options);
            }
        }
    }
}