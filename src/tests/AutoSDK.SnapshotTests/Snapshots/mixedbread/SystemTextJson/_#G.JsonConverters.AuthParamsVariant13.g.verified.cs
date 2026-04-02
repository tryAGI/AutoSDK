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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::G.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OAuth2CreateOrUpdateParams>(ref reader, options);
            }
            global::G.ApiKeyCreateOrUpdateParams? apiKey = default;
            if (discriminator?.Type == global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApiKeyCreateOrUpdateParams>(ref reader, options);
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

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::G.OAuth2CreateOrUpdateParams), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::G.ApiKeyCreateOrUpdateParams), options);
            }
        }
    }
}