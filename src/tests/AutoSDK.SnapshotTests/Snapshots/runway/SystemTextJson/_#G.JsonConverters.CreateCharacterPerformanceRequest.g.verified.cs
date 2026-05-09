//HintName: G.JsonConverters.CreateCharacterPerformanceRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateCharacterPerformanceRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateCharacterPerformanceRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCharacterPerformanceRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateCharacterPerformanceRequestActTwo? actTwo = default;
            if (discriminator?.Model == global::G.CreateCharacterPerformanceRequestDiscriminatorModel.ActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCharacterPerformanceRequestActTwo)}");
                actTwo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateCharacterPerformanceRequest(
                discriminator?.Model,
                actTwo
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateCharacterPerformanceRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCharacterPerformanceRequestActTwo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ActTwo!, typeInfo);
            }
        }
    }
}