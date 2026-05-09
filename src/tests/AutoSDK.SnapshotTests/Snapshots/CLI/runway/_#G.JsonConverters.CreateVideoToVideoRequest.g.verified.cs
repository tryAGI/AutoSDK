//HintName: G.JsonConverters.CreateVideoToVideoRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateVideoToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVideoToVideoRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateVideoToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVideoToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateVideoToVideoRequestGen4Aleph? gen4Aleph = default;
            if (discriminator?.Model == global::G.CreateVideoToVideoRequestDiscriminatorModel.Gen4Aleph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestGen4Aleph), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestGen4Aleph> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVideoToVideoRequestGen4Aleph)}");
                gen4Aleph = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateVideoToVideoRequest(
                discriminator?.Model,
                gen4Aleph
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVideoToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4Aleph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestGen4Aleph), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestGen4Aleph?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVideoToVideoRequestGen4Aleph).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Aleph!, typeInfo);
            }
        }
    }
}