//HintName: G.JsonConverters.GetTasksResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetTasksResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetTasksResponse>
    {
        /// <inheritdoc />
        public override global::G.GetTasksResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetTasksResponseVariant1? pending = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant1)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetTasksResponseVariant2? throttled = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Throttled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant2)}");
                throttled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetTasksResponseVariant3? cancelled = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Cancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant3)}");
                cancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetTasksResponseVariant4? running = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant4)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetTasksResponseVariant5? failed = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant5)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetTasksResponseVariant6? succeeded = default;
            if (discriminator?.Status == global::G.GetTasksResponseDiscriminatorStatus.Succeeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetTasksResponseVariant6)}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GetTasksResponse(
                discriminator?.Status,
                pending,

                throttled,

                cancelled,

                running,

                failed,

                succeeded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetTasksResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending!, typeInfo);
            }
            else if (value.IsThrottled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttled!, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled!, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
            else if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded!, typeInfo);
            }
        }
    }
}