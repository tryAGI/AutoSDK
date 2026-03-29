//HintName: G.Models.CustomAuthConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomAuthConfig : global::System.IEquatable<CustomAuthConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomAuthConfigBasic? Basic { get; init; }
#else
        public global::G.CustomAuthConfigBasic? Basic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Basic))]
#endif
        public bool IsBasic => Basic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomAuthConfigOAuth2? OAuth2 { get; init; }
#else
        public global::G.CustomAuthConfigOAuth2? OAuth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OAuth2))]
#endif
        public bool IsOAuth2 => OAuth2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomAuthConfig(global::G.CustomAuthConfigBasic value) => new CustomAuthConfig((global::G.CustomAuthConfigBasic?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomAuthConfigBasic?(CustomAuthConfig @this) => @this.Basic;

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(global::G.CustomAuthConfigBasic? value)
        {
            Basic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomAuthConfig(global::G.CustomAuthConfigOAuth2 value) => new CustomAuthConfig((global::G.CustomAuthConfigOAuth2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomAuthConfigOAuth2?(CustomAuthConfig @this) => @this.OAuth2;

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(global::G.CustomAuthConfigOAuth2? value)
        {
            OAuth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(
            global::G.CustomAuthConfigBasic? basic,
            global::G.CustomAuthConfigOAuth2? oAuth2
            )
        {
            Basic = basic;
            OAuth2 = oAuth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OAuth2 as object ??
            Basic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Basic?.ToString() ??
            OAuth2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasic || IsOAuth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CustomAuthConfigBasic?, TResult>? basic = null,
            global::System.Func<global::G.CustomAuthConfigOAuth2?, TResult>? oAuth2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasic && basic != null)
            {
                return basic(Basic!);
            }
            else if (IsOAuth2 && oAuth2 != null)
            {
                return oAuth2(OAuth2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CustomAuthConfigBasic?>? basic = null,
            global::System.Action<global::G.CustomAuthConfigOAuth2?>? oAuth2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
            else if (IsOAuth2)
            {
                oAuth2?.Invoke(OAuth2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Basic,
                typeof(global::G.CustomAuthConfigBasic),
                OAuth2,
                typeof(global::G.CustomAuthConfigOAuth2),
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
        public bool Equals(CustomAuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CustomAuthConfigBasic?>.Default.Equals(Basic, other.Basic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomAuthConfigOAuth2?>.Default.Equals(OAuth2, other.OAuth2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomAuthConfig obj1, CustomAuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomAuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomAuthConfig obj1, CustomAuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomAuthConfig o && Equals(o);
        }
    }
}
