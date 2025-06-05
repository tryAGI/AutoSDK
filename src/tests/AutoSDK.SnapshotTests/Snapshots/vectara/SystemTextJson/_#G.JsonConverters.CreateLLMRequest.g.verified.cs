//HintName: G.JsonConverters.CreateLLMRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateLLMRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateLLMRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateLLMRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLLMRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLLMRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateLLMRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateOpenAILLMRequest? openaiCompatible = default;
            if (discriminator?.Type == global::G.CreateLLMRequestDiscriminatorType.OpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenAILLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateOpenAILLMRequest)}");
                openaiCompatible = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CreateLLMRequest(
                discriminator?.Type,
                openaiCompatible
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateLLMRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenAILLMRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateOpenAILLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiCompatible, typeInfo);
            }
        }
    }
}