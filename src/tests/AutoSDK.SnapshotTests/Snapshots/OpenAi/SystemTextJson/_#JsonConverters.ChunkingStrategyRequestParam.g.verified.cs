//HintName: JsonConverters.ChunkingStrategyRequestParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class ChunkingStrategyRequestParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChunkingStrategyRequestParam>
    {
        /// <inheritdoc />
        public override global::G.ChunkingStrategyRequestParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.AutoChunkingStrategyRequestParam? auto = default;
            try
            {
                auto = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AutoChunkingStrategyRequestParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StaticChunkingStrategyRequestParam? @static = default;
            try
            {
                @static = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StaticChunkingStrategyRequestParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChunkingStrategyRequestParam(
                auto,
                @static
                );

            if (auto != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AutoChunkingStrategyRequestParam>(ref reader, options);
            }
            else if (@static != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StaticChunkingStrategyRequestParam>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChunkingStrategyRequestParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeof(global::G.AutoChunkingStrategyRequestParam), options);
            }
            else if (value.IsStatic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeof(global::G.StaticChunkingStrategyRequestParam), options);
            }
        }
    }
}