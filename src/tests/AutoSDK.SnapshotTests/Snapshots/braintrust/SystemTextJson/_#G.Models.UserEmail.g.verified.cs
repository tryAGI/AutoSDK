//HintName: G.Models.UserEmail.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Email of the user to search for. You may pass the param multiple times to filter for more than one email
    /// </summary>
    public readonly partial struct UserEmail : global::System.IEquatable<UserEmail>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UserEmailVariant1 { get; init; }
#else
        public string? UserEmailVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserEmailVariant1))]
#endif
        public bool IsUserEmailVariant1 => UserEmailVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? UserEmailVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? UserEmailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserEmailVariant2))]
#endif
        public bool IsUserEmailVariant2 => UserEmailVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserEmail(string value) => new UserEmail((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UserEmail @this) => @this.UserEmailVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UserEmail(string? value)
        {
            UserEmailVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserEmail(
            string? userEmailVariant1,
            global::System.Collections.Generic.IList<string>? userEmailVariant2
            )
        {
            UserEmailVariant1 = userEmailVariant1;
            UserEmailVariant2 = userEmailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserEmailVariant2 as object ??
            UserEmailVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserEmailVariant1?.ToString() ??
            UserEmailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserEmailVariant1 || IsUserEmailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? userEmailVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? userEmailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserEmailVariant1 && userEmailVariant1 != null)
            {
                return userEmailVariant1(UserEmailVariant1!);
            }
            else if (IsUserEmailVariant2 && userEmailVariant2 != null)
            {
                return userEmailVariant2(UserEmailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? userEmailVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? userEmailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserEmailVariant1)
            {
                userEmailVariant1?.Invoke(UserEmailVariant1!);
            }
            else if (IsUserEmailVariant2)
            {
                userEmailVariant2?.Invoke(UserEmailVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserEmailVariant1,
                typeof(string),
                UserEmailVariant2,
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
        public bool Equals(UserEmail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UserEmailVariant1, other.UserEmailVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(UserEmailVariant2, other.UserEmailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserEmail obj1, UserEmail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserEmail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserEmail obj1, UserEmail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserEmail o && Equals(o);
        }
    }
}
