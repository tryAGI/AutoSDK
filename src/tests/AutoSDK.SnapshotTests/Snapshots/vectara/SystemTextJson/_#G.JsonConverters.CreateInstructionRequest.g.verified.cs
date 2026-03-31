//HintName: G.JsonConverters.CreateInstructionRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateInstructionRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateInstructionRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateInstructionRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInstructionRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInstructionRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInstructionRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateInitialInstructionRequest? initial = default;
            if (discriminator?.Type == global::G.CreateInstructionRequestDiscriminatorType.Initial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInitialInstructionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInitialInstructionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInitialInstructionRequest)}");
                initial = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateInstructionRequest(
                discriminator?.Type,
                initial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateInstructionRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInitial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInitialInstructionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInitialInstructionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateInitialInstructionRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Initial!.Value, typeInfo);
            }
        }
    }
}