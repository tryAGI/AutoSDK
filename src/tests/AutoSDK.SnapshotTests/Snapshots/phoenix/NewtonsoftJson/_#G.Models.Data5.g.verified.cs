//HintName: G.Models.Data5.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data5 : global::System.IEquatable<Data5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod? AuthMethod { get; }

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
#if NET6_0_OR_GREATER
        public global::G.AnonymousUser? Anonymous { get; init; }
#else
        public global::G.AnonymousUser? Anonymous { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anonymous))]
#endif
        public bool IsAnonymous => Anonymous != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::G.LocalUser value) => new Data5((global::G.LocalUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalUser?(Data5 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::G.LocalUser? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::G.OAuth2User value) => new Data5((global::G.OAuth2User?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OAuth2User?(Data5 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::G.OAuth2User? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::G.LDAPUser value) => new Data5((global::G.LDAPUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LDAPUser?(Data5 @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::G.LDAPUser? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data5(global::G.AnonymousUser value) => new Data5((global::G.AnonymousUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnonymousUser?(Data5 @this) => @this.Anonymous;

        /// <summary>
        /// 
        /// </summary>
        public Data5(global::G.AnonymousUser? value)
        {
            Anonymous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data5(
            global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod? authMethod,
            global::G.LocalUser? local,
            global::G.OAuth2User? oauth2,
            global::G.LDAPUser? ldap,
            global::G.AnonymousUser? anonymous
            )
        {
            AuthMethod = authMethod;

            Local = local;
            Oauth2 = oauth2;
            Ldap = ldap;
            Anonymous = anonymous;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anonymous as object ??
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
            Ldap?.ToString() ??
            Anonymous?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocal && !IsOauth2 && !IsLdap && !IsAnonymous || !IsLocal && IsOauth2 && !IsLdap && !IsAnonymous || !IsLocal && !IsOauth2 && IsLdap && !IsAnonymous || !IsLocal && !IsOauth2 && !IsLdap && IsAnonymous;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LocalUser?, TResult>? local = null,
            global::System.Func<global::G.OAuth2User?, TResult>? oauth2 = null,
            global::System.Func<global::G.LDAPUser?, TResult>? ldap = null,
            global::System.Func<global::G.AnonymousUser?, TResult>? anonymous = null,
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
            else if (IsAnonymous && anonymous != null)
            {
                return anonymous(Anonymous!);
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
            global::System.Action<global::G.AnonymousUser?>? anonymous = null,
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
            else if (IsAnonymous)
            {
                anonymous?.Invoke(Anonymous!);
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
                Anonymous,
                typeof(global::G.AnonymousUser),
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
        public bool Equals(Data5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LocalUser?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OAuth2User?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LDAPUser?>.Default.Equals(Ldap, other.Ldap) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnonymousUser?>.Default.Equals(Anonymous, other.Anonymous) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data5 obj1, Data5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data5 obj1, Data5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data5 o && Equals(o);
        }
    }
}
