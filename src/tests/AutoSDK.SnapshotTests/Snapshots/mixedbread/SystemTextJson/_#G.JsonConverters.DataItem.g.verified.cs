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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StoreEventListResponseDataItemDiscriminator>(ref readerCopy, options);

            global::G.StoreIngestionEvent? ingestion = default;
            if (discriminator?.Type == global::G.StoreEventListResponseDataItemDiscriminatorType.Ingestion)
            {
                ingestion = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StoreIngestionEvent>(ref reader, options);
            }
            global::G.StoreSearchEvent? search = default;
            if (discriminator?.Type == global::G.StoreEventListResponseDataItemDiscriminatorType.Search)
            {
                search = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StoreSearchEvent>(ref reader, options);
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

            if (value.IsIngestion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ingestion, typeof(global::G.StoreIngestionEvent), options);
            }
            else if (value.IsSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeof(global::G.StoreSearchEvent), options);
            }
        }
    }
}