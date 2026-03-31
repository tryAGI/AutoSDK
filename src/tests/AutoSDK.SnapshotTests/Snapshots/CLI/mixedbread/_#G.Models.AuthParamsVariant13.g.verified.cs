//HintName: G.Models.AuthParamsVariant13.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthParamsVariant13 : global::System.IEquatable<AuthParamsVariant13>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Base class for OAuth2 create or update parameters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OAuth2CreateOrUpdateParams? Oauth2 { get; init; }
#else
        public global::G.OAuth2CreateOrUpdateParams? Oauth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2))]
#endif
        public bool IsOauth2 => Oauth2 != null;

        /// <summary>
        /// Base class for API key create or update parameters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApiKeyCreateOrUpdateParams? ApiKey { get; init; }
#else
        public global::G.ApiKeyCreateOrUpdateParams? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthParamsVariant13(global::G.OAuth2CreateOrUpdateParams value) => new AuthParamsVariant13((global::G.OAuth2CreateOrUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OAuth2CreateOrUpdateParams?(AuthParamsVariant13 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant13(global::G.OAuth2CreateOrUpdateParams? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthParamsVariant13(global::G.ApiKeyCreateOrUpdateParams value) => new AuthParamsVariant13((global::G.ApiKeyCreateOrUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApiKeyCreateOrUpdateParams?(AuthParamsVariant13 @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant13(global::G.ApiKeyCreateOrUpdateParams? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant13(
            global::G.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? type,
            global::G.OAuth2CreateOrUpdateParams? oauth2,
            global::G.ApiKeyCreateOrUpdateParams? apiKey
            )
        {
            Type = type;

            Oauth2 = oauth2;
            ApiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiKey as object ??
            Oauth2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Oauth2?.ToString() ??
            ApiKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2 && !IsApiKey || !IsOauth2 && IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OAuth2CreateOrUpdateParams?, TResult>? oauth2 = null,
            global::System.Func<global::G.ApiKeyCreateOrUpdateParams?, TResult>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2 && oauth2 != null)
            {
                return oauth2(Oauth2!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OAuth2CreateOrUpdateParams?>? oauth2 = null,
            global::System.Action<global::G.ApiKeyCreateOrUpdateParams?>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2)
            {
                oauth2?.Invoke(Oauth2!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Oauth2,
                typeof(global::G.OAuth2CreateOrUpdateParams),
                ApiKey,
                typeof(global::G.ApiKeyCreateOrUpdateParams),
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
        public bool Equals(AuthParamsVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OAuth2CreateOrUpdateParams?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApiKeyCreateOrUpdateParams?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthParamsVariant13 obj1, AuthParamsVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthParamsVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthParamsVariant13 obj1, AuthParamsVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthParamsVariant13 o && Equals(o);
        }
    }
}
