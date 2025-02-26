//HintName: JsonConverters.Error.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Error>
    {
        /// <inheritdoc />
        public override global::G.Error Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaErrorResponseErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaErrorResponseErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaErrorResponseErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaInvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaInvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaInvalidRequestError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaInvalidRequestError)}");
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaAuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaAuthenticationError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaAuthenticationError)}");
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaBillingError? billingError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.BillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBillingError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaBillingError)}");
                billingError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaPermissionError? permissionError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.PermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaPermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaPermissionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaPermissionError)}");
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaNotFoundError? notFoundError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaNotFoundError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaNotFoundError)}");
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaRateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRateLimitError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRateLimitError)}");
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaGatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaGatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaGatewayTimeoutError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaGatewayTimeoutError)}");
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaAPIError? apiError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.ApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaAPIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaAPIError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaAPIError)}");
                apiError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaOverloadedError? overloadedError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaOverloadedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaOverloadedError)}");
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Error(
                discriminator?.Type,
                invalidRequestError,
                authenticationError,
                billingError,
                permissionError,
                notFoundError,
                rateLimitError,
                timeoutError,
                apiError,
                overloadedError
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Error value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaInvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaInvalidRequestError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaInvalidRequestError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeInfo);
            }
            else if (value.IsAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaAuthenticationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaAuthenticationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeInfo);
            }
            else if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaBillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeInfo);
            }
            else if (value.IsPermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaPermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaPermissionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaPermissionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeInfo);
            }
            else if (value.IsNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaNotFoundError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaNotFoundError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeInfo);
            }
            else if (value.IsRateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRateLimitError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaRateLimitError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeInfo);
            }
            else if (value.IsTimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaGatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaGatewayTimeoutError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaGatewayTimeoutError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeInfo);
            }
            else if (value.IsApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaAPIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaAPIError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaAPIError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeInfo);
            }
            else if (value.IsOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaOverloadedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaOverloadedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeInfo);
            }
        }
    }
}