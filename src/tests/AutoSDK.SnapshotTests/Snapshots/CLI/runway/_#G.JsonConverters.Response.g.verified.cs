//HintName: G.JsonConverters.Response.g.cs
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
            global::G.ResponseVariant1? pending = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant1).Name}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant2? throttled = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant2).Name}");
                throttled = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant3? cancelled = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                cancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant4? running = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant4).Name}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant5? failed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant5).Name}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseVariant6? succeeded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant6).Name}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Response(
                pending,

                throttled,

                cancelled,

                running,

                failed,

                succeeded
                );

            if (pending != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (throttled != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (cancelled != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (running != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (failed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (succeeded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending, typeInfo);
            }
            else if (value.IsThrottled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttled, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
            else if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeInfo);
            }
        }
    }
}