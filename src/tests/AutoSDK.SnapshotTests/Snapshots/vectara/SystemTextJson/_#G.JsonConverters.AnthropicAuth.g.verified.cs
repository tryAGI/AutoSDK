//HintName: G.JsonConverters.AnthropicAuth.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AnthropicAuth>
    {
        /// <inheritdoc />
        public override global::G.AnthropicAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AnthropicAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AnthropicAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AnthropicAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BearerAuth? bearer = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HeaderAuth? header = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BedrockStaticIAMAuth? bedrockStaticIam = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.BedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockStaticIAMAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BedrockStaticIAMAuth)}");
                bedrockStaticIam = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BedrockApiKeyAuth? bedrockApiKey = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.BedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BedrockApiKeyAuth)}");
                bedrockApiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VertexServiceAccountAuth? vertexServiceAccount = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.VertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexServiceAccountAuth)}");
                vertexServiceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VertexAccessTokenAuth? vertexAccessToken = default;
            if (discriminator?.Type == global::G.AnthropicAuthDiscriminatorType.VertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAccessTokenAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexAccessTokenAuth)}");
                vertexAccessToken = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AnthropicAuth(
                discriminator?.Type,
                bearer,

                header,

                bedrockStaticIam,

                bedrockApiKey,

                vertexServiceAccount,

                vertexAccessToken
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnthropicAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BearerAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeaderAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeaderAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsBedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockStaticIAMAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BedrockStaticIAMAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockStaticIam!, typeInfo);
            }
            else if (value.IsBedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BedrockApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockApiKey!, typeInfo);
            }
            else if (value.IsVertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VertexServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexServiceAccount!, typeInfo);
            }
            else if (value.IsVertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAccessTokenAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VertexAccessTokenAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexAccessToken!, typeInfo);
            }
        }
    }
}