//HintName: G.JsonConverters.AuthParamsVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthParamsVariant12>
    {
        /// <inheritdoc />
        public override global::G.AuthParamsVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::G.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OAuth2CreateOrUpdateParams>(ref reader, options);
            }

            var __value = new global::G.AuthParamsVariant12(
                discriminator?.Type,
                oauth2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AuthParamsVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::G.OAuth2CreateOrUpdateParams), options);
            }
        }
    }
}