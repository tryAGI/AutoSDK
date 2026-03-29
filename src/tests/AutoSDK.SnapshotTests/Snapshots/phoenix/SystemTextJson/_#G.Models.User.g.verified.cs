//HintName: G.Models.User.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct User : global::System.IEquatable<User>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod? AuthMethod { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalUserData? Local { get; init; }
#else
        public global::G.LocalUserData? Local { get; }
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
        public global::G.OAuth2UserData? Oauth2 { get; init; }
#else
        public global::G.OAuth2UserData? Oauth2 { get; }
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
        public global::G.LDAPUserData? Ldap { get; init; }
#else
        public global::G.LDAPUserData? Ldap { get; }
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
        public static implicit operator User(global::G.LocalUserData value) => new User((global::G.LocalUserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalUserData?(User @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public User(global::G.LocalUserData? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator User(global::G.OAuth2UserData value) => new User((global::G.OAuth2UserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OAuth2UserData?(User @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public User(global::G.OAuth2UserData? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator User(global::G.LDAPUserData value) => new User((global::G.LDAPUserData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LDAPUserData?(User @this) => @this.Ldap;

        /// <summary>
        /// 
        /// </summary>
        public User(global::G.LDAPUserData? value)
        {
            Ldap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public User(
            global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod? authMethod,
            global::G.LocalUserData? local,
            global::G.OAuth2UserData? oauth2,
            global::G.LDAPUserData? ldap
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
            global::System.Func<global::G.LocalUserData?, TResult>? local = null,
            global::System.Func<global::G.OAuth2UserData?, TResult>? oauth2 = null,
            global::System.Func<global::G.LDAPUserData?, TResult>? ldap = null,
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
            global::System.Action<global::G.LocalUserData?>? local = null,
            global::System.Action<global::G.OAuth2UserData?>? oauth2 = null,
            global::System.Action<global::G.LDAPUserData?>? ldap = null,
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
                typeof(global::G.LocalUserData),
                Oauth2,
                typeof(global::G.OAuth2UserData),
                Ldap,
                typeof(global::G.LDAPUserData),
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
        public bool Equals(User other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LocalUserData?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OAuth2UserData?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LDAPUserData?>.Default.Equals(Ldap, other.Ldap) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(User obj1, User obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<User>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(User obj1, User obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is User o && Equals(o);
        }
    }
}
