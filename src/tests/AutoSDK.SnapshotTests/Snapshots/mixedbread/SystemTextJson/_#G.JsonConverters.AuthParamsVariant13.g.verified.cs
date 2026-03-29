//HintName: G.JsonConverters.AuthParamsVariant13.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthParamsVariant13>
    {
        /// <inheritdoc />
        public override global::G.AuthParamsVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2CreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2CreateOrUpdateParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OAuth2CreateOrUpdateParams)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApiKeyCreateOrUpdateParams? apiKey = default;
            if (discriminator?.Type == global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiKeyCreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiKeyCreateOrUpdateParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApiKeyCreateOrUpdateParams)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AuthParamsVariant13(
                discriminator?.Type,
                oauth2,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AuthParamsVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2CreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2CreateOrUpdateParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OAuth2CreateOrUpdateParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiKeyCreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiKeyCreateOrUpdateParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApiKeyCreateOrUpdateParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeInfo);
            }
        }
    }
}