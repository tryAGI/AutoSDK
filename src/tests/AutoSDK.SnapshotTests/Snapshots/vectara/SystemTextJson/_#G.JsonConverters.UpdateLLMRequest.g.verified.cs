//HintName: G.JsonConverters.UpdateLLMRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UpdateLLMRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateLLMRequest>
    {
        /// <inheritdoc />
        public override global::G.UpdateLLMRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateLLMRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateLLMRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateLLMRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UpdateOpenAILLMRequest? openaiCompatible = default;
            if (discriminator?.Type == global::G.UpdateLLMRequestDiscriminatorType.OpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateOpenAILLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateOpenAILLMRequest)}");
                openaiCompatible = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateOpenAIResponsesLLMRequest? openaiResponses = default;
            if (discriminator?.Type == global::G.UpdateLLMRequestDiscriminatorType.OpenaiResponses)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateOpenAIResponsesLLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateOpenAIResponsesLLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateOpenAIResponsesLLMRequest)}");
                openaiResponses = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateVertexAILLMRequest? vertexAi = default;
            if (discriminator?.Type == global::G.UpdateLLMRequestDiscriminatorType.VertexAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVertexAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVertexAILLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateVertexAILLMRequest)}");
                vertexAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateAnthropicLLMRequest? anthropic = default;
            if (discriminator?.Type == global::G.UpdateLLMRequestDiscriminatorType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAnthropicLLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAnthropicLLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateAnthropicLLMRequest)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.UpdateLLMRequest(
                discriminator?.Type,
                openaiCompatible,

                openaiResponses,

                vertexAi,

                anthropic
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateLLMRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateOpenAILLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateOpenAILLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiCompatible, typeInfo);
            }
            else if (value.IsOpenaiResponses)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateOpenAIResponsesLLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateOpenAIResponsesLLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateOpenAIResponsesLLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiResponses, typeInfo);
            }
            else if (value.IsVertexAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVertexAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVertexAILLMRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateVertexAILLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexAi, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAnthropicLLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAnthropicLLMRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateAnthropicLLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeInfo);
            }
        }
    }
}