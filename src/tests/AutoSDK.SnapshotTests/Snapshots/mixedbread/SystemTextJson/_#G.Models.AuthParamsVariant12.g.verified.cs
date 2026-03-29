//HintName: G.Models.AuthParamsVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthParamsVariant12 : global::System.IEquatable<AuthParamsVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public static implicit operator AuthParamsVariant12(global::G.OAuth2CreateOrUpdateParams value) => new AuthParamsVariant12((global::G.OAuth2CreateOrUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OAuth2CreateOrUpdateParams?(AuthParamsVariant12 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant12(global::G.OAuth2CreateOrUpdateParams? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthParamsVariant12(
            global::G.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? type,
            global::G.OAuth2CreateOrUpdateParams? oauth2
            )
        {
            Type = type;

            Oauth2 = oauth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Oauth2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Oauth2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OAuth2CreateOrUpdateParams?, TResult>? oauth2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OAuth2CreateOrUpdateParams?>? oauth2 = null,
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
        public bool Equals(AuthParamsVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OAuth2CreateOrUpdateParams?>.Default.Equals(Oauth2, other.Oauth2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthParamsVariant12 obj1, AuthParamsVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthParamsVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthParamsVariant12 obj1, AuthParamsVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthParamsVariant12 o && Equals(o);
        }
    }
}
