//HintName: G.JsonConverters.AuthenticationPlan6.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthenticationPlan6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthenticationPlan6>
    {
        /// <inheritdoc />
        public override global::G.AuthenticationPlan6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCustomCredentialDTOAuthenticationPlanDiscriminator>(ref readerCopy, options);

            global::G.OAuth2AuthenticationPlan? oauth2 = default;
            if (discriminator?.Type == global::G.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OAuth2AuthenticationPlan>(ref reader, options);
            }
            global::G.HMACAuthenticationPlan? hmac = default;
            if (discriminator?.Type == global::G.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Hmac)
            {
                hmac = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HMACAuthenticationPlan>(ref reader, options);
            }
            global::G.BearerAuthenticationPlan? bearer = default;
            if (discriminator?.Type == global::G.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Bearer)
            {
                bearer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BearerAuthenticationPlan>(ref reader, options);
            }

            var __value = new global::G.AuthenticationPlan6(
                discriminator?.Type,
                oauth2,

                hmac,

                bearer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AuthenticationPlan6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::G.OAuth2AuthenticationPlan), options);
            }
            else if (value.IsHmac)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hmac, typeof(global::G.HMACAuthenticationPlan), options);
            }
            else if (value.IsBearer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer, typeof(global::G.BearerAuthenticationPlan), options);
            }
        }
    }
}