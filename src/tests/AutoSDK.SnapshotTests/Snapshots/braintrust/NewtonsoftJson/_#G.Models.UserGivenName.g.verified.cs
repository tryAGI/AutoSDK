//HintName: G.Models.UserGivenName.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Given name of the user to search for. You may pass the param multiple times to filter for more than one given name
    /// </summary>
    public readonly partial struct UserGivenName : global::System.IEquatable<UserGivenName>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UserGivenNameVariant1 { get; init; }
#else
        public string? UserGivenNameVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserGivenNameVariant1))]
#endif
        public bool IsUserGivenNameVariant1 => UserGivenNameVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? UserGivenNameVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? UserGivenNameVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserGivenNameVariant2))]
#endif
        public bool IsUserGivenNameVariant2 => UserGivenNameVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserGivenName(string value) => new UserGivenName((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UserGivenName @this) => @this.UserGivenNameVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UserGivenName(string? value)
        {
            UserGivenNameVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserGivenName(
            string? userGivenNameVariant1,
            global::System.Collections.Generic.IList<string>? userGivenNameVariant2
            )
        {
            UserGivenNameVariant1 = userGivenNameVariant1;
            UserGivenNameVariant2 = userGivenNameVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserGivenNameVariant2 as object ??
            UserGivenNameVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserGivenNameVariant1?.ToString() ??
            UserGivenNameVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserGivenNameVariant1 || IsUserGivenNameVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? userGivenNameVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? userGivenNameVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserGivenNameVariant1 && userGivenNameVariant1 != null)
            {
                return userGivenNameVariant1(UserGivenNameVariant1!);
            }
            else if (IsUserGivenNameVariant2 && userGivenNameVariant2 != null)
            {
                return userGivenNameVariant2(UserGivenNameVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? userGivenNameVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? userGivenNameVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserGivenNameVariant1)
            {
                userGivenNameVariant1?.Invoke(UserGivenNameVariant1!);
            }
            else if (IsUserGivenNameVariant2)
            {
                userGivenNameVariant2?.Invoke(UserGivenNameVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserGivenNameVariant1,
                typeof(string),
                UserGivenNameVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(UserGivenName other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UserGivenNameVariant1, other.UserGivenNameVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(UserGivenNameVariant2, other.UserGivenNameVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserGivenName obj1, UserGivenName obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserGivenName>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserGivenName obj1, UserGivenName obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserGivenName o && Equals(o);
        }
    }
}
