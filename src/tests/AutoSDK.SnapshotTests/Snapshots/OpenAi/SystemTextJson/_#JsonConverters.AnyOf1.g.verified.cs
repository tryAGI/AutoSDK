//HintName: JsonConverters.AnyOf1.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnyOfJsonConverter<T1> : global::System.Text.Json.Serialization.JsonConverter<global::G.AnyOf<T1>>
    {
        /// <inheritdoc />
        public override global::G.AnyOf<T1> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.AnyOf<T1>(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnyOf<T1> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}