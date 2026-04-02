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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TenantShareTokensResponseEntitieDiscriminator>(ref readerCopy, options);

            global::G.TenantShareRunToken? run = default;
            if (discriminator?.Type == global::G.TenantShareTokensResponseEntitieDiscriminatorType.Run)
            {
                run = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TenantShareRunToken>(ref reader, options);
            }
            global::G.TenantShareDatasetToken? dataset = default;
            if (discriminator?.Type == global::G.TenantShareTokensResponseEntitieDiscriminatorType.Dataset)
            {
                dataset = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TenantShareDatasetToken>(ref reader, options);
            }

            var __value = new global::G.EntitiesItem(
                discriminator?.Type,
                run,

                dataset
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EntitiesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRun)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeof(global::G.TenantShareRunToken), options);
            }
            else if (value.IsDataset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dataset, typeof(global::G.TenantShareDatasetToken), options);
            }
        }
    }
}