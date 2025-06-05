//HintName: G.JsonConverters.EntitiesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EntitiesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EntitiesItem>
    {
        /// <inheritdoc />
        public override global::G.EntitiesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TenantShareTokensResponseEntitieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TenantShareTokensResponseEntitieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TenantShareTokensResponseEntitieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TenantShareRunToken? run = default;
            if (discriminator?.Type == global::G.TenantShareTokensResponseEntitieDiscriminatorType.Run)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TenantShareRunToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TenantShareRunToken> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TenantShareRunToken)}");
                run = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TenantShareDatasetToken? dataset = default;
            if (discriminator?.Type == global::G.TenantShareTokensResponseEntitieDiscriminatorType.Dataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TenantShareDatasetToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TenantShareDatasetToken> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TenantShareDatasetToken)}");
                dataset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.EntitiesItem(
                discriminator?.Type,
                run,
                dataset
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EntitiesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRun)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TenantShareRunToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TenantShareRunToken?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TenantShareRunToken).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeInfo);
            }
            else if (value.IsDataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TenantShareDatasetToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TenantShareDatasetToken?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TenantShareDatasetToken).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dataset, typeInfo);
            }
        }
    }
}