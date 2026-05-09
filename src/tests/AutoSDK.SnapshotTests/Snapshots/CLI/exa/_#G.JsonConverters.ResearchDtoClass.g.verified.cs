//HintName: G.JsonConverters.ResearchDtoClass.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResearchDtoClassJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchDtoClass>
    {
        /// <inheritdoc />
        public override global::G.ResearchDtoClass Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchDtoClassVariant1? pending = default;
            if (discriminator?.Status == global::G.ResearchDtoClassDiscriminatorStatus.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassVariant1)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchDtoClassVariant2? running = default;
            if (discriminator?.Status == global::G.ResearchDtoClassDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassVariant2)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchDtoClassVariant3? completed = default;
            if (discriminator?.Status == global::G.ResearchDtoClassDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassVariant3)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchDtoClassVariant4? canceled = default;
            if (discriminator?.Status == global::G.ResearchDtoClassDiscriminatorStatus.Canceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassVariant4)}");
                canceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchDtoClassVariant5? failed = default;
            if (discriminator?.Status == global::G.ResearchDtoClassDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchDtoClassVariant5)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResearchDtoClass(
                discriminator?.Status,
                pending,

                running,

                completed,

                canceled,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchDtoClass value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchDtoClassVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending!, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchDtoClassVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running!, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchDtoClassVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchDtoClassVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchDtoClassVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchDtoClassVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchDtoClassVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}