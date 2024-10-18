//HintName: JsonConverters.CreateAppClientRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateAppClientRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateAppClientRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateAppClientRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAppClientRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAppClientRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAppClientRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateClientCredentialsRequest? credentials = default;
            if (discriminator?.Type == global::G.CreateAppClientRequestDiscriminatorType.ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientCredentialsRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientCredentialsRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateClientCredentialsRequest)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.CreateAppClientRequest(
                discriminator?.Type,
                credentials
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateAppClientRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientCredentialsRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientCredentialsRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateClientCredentialsRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Credentials, typeInfo);
            }
        }
    }
}