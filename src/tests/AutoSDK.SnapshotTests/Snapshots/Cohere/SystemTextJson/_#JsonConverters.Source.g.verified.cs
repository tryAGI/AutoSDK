//HintName: JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ToolSource? tool = default;
            try
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolSource>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DocumentSource? document = default;
            try
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DocumentSource>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Source(
                tool,
                document
                );

            if (tool != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolSource>(ref reader, options);
            }
            else if (document != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DocumentSource>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolSource), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::G.DocumentSource), options);
            }
        }
    }
}