//HintName: G.JsonConverters.AuthParamsVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthParamsVariant1>
    {
        /// <inheritdoc />
        public override global::G.AuthParamsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DataSourceAuthParamsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DataSourceAuthParamsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DataSourceAuthParamsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DataSourceOAuth2Params? oauth2 = default;
            if (discriminator?.Type == global::G.DataSourceAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DataSourceOAuth2Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DataSourceOAuth2Params> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DataSourceOAuth2Params)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DataSourceApiKeyParams? apiKey = default;
            if (discriminator?.Type == global::G.DataSourceAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DataSourceApiKeyParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DataSourceApiKeyParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DataSourceApiKeyParams)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AuthParamsVariant1(
                discriminator?.Type,
                oauth2,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AuthParamsVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DataSourceOAuth2Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DataSourceOAuth2Params?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DataSourceOAuth2Params).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DataSourceApiKeyParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DataSourceApiKeyParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DataSourceApiKeyParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
        }
    }
}