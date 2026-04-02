//HintName: G.JsonConverters.Error.g.cs
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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaErrorResponseErrorDiscriminator>(ref readerCopy, options);

            global::G.BetaInvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaInvalidRequestError>(ref reader, options);
            }
            global::G.BetaAuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaAuthenticationError>(ref reader, options);
            }
            global::G.BetaBillingError? billingError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.BillingError)
            {
                billingError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaBillingError>(ref reader, options);
            }
            global::G.BetaPermissionError? permissionError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.PermissionError)
            {
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaPermissionError>(ref reader, options);
            }
            global::G.BetaNotFoundError? notFoundError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaNotFoundError>(ref reader, options);
            }
            global::G.BetaRateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRateLimitError>(ref reader, options);
            }
            global::G.BetaGatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaGatewayTimeoutError>(ref reader, options);
            }
            global::G.BetaAPIError? apiError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.ApiError)
            {
                apiError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaAPIError>(ref reader, options);
            }
            global::G.BetaOverloadedError? overloadedError = default;
            if (discriminator?.Type == global::G.BetaErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaOverloadedError>(ref reader, options);
            }

            var __value = new global::G.Error(
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Error value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInvalidRequestError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeof(global::G.BetaInvalidRequestError), options);
            }
            else if (value.IsAuthenticationError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeof(global::G.BetaAuthenticationError), options);
            }
            else if (value.IsBillingError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeof(global::G.BetaBillingError), options);
            }
            else if (value.IsPermissionError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeof(global::G.BetaPermissionError), options);
            }
            else if (value.IsNotFoundError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeof(global::G.BetaNotFoundError), options);
            }
            else if (value.IsRateLimitError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeof(global::G.BetaRateLimitError), options);
            }
            else if (value.IsTimeoutError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeof(global::G.BetaGatewayTimeoutError), options);
            }
            else if (value.IsApiError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeof(global::G.BetaAPIError), options);
            }
            else if (value.IsOverloadedError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeof(global::G.BetaOverloadedError), options);
            }
        }
    }
}