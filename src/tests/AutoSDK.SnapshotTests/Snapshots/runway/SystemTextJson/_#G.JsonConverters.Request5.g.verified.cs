//HintName: G.JsonConverters.Request5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Request5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request5>
    {
        /// <inheritdoc />
        public override global::G.Request5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestActTwo? actTwo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwo).Name}");
                actTwo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request5(
                actTwo
                );

            if (actTwo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ActTwo, typeInfo);
            }
        }
    }
}