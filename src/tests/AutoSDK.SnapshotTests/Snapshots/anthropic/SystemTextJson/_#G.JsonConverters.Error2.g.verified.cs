//HintName: G.JsonConverters.Error2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Error2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Error2>
    {
        /// <inheritdoc />
        public override global::G.Error2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorResponseErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorResponseErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ErrorResponseErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InvalidRequestError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InvalidRequestError)}");
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AuthenticationError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AuthenticationError)}");
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BillingError? billingError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.BillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BillingError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BillingError)}");
                billingError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PermissionError? permissionError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.PermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PermissionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PermissionError)}");
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.NotFoundError? notFoundError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NotFoundError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.NotFoundError)}");
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RateLimitError)}");
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GatewayTimeoutError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GatewayTimeoutError)}");
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.APIError? apiError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.ApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.APIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.APIError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.APIError)}");
                apiError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OverloadedError? overloadedError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OverloadedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OverloadedError)}");
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Error2(
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
            global::G.Error2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InvalidRequestError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InvalidRequestError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeInfo);
            }
            else if (value.IsAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AuthenticationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AuthenticationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeInfo);
            }
            else if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeInfo);
            }
            else if (value.IsPermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PermissionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PermissionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeInfo);
            }
            else if (value.IsNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NotFoundError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NotFoundError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeInfo);
            }
            else if (value.IsRateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeInfo);
            }
            else if (value.IsTimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GatewayTimeoutError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GatewayTimeoutError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeInfo);
            }
            else if (value.IsApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.APIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.APIError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.APIError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeInfo);
            }
            else if (value.IsOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OverloadedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OverloadedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeInfo);
            }
        }
    }
}