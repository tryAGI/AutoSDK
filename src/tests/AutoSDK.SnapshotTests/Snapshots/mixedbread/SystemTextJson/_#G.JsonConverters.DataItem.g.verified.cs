//HintName: G.JsonConverters.DataItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem>
    {
        /// <inheritdoc />
        public override global::G.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreEventListResponseDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreEventListResponseDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StoreEventListResponseDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.StoreIngestionEvent? ingestion = default;
            if (discriminator?.Type == global::G.StoreEventListResponseDataItemDiscriminatorType.Ingestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreIngestionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreIngestionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StoreIngestionEvent)}");
                ingestion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StoreSearchEvent? search = default;
            if (discriminator?.Type == global::G.StoreEventListResponseDataItemDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreSearchEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StoreSearchEvent)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.DataItem(
                discriminator?.Type,
                ingestion,

                search
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIngestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreIngestionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreIngestionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StoreIngestionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ingestion, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StoreSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StoreSearchEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StoreSearchEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeInfo);
            }
        }
    }
}