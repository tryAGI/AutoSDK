//HintName: G.Models.Error2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Error2 : global::System.IEquatable<Error2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ErrorResponseErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InvalidRequestError? InvalidRequestError { get; init; }
#else
        public global::G.InvalidRequestError? InvalidRequestError { get; }
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
        public static implicit operator Error2(global::G.InvalidRequestError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InvalidRequestError?(Error2 @this) => @this.InvalidRequestError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.InvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AuthenticationError? AuthenticationError { get; init; }
#else
        public global::G.AuthenticationError? AuthenticationError { get; }
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
        public static implicit operator Error2(global::G.AuthenticationError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AuthenticationError?(Error2 @this) => @this.AuthenticationError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.AuthenticationError? value)
        {
            AuthenticationError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PermissionError? PermissionError { get; init; }
#else
        public global::G.PermissionError? PermissionError { get; }
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
        public static implicit operator Error2(global::G.PermissionError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PermissionError?(Error2 @this) => @this.PermissionError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.PermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NotFoundError? NotFoundError { get; init; }
#else
        public global::G.NotFoundError? NotFoundError { get; }
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
        public static implicit operator Error2(global::G.NotFoundError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NotFoundError?(Error2 @this) => @this.NotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.NotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RateLimitError? RateLimitError { get; init; }
#else
        public global::G.RateLimitError? RateLimitError { get; }
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
        public static implicit operator Error2(global::G.RateLimitError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RateLimitError?(Error2 @this) => @this.RateLimitError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.RateLimitError? value)
        {
            RateLimitError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.APIError? ApiError { get; init; }
#else
        public global::G.APIError? ApiError { get; }
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
        public static implicit operator Error2(global::G.APIError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.APIError?(Error2 @this) => @this.ApiError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.APIError? value)
        {
            ApiError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OverloadedError? OverloadedError { get; init; }
#else
        public global::G.OverloadedError? OverloadedError { get; }
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
        public static implicit operator Error2(global::G.OverloadedError value) => new Error2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OverloadedError?(Error2 @this) => @this.OverloadedError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::G.OverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error2(
            global::G.ErrorResponseErrorDiscriminatorType? type,
            global::G.InvalidRequestError? invalidRequestError,
            global::G.AuthenticationError? authenticationError,
            global::G.PermissionError? permissionError,
            global::G.NotFoundError? notFoundError,
            global::G.RateLimitError? rateLimitError,
            global::G.APIError? apiError,
            global::G.OverloadedError? overloadedError
            )
        {
            Type = type;

            InvalidRequestError = invalidRequestError;
            AuthenticationError = authenticationError;
            PermissionError = permissionError;
            NotFoundError = notFoundError;
            RateLimitError = rateLimitError;
            ApiError = apiError;
            OverloadedError = overloadedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OverloadedError as object ??
            ApiError as object ??
            RateLimitError as object ??
            NotFoundError as object ??
            PermissionError as object ??
            AuthenticationError as object ??
            InvalidRequestError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInvalidRequestError && !IsAuthenticationError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && IsAuthenticationError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsPermissionError && IsNotFoundError && !IsRateLimitError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsPermissionError && !IsNotFoundError && IsRateLimitError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsApiError && IsOverloadedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InvalidRequestError?, TResult>? invalidRequestError = null,
            global::System.Func<global::G.AuthenticationError?, TResult>? authenticationError = null,
            global::System.Func<global::G.PermissionError?, TResult>? permissionError = null,
            global::System.Func<global::G.NotFoundError?, TResult>? notFoundError = null,
            global::System.Func<global::G.RateLimitError?, TResult>? rateLimitError = null,
            global::System.Func<global::G.APIError?, TResult>? apiError = null,
            global::System.Func<global::G.OverloadedError?, TResult>? overloadedError = null,
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
            global::System.Action<global::G.InvalidRequestError?>? invalidRequestError = null,
            global::System.Action<global::G.AuthenticationError?>? authenticationError = null,
            global::System.Action<global::G.PermissionError?>? permissionError = null,
            global::System.Action<global::G.NotFoundError?>? notFoundError = null,
            global::System.Action<global::G.RateLimitError?>? rateLimitError = null,
            global::System.Action<global::G.APIError?>? apiError = null,
            global::System.Action<global::G.OverloadedError?>? overloadedError = null,
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
                typeof(global::G.InvalidRequestError),
                AuthenticationError,
                typeof(global::G.AuthenticationError),
                PermissionError,
                typeof(global::G.PermissionError),
                NotFoundError,
                typeof(global::G.NotFoundError),
                RateLimitError,
                typeof(global::G.RateLimitError),
                ApiError,
                typeof(global::G.APIError),
                OverloadedError,
                typeof(global::G.OverloadedError),
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
        public bool Equals(Error2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InvalidRequestError?>.Default.Equals(InvalidRequestError, other.InvalidRequestError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AuthenticationError?>.Default.Equals(AuthenticationError, other.AuthenticationError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PermissionError?>.Default.Equals(PermissionError, other.PermissionError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NotFoundError?>.Default.Equals(NotFoundError, other.NotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RateLimitError?>.Default.Equals(RateLimitError, other.RateLimitError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.APIError?>.Default.Equals(ApiError, other.ApiError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OverloadedError?>.Default.Equals(OverloadedError, other.OverloadedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error2 obj1, Error2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error2 obj1, Error2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error2 o && Equals(o);
        }
    }
}
