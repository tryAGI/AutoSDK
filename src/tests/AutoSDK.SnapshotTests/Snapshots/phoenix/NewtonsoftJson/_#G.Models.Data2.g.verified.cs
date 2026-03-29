//HintName: G.Models.Data2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data2 : global::System.IEquatable<Data2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateUserResponseBodyDataDiscriminatorAuthMethod? AuthMethod { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalUser? Local { get; init; }
#else
        public global::G.LocalUser? Local { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Local))]
#endif
        public bool IsLocal => Local != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OAuth2User? Oauth2 { get; init; }
#else
        public global::G.OAuth2User? Oauth2 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.LDAPUser? Ldap { get; init; }
#else
        public global::G.LDAPUser? Ldap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ldap))]
#endif
        public bool IsLdap => Ldap != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::G.LocalUser value) => new Data2((global::G.LocalUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalUser?(Data2 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::G.LocalUser? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::G.OAuth2User value) => new Data2((global::G.OAuth2User?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OAuth2User?(Data2 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::G.OAuth2User? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::G.LDAPUser value) => new Data2((global::G.LDAPUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LDAPUser?(Data2 @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::G.LDAPUser? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data2(
            global::G.CreateUserResponseBodyDataDiscriminatorAuthMethod? authMethod,
            global::G.LocalUser? local,
            global::G.OAuth2User? oauth2,
            global::G.LDAPUser? ldap
            )
        {
            AuthMethod = authMethod;

            Local = local;
            Oauth2 = oauth2;
            Ldap = ldap;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ldap as object ??
            Oauth2 as object ??
            Local as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Local?.ToString() ??
            Oauth2?.ToString() ??
            Ldap?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocal && !IsOauth2 && !IsLdap || !IsLocal && IsOauth2 && !IsLdap || !IsLocal && !IsOauth2 && IsLdap;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LocalUser?, TResult>? local = null,
            global::System.Func<global::G.OAuth2User?, TResult>? oauth2 = null,
            global::System.Func<global::G.LDAPUser?, TResult>? ldap = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal && local != null)
            {
                return local(Local!);
            }
            else if (IsOauth2 && oauth2 != null)
            {
                return oauth2(Oauth2!);
            }
            else if (IsLdap && ldap != null)
            {
                return ldap(Ldap!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LocalUser?>? local = null,
            global::System.Action<global::G.OAuth2User?>? oauth2 = null,
            global::System.Action<global::G.LDAPUser?>? ldap = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal)
            {
                local?.Invoke(Local!);
            }
            else if (IsOauth2)
            {
                oauth2?.Invoke(Oauth2!);
            }
            else if (IsLdap)
            {
                ldap?.Invoke(Ldap!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Local,
                typeof(global::G.LocalUser),
                Oauth2,
                typeof(global::G.OAuth2User),
                Ldap,
                typeof(global::G.LDAPUser),
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
        public bool Equals(Data2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LocalUser?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OAuth2User?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LDAPUser?>.Default.Equals(Ldap, other.Ldap) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data2 obj1, Data2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data2 obj1, Data2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data2 o && Equals(o);
        }
    }
}
