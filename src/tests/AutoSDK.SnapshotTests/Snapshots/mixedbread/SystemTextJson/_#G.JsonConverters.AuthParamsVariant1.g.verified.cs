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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSourceAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::G.DataSourceOAuth2Params? oauth2 = default;
            if (discriminator?.Type == global::G.DataSourceAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSourceOAuth2Params>(ref reader, options);
            }
            global::G.DataSourceApiKeyParams? apiKey = default;
            if (discriminator?.Type == global::G.DataSourceAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSourceApiKeyParams>(ref reader, options);
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

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::G.DataSourceOAuth2Params), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::G.DataSourceApiKeyParams), options);
            }
        }
    }
}