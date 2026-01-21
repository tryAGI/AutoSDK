//HintName: G.Models.Error.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Error : global::System.IEquatable<Error>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaErrorResponseErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaInvalidRequestError? InvalidRequestError { get; init; }
#else
        public global::G.BetaInvalidRequestError? InvalidRequestError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvalidRequestError))]
#endif
        public bool IsInvalidRequestError => InvalidRequestError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaAuthenticationError? AuthenticationError { get; init; }
#else
        public global::G.BetaAuthenticationError? AuthenticationError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthenticationError))]
#endif
        public bool IsAuthenticationError => AuthenticationError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBillingError? BillingError { get; init; }
#else
        public global::G.BetaBillingError? BillingError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BillingError))]
#endif
        public bool IsBillingError => BillingError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaPermissionError? PermissionError { get; init; }
#else
        public global::G.BetaPermissionError? PermissionError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PermissionError))]
#endif
        public bool IsPermissionError => PermissionError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaNotFoundError? NotFoundError { get; init; }
#else
        public global::G.BetaNotFoundError? NotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotFoundError))]
#endif
        public bool IsNotFoundError => NotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRateLimitError? RateLimitError { get; init; }
#else
        public global::G.BetaRateLimitError? RateLimitError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitError))]
#endif
        public bool IsRateLimitError => RateLimitError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaGatewayTimeoutError? TimeoutError { get; init; }
#else
        public global::G.BetaGatewayTimeoutError? TimeoutError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimeoutError))]
#endif
        public bool IsTimeoutError => TimeoutError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaAPIError? ApiError { get; init; }
#else
        public global::G.BetaAPIError? ApiError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiError))]
#endif
        public bool IsApiError => ApiError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaOverloadedError? OverloadedError { get; init; }
#else
        public global::G.BetaOverloadedError? OverloadedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverloadedError))]
#endif
        public bool IsOverloadedError => OverloadedError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaInvalidRequestError value) => new Error((global::G.BetaInvalidRequestError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaInvalidRequestError?(Error @this) => @this.InvalidRequestError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaInvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaAuthenticationError value) => new Error((global::G.BetaAuthenticationError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaAuthenticationError?(Error @this) => @this.AuthenticationError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaAuthenticationError? value)
        {
            AuthenticationError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaBillingError value) => new Error((global::G.BetaBillingError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBillingError?(Error @this) => @this.BillingError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaBillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaPermissionError value) => new Error((global::G.BetaPermissionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaPermissionError?(Error @this) => @this.PermissionError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaPermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaNotFoundError value) => new Error((global::G.BetaNotFoundError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaNotFoundError?(Error @this) => @this.NotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaNotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaRateLimitError value) => new Error((global::G.BetaRateLimitError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRateLimitError?(Error @this) => @this.RateLimitError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaRateLimitError? value)
        {
            RateLimitError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaGatewayTimeoutError value) => new Error((global::G.BetaGatewayTimeoutError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaGatewayTimeoutError?(Error @this) => @this.TimeoutError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaGatewayTimeoutError? value)
        {
            TimeoutError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaAPIError value) => new Error((global::G.BetaAPIError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaAPIError?(Error @this) => @this.ApiError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaAPIError? value)
        {
            ApiError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(global::G.BetaOverloadedError value) => new Error((global::G.BetaOverloadedError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaOverloadedError?(Error @this) => @this.OverloadedError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::G.BetaOverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error(
            global::G.BetaErrorResponseErrorDiscriminatorType? type,
            global::G.BetaInvalidRequestError? invalidRequestError,
            global::G.BetaAuthenticationError? authenticationError,
            global::G.BetaBillingError? billingError,
            global::G.BetaPermissionError? permissionError,
            global::G.BetaNotFoundError? notFoundError,
            global::G.BetaRateLimitError? rateLimitError,
            global::G.BetaGatewayTimeoutError? timeoutError,
            global::G.BetaAPIError? apiError,
            global::G.BetaOverloadedError? overloadedError
            )
        {
            Type = type;

            InvalidRequestError = invalidRequestError;
            AuthenticationError = authenticationError;
            BillingError = billingError;
            PermissionError = permissionError;
            NotFoundError = notFoundError;
            RateLimitError = rateLimitError;
            TimeoutError = timeoutError;
            ApiError = apiError;
            OverloadedError = overloadedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OverloadedError as object ??
            ApiError as object ??
            TimeoutError as object ??
            RateLimitError as object ??
            NotFoundError as object ??
            PermissionError as object ??
            BillingError as object ??
            AuthenticationError as object ??
            InvalidRequestError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InvalidRequestError?.ToString() ??
            AuthenticationError?.ToString() ??
            BillingError?.ToString() ??
            PermissionError?.ToString() ??
            NotFoundError?.ToString() ??
            RateLimitError?.ToString() ??
            TimeoutError?.ToString() ??
            ApiError?.ToString() ??
            OverloadedError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && IsOverloadedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaInvalidRequestError?, TResult>? invalidRequestError = null,
            global::System.Func<global::G.BetaAuthenticationError?, TResult>? authenticationError = null,
            global::System.Func<global::G.BetaBillingError?, TResult>? billingError = null,
            global::System.Func<global::G.BetaPermissionError?, TResult>? permissionError = null,
            global::System.Func<global::G.BetaNotFoundError?, TResult>? notFoundError = null,
            global::System.Func<global::G.BetaRateLimitError?, TResult>? rateLimitError = null,
            global::System.Func<global::G.BetaGatewayTimeoutError?, TResult>? timeoutError = null,
            global::System.Func<global::G.BetaAPIError?, TResult>? apiError = null,
            global::System.Func<global::G.BetaOverloadedError?, TResult>? overloadedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvalidRequestError && invalidRequestError != null)
            {
                return invalidRequestError(InvalidRequestError!);
            }
            else if (IsAuthenticationError && authenticationError != null)
            {
                return authenticationError(AuthenticationError!);
            }
            else if (IsBillingError && billingError != null)
            {
                return billingError(BillingError!);
            }
            else if (IsPermissionError && permissionError != null)
            {
                return permissionError(PermissionError!);
            }
            else if (IsNotFoundError && notFoundError != null)
            {
                return notFoundError(NotFoundError!);
            }
            else if (IsRateLimitError && rateLimitError != null)
            {
                return rateLimitError(RateLimitError!);
            }
            else if (IsTimeoutError && timeoutError != null)
            {
                return timeoutError(TimeoutError!);
            }
            else if (IsApiError && apiError != null)
            {
                return apiError(ApiError!);
            }
            else if (IsOverloadedError && overloadedError != null)
            {
                return overloadedError(OverloadedError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaInvalidRequestError?>? invalidRequestError = null,
            global::System.Action<global::G.BetaAuthenticationError?>? authenticationError = null,
            global::System.Action<global::G.BetaBillingError?>? billingError = null,
            global::System.Action<global::G.BetaPermissionError?>? permissionError = null,
            global::System.Action<global::G.BetaNotFoundError?>? notFoundError = null,
            global::System.Action<global::G.BetaRateLimitError?>? rateLimitError = null,
            global::System.Action<global::G.BetaGatewayTimeoutError?>? timeoutError = null,
            global::System.Action<global::G.BetaAPIError?>? apiError = null,
            global::System.Action<global::G.BetaOverloadedError?>? overloadedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvalidRequestError)
            {
                invalidRequestError?.Invoke(InvalidRequestError!);
            }
            else if (IsAuthenticationError)
            {
                authenticationError?.Invoke(AuthenticationError!);
            }
            else if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
            }
            else if (IsPermissionError)
            {
                permissionError?.Invoke(PermissionError!);
            }
            else if (IsNotFoundError)
            {
                notFoundError?.Invoke(NotFoundError!);
            }
            else if (IsRateLimitError)
            {
                rateLimitError?.Invoke(RateLimitError!);
            }
            else if (IsTimeoutError)
            {
                timeoutError?.Invoke(TimeoutError!);
            }
            else if (IsApiError)
            {
                apiError?.Invoke(ApiError!);
            }
            else if (IsOverloadedError)
            {
                overloadedError?.Invoke(OverloadedError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InvalidRequestError,
                typeof(global::G.BetaInvalidRequestError),
                AuthenticationError,
                typeof(global::G.BetaAuthenticationError),
                BillingError,
                typeof(global::G.BetaBillingError),
                PermissionError,
                typeof(global::G.BetaPermissionError),
                NotFoundError,
                typeof(global::G.BetaNotFoundError),
                RateLimitError,
                typeof(global::G.BetaRateLimitError),
                TimeoutError,
                typeof(global::G.BetaGatewayTimeoutError),
                ApiError,
                typeof(global::G.BetaAPIError),
                OverloadedError,
                typeof(global::G.BetaOverloadedError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Error other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaInvalidRequestError?>.Default.Equals(InvalidRequestError, other.InvalidRequestError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaAuthenticationError?>.Default.Equals(AuthenticationError, other.AuthenticationError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBillingError?>.Default.Equals(BillingError, other.BillingError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaPermissionError?>.Default.Equals(PermissionError, other.PermissionError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaNotFoundError?>.Default.Equals(NotFoundError, other.NotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRateLimitError?>.Default.Equals(RateLimitError, other.RateLimitError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaGatewayTimeoutError?>.Default.Equals(TimeoutError, other.TimeoutError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaAPIError?>.Default.Equals(ApiError, other.ApiError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaOverloadedError?>.Default.Equals(OverloadedError, other.OverloadedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error obj1, Error obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error obj1, Error obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error o && Equals(o);
        }
    }
}
