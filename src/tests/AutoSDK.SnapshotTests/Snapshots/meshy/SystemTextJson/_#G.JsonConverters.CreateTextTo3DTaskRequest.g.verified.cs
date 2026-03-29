//HintName: G.JsonConverters.CreateTextTo3DTaskRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextTo3DTaskRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextTo3DTaskRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextTo3DTaskRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextTo3DTaskRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextTo3DTaskRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextTo3DTaskRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextTo3DPreviewRequest? preview = default;
            if (discriminator?.Mode == global::G.CreateTextTo3DTaskRequestDiscriminatorMode.Preview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextTo3DPreviewRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextTo3DPreviewRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextTo3DPreviewRequest)}");
                preview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextTo3DRefineRequest? refine = default;
            if (discriminator?.Mode == global::G.CreateTextTo3DTaskRequestDiscriminatorMode.Refine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextTo3DRefineRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextTo3DRefineRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextTo3DRefineRequest)}");
                refine = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateTextTo3DTaskRequest(
                discriminator?.Mode,
                preview,

                refine
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextTo3DTaskRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPreview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextTo3DPreviewRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextTo3DPreviewRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextTo3DPreviewRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preview, typeInfo);
            }
            else if (value.IsRefine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextTo3DRefineRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextTo3DRefineRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextTo3DRefineRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refine, typeInfo);
            }
        }
    }
}