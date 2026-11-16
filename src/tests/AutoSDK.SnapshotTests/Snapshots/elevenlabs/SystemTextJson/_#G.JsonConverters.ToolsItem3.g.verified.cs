//HintName: G.JsonConverters.ToolsItem3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem3>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConvAIStoredSecretDependenciesToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConvAIStoredSecretDependenciesToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConvAIStoredSecretDependenciesToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DependentAvailableToolIdentifier? available = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentAvailableToolIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DependentUnknownToolIdentifier? unknown = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DependentUnknownToolIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolsItem3(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentAvailableToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentAvailableToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentAvailableToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAvailable(), typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DependentUnknownToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DependentUnknownToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DependentUnknownToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnknown(), typeInfo);
            }
        }
    }
}