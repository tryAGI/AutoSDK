//HintName: G.JsonConverters.UpdateToolRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UpdateToolRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateToolRequest>
    {
        /// <inheritdoc />
        public override global::G.UpdateToolRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateToolRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateToolRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateToolRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UpdateMcpToolRequest? mcp = default;
            if (discriminator?.Type == global::G.UpdateToolRequestDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateMcpToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateMcpToolRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateMcpToolRequest)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateLambdaToolRequest? lambda = default;
            if (discriminator?.Type == global::G.UpdateToolRequestDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateLambdaToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateLambdaToolRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateLambdaToolRequest)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.UpdateToolRequest(
                discriminator?.Type,
                mcp,

                lambda
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateToolRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateMcpToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateMcpToolRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateMcpToolRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateLambdaToolRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateLambdaToolRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateLambdaToolRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda, typeInfo);
            }
        }
    }
}