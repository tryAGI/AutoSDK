//HintName: G.JsonConverters.CacheControlVariant16.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant16JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CacheControlVariant16>
    {
        /// <inheritdoc />
        public override global::G.CacheControlVariant16 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestDocumentBlockCacheControlVariant1Discriminator>(ref readerCopy, options);

            global::G.BetaCacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::G.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaCacheControlEphemeral>(ref reader, options);
            }

            var __value = new global::G.CacheControlVariant16(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CacheControlVariant16 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEphemeral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral, typeof(global::G.BetaCacheControlEphemeral), options);
            }
        }
    }
}