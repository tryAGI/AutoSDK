//HintName: G.JsonConverters.FromImageRegistry.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FromImageRegistryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FromImageRegistry>
    {
        /// <inheritdoc />
        public override global::G.FromImageRegistry Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FromImageRegistryDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FromImageRegistryDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FromImageRegistryDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AWSRegistry? aws = default;
            if (discriminator?.Type == global::G.FromImageRegistryDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AWSRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AWSRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AWSRegistry)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GCPRegistry? gcp = default;
            if (discriminator?.Type == global::G.FromImageRegistryDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GCPRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GCPRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GCPRegistry)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GeneralRegistry? registry = default;
            if (discriminator?.Type == global::G.FromImageRegistryDiscriminatorType.Registry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneralRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneralRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeneralRegistry)}");
                registry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.FromImageRegistry(
                discriminator?.Type,
                aws,

                gcp,

                registry
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FromImageRegistry value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AWSRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AWSRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AWSRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GCPRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GCPRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GCPRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
            else if (value.IsRegistry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneralRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneralRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeneralRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Registry!, typeInfo);
            }
        }
    }
}