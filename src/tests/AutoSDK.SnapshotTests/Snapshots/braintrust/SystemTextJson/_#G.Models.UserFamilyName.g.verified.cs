//HintName: G.Models.UserFamilyName.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Family name of the user to search for. You may pass the param multiple times to filter for more than one family name
    /// </summary>
    public readonly partial struct UserFamilyName : global::System.IEquatable<UserFamilyName>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UserFamilyNameVariant1 { get; init; }
#else
        public string? UserFamilyNameVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserFamilyNameVariant1))]
#endif
        public bool IsUserFamilyNameVariant1 => UserFamilyNameVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? UserFamilyNameVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? UserFamilyNameVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserFamilyNameVariant2))]
#endif
        public bool IsUserFamilyNameVariant2 => UserFamilyNameVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFamilyName(string value) => new UserFamilyName((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UserFamilyName @this) => @this.UserFamilyNameVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UserFamilyName(string? value)
        {
            UserFamilyNameVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserFamilyName(
            string? userFamilyNameVariant1,
            global::System.Collections.Generic.IList<string>? userFamilyNameVariant2
            )
        {
            UserFamilyNameVariant1 = userFamilyNameVariant1;
            UserFamilyNameVariant2 = userFamilyNameVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserFamilyNameVariant2 as object ??
            UserFamilyNameVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserFamilyNameVariant1?.ToString() ??
            UserFamilyNameVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserFamilyNameVariant1 || IsUserFamilyNameVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? userFamilyNameVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? userFamilyNameVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserFamilyNameVariant1 && userFamilyNameVariant1 != null)
            {
                return userFamilyNameVariant1(UserFamilyNameVariant1!);
            }
            else if (IsUserFamilyNameVariant2 && userFamilyNameVariant2 != null)
            {
                return userFamilyNameVariant2(UserFamilyNameVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? userFamilyNameVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? userFamilyNameVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserFamilyNameVariant1)
            {
                userFamilyNameVariant1?.Invoke(UserFamilyNameVariant1!);
            }
            else if (IsUserFamilyNameVariant2)
            {
                userFamilyNameVariant2?.Invoke(UserFamilyNameVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserFamilyNameVariant1,
                typeof(string),
                UserFamilyNameVariant2,
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
        public bool Equals(UserFamilyName other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UserFamilyNameVariant1, other.UserFamilyNameVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(UserFamilyNameVariant2, other.UserFamilyNameVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserFamilyName obj1, UserFamilyName obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserFamilyName>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserFamilyName obj1, UserFamilyName obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserFamilyName o && Equals(o);
        }
    }
}
