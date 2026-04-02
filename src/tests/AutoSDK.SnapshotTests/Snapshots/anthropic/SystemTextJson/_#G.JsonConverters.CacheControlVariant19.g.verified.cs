//HintName: G.JsonConverters.CacheControlVariant19.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant19JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CacheControlVariant19>
    {
        /// <inheritdoc />
        public override global::G.CacheControlVariant19 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestToolResultBlockCacheControlVariant1Discriminator>(ref readerCopy, options);

            global::G.BetaCacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::G.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaCacheControlEphemeral>(ref reader, options);
            }

            var __value = new global::G.CacheControlVariant19(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CacheControlVariant19 value,
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