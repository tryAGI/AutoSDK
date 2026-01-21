//HintName: G.JsonConverters.IntegrationsVariant1Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IntegrationsVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.IntegrationsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierJobOutIntegrationsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierJobOutIntegrationsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClassifierJobOutIntegrationsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WandbIntegrationOut? wandb = default;
            if (discriminator?.Type == global::G.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WandbIntegrationOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WandbIntegrationOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WandbIntegrationOut)}");
                wandb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.IntegrationsVariant1Item(
                discriminator?.Type,
                wandb
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IntegrationsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WandbIntegrationOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WandbIntegrationOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WandbIntegrationOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wandb, typeInfo);
            }
        }
    }
}