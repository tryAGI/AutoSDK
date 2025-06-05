//HintName: G.JsonConverters.IntegrationsItem5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsItem5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IntegrationsItem5>
    {
        /// <inheritdoc />
        public override global::G.IntegrationsItem5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobInIntegrationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobInIntegrationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobInIntegrationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WandbIntegration? wandb = default;
            if (discriminator?.Type == global::G.JobInIntegrationDiscriminatorType.Wandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WandbIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WandbIntegration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WandbIntegration)}");
                wandb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.IntegrationsItem5(
                discriminator?.Type,
                wandb
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IntegrationsItem5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WandbIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WandbIntegration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WandbIntegration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wandb, typeInfo);
            }
        }
    }
}