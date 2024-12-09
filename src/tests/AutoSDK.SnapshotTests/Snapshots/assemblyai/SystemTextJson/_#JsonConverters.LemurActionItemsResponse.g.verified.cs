//HintName: JsonConverters.LemurActionItemsResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LemurActionItemsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LemurActionItemsResponse>
    {
        /// <inheritdoc />
        public override global::G.LemurActionItemsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.LemurStringResponse? @string = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.LemurActionItemsResponse(
                @string
                );

            if (@string != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LemurActionItemsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
        }
    }
}