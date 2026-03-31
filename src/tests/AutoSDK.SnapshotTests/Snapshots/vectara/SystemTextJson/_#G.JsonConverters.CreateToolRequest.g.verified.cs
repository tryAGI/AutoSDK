//HintName: G.JsonConverters.CreateToolRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateToolRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateToolRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateToolRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateToolRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateToolRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateToolRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateLambdaToolRequest? lambda = default;
            if (discriminator?.Type == global::G.CreateToolRequestDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLambdaToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLambdaToolRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateLambdaToolRequest)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateToolRequest(
                discriminator?.Type,
                lambda
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateToolRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLambdaToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLambdaToolRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateLambdaToolRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda!, typeInfo);
            }
        }
    }
}