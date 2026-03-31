//HintName: G.JsonConverters.AuthenticationPlan9.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthenticationPlan9JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthenticationPlan9>
    {
        /// <inheritdoc />
        public override global::G.AuthenticationPlan9 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.OAuth2AuthenticationPlan? oauth2 = default;
            if (discriminator?.Type == global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2AuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2AuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OAuth2AuthenticationPlan)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HMACAuthenticationPlan? hmac = default;
            if (discriminator?.Type == global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Hmac)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HMACAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HMACAuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HMACAuthenticationPlan)}");
                hmac = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BearerAuthenticationPlan? bearer = default;
            if (discriminator?.Type == global::G.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BearerAuthenticationPlan)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AuthenticationPlan9(
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
            global::G.AuthenticationPlan9 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2AuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2AuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OAuth2AuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsHmac)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HMACAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HMACAuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HMACAuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hmac!, typeInfo);
            }
            else if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BearerAuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
        }
    }
}