//HintName: G.JsonConverters.CreateTextToVideoRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToVideoRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateTextToVideoRequestVeo31? veo31 = default;
            if (discriminator?.Model == global::G.CreateTextToVideoRequestDiscriminatorModel.Veo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToVideoRequestVeo31)}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextToVideoRequestVeo31Fast? veo31Fast = default;
            if (discriminator?.Model == global::G.CreateTextToVideoRequestDiscriminatorModel.Veo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToVideoRequestVeo31Fast)}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextToVideoRequestVeo3? veo3 = default;
            if (discriminator?.Model == global::G.CreateTextToVideoRequestDiscriminatorModel.Veo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToVideoRequestVeo3)}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateTextToVideoRequest(
                discriminator?.Model,
                veo31,

                veo31Fast,

                veo3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31!, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast!, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3!, typeInfo);
            }
        }
    }
}