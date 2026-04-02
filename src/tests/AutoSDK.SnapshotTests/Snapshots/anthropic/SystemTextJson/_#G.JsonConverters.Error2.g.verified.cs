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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorResponseErrorDiscriminator>(ref readerCopy, options);

            global::G.InvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InvalidRequestError>(ref reader, options);
            }
            global::G.AuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AuthenticationError>(ref reader, options);
            }
            global::G.BillingError? billingError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.BillingError)
            {
                billingError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BillingError>(ref reader, options);
            }
            global::G.PermissionError? permissionError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.PermissionError)
            {
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PermissionError>(ref reader, options);
            }
            global::G.NotFoundError? notFoundError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.NotFoundError>(ref reader, options);
            }
            global::G.RateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RateLimitError>(ref reader, options);
            }
            global::G.GatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GatewayTimeoutError>(ref reader, options);
            }
            global::G.APIError? apiError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.ApiError)
            {
                apiError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.APIError>(ref reader, options);
            }
            global::G.OverloadedError? overloadedError = default;
            if (discriminator?.Type == global::G.ErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OverloadedError>(ref reader, options);
            }

            var __value = new global::G.Error2(
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
            global::G.Error2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInvalidRequestError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeof(global::G.InvalidRequestError), options);
            }
            else if (value.IsAuthenticationError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeof(global::G.AuthenticationError), options);
            }
            else if (value.IsBillingError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeof(global::G.BillingError), options);
            }
            else if (value.IsPermissionError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeof(global::G.PermissionError), options);
            }
            else if (value.IsNotFoundError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeof(global::G.NotFoundError), options);
            }
            else if (value.IsRateLimitError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeof(global::G.RateLimitError), options);
            }
            else if (value.IsTimeoutError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeof(global::G.GatewayTimeoutError), options);
            }
            else if (value.IsApiError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeof(global::G.APIError), options);
            }
            else if (value.IsOverloadedError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeof(global::G.OverloadedError), options);
            }
        }
    }
}