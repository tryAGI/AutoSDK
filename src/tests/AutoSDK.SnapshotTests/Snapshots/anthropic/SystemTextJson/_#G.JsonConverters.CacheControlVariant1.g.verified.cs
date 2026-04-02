//HintName: G.JsonConverters.CacheControlVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CacheControlVariant1>
    {
        /// <inheritdoc />
        public override global::G.CacheControlVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BashTool20250124CacheControlVariant1Discriminator>(ref readerCopy, options);

            global::G.CacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::G.BashTool20250124CacheControlVariant1DiscriminatorType.Ephemeral)
            {
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CacheControlEphemeral>(ref reader, options);
            }

            var __value = new global::G.CacheControlVariant1(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CacheControlVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEphemeral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral, typeof(global::G.CacheControlEphemeral), options);
            }
        }
    }
}