//HintName: G.JsonConverters.Tool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Tool>
    {
        /// <inheritdoc />
        public override global::G.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolDiscriminator>(ref readerCopy, options);

            global::G.FunctionTool? function = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionTool>(ref reader, options);
            }
            global::G.BuiltInTool? webSearch = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.WebSearch)
            {
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BuiltInTool>(ref reader, options);
            }

            var __value = new global::G.Tool(
                discriminator?.Type,
                function,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.FunctionTool), options);
            }
            else if (value.IsWebSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeof(global::G.BuiltInTool), options);
            }
        }
    }
}