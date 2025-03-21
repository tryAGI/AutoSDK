//HintName: JsonConverters.Response.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Response>
    {
        /// <inheritdoc />
        public override global::G.Response Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ModelResponseProperties? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseProperties? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Response(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}