//HintName: G.JsonConverters.Request2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Request2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request2>
    {
        /// <inheritdoc />
        public override global::G.Request2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestVeo312? veo31 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo312), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo312> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo312).Name}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestVeo31Fast2? veo31Fast = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast2).Name}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestVeo32? veo3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo32> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo32).Name}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request2(
                veo31,

                veo31Fast,

                veo3
                );

            if (veo31 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo312), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo312> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo312).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (veo31Fast != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (veo3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo32> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo32).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo312), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo312?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo312).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo32?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo32).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3, typeInfo);
            }
        }
    }
}