//HintName: G.JsonConverters.TemplatesCreateTemplateNoProjectRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TemplatesCreateTemplateNoProjectRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplatesCreateTemplateNoProjectRequest>
    {
        /// <inheritdoc />
        public override global::G.TemplatesCreateTemplateNoProjectRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateNoProjectRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateNoProjectRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateNoProjectRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TemplatesCreateTemplateNoProjectRequestVariant1? agent = default;
            if (discriminator?.Type == global::G.TemplatesCreateTemplateNoProjectRequestDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateNoProjectRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateNoProjectRequestVariant1)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TemplatesCreateTemplateNoProjectRequestVariant2? agentFile = default;
            if (discriminator?.Type == global::G.TemplatesCreateTemplateNoProjectRequestDiscriminatorType.AgentFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateNoProjectRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateNoProjectRequestVariant2)}");
                agentFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TemplatesCreateTemplateNoProjectRequest(
                discriminator?.Type,
                agent,

                agentFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplatesCreateTemplateNoProjectRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateNoProjectRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
            else if (value.IsAgentFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateNoProjectRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentFile!, typeInfo);
            }
        }
    }
}