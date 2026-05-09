//HintName: G.JsonConverters.TemplatesCreateTemplateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TemplatesCreateTemplateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplatesCreateTemplateRequest>
    {
        /// <inheritdoc />
        public override global::G.TemplatesCreateTemplateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TemplatesCreateTemplateRequestVariant1? agent = default;
            if (discriminator?.Type == "agent")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateRequestVariant1)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TemplatesCreateTemplateRequestVariant2? agentFile = default;
            if (discriminator?.Type == "agent_file")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatesCreateTemplateRequestVariant2)}");
                agentFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TemplatesCreateTemplateRequest(
                discriminator?.Type,
                agent,

                agentFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplatesCreateTemplateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TemplatesCreateTemplateRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
            else if (value.IsAgentFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatesCreateTemplateRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatesCreateTemplateRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TemplatesCreateTemplateRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentFile!, typeInfo);
            }
        }
    }
}