//HintName: G.JsonConverters.CreateImageToVideoRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateImageToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateImageToVideoRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateImageToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateImageToVideoRequestGen4Turbo? gen4Turbo = default;
            if (discriminator?.Model == global::G.CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestGen4Turbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestGen4Turbo)}");
                gen4Turbo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateImageToVideoRequestVeo31? veo31 = default;
            if (discriminator?.Model == global::G.CreateImageToVideoRequestDiscriminatorModel.Veo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestVeo31)}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateImageToVideoRequestGen3aTurbo? gen3aTurbo = default;
            if (discriminator?.Model == global::G.CreateImageToVideoRequestDiscriminatorModel.Gen3aTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestGen3aTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestGen3aTurbo)}");
                gen3aTurbo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateImageToVideoRequestVeo31Fast? veo31Fast = default;
            if (discriminator?.Model == global::G.CreateImageToVideoRequestDiscriminatorModel.Veo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestVeo31Fast)}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateImageToVideoRequestVeo3? veo3 = default;
            if (discriminator?.Model == global::G.CreateImageToVideoRequestDiscriminatorModel.Veo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateImageToVideoRequestVeo3)}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateImageToVideoRequest(
                discriminator?.Model,
                gen4Turbo,

                veo31,

                gen3aTurbo,

                veo31Fast,

                veo3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateImageToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestGen4Turbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateImageToVideoRequestGen4Turbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Turbo!, typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateImageToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31!, typeInfo);
            }
            else if (value.IsGen3aTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestGen3aTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateImageToVideoRequestGen3aTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen3aTurbo!, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateImageToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast!, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateImageToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateImageToVideoRequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateImageToVideoRequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3!, typeInfo);
            }
        }
    }
}