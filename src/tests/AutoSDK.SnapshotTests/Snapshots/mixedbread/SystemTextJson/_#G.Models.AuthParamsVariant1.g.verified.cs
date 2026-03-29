//HintName: G.Models.AuthParamsVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthParamsVariant1 : global::System.IEquatable<AuthParamsVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.DataSourceAuthParamsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Authentication parameters for a OAuth data source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataSourceOAuth2Params? Oauth2 { get; init; }
#else
        public global::G.DataSourceOAuth2Params? Oauth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2))]
#endif
        public bool IsOauth2 => Oauth2 != null;

        /// <summary>
        /// Authentication parameters for a API key data source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataSourceApiKeyParams? ApiKey { get; init; }
#else
        public global::G.DataSourceApiKeyParams? ApiKey { get; }
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
        public static implicit operator AuthParamsVariant1(global::G.DataSourceOAuth2Params value) => new AuthParamsVariant1((global::G.DataSourceOAuth2Params?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataSourceOAuth2Params?(AuthParamsVariant1 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant1(global::G.DataSourceOAuth2Params? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthParamsVariant1(global::G.DataSourceApiKeyParams value) => new AuthParamsVariant1((global::G.DataSourceApiKeyParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataSourceApiKeyParams?(AuthParamsVariant1 @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant1(global::G.DataSourceApiKeyParams? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant1(
            global::G.DataSourceAuthParamsVariant1DiscriminatorType? type,
            global::G.DataSourceOAuth2Params? oauth2,
            global::G.DataSourceApiKeyParams? apiKey
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
            global::System.Func<global::G.DataSourceOAuth2Params?, TResult>? oauth2 = null,
            global::System.Func<global::G.DataSourceApiKeyParams?, TResult>? apiKey = null,
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
            global::System.Action<global::G.DataSourceOAuth2Params?>? oauth2 = null,
            global::System.Action<global::G.DataSourceApiKeyParams?>? apiKey = null,
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
                typeof(global::G.DataSourceOAuth2Params),
                ApiKey,
                typeof(global::G.DataSourceApiKeyParams),
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
        public bool Equals(AuthParamsVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DataSourceOAuth2Params?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DataSourceApiKeyParams?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthParamsVariant1 obj1, AuthParamsVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthParamsVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthParamsVariant1 obj1, AuthParamsVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthParamsVariant1 o && Equals(o);
        }
    }
}
