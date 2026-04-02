//HintName: G.Models.AISecretType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AISecretType : global::System.IEquatable<AISecretType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AISecretTypeVariant1 { get; init; }
#else
        public string? AISecretTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AISecretTypeVariant1))]
#endif
        public bool IsAISecretTypeVariant1 => AISecretTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? AISecretTypeVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? AISecretTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AISecretTypeVariant2))]
#endif
        public bool IsAISecretTypeVariant2 => AISecretTypeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AISecretType(string value) => new AISecretType((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AISecretType @this) => @this.AISecretTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AISecretType(string? value)
        {
            AISecretTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AISecretType(
            string? aISecretTypeVariant1,
            global::System.Collections.Generic.IList<string>? aISecretTypeVariant2
            )
        {
            AISecretTypeVariant1 = aISecretTypeVariant1;
            AISecretTypeVariant2 = aISecretTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AISecretTypeVariant2 as object ??
            AISecretTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AISecretTypeVariant1?.ToString() ??
            AISecretTypeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAISecretTypeVariant1 || IsAISecretTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? aISecretTypeVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? aISecretTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAISecretTypeVariant1 && aISecretTypeVariant1 != null)
            {
                return aISecretTypeVariant1(AISecretTypeVariant1!);
            }
            else if (IsAISecretTypeVariant2 && aISecretTypeVariant2 != null)
            {
                return aISecretTypeVariant2(AISecretTypeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? aISecretTypeVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? aISecretTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAISecretTypeVariant1)
            {
                aISecretTypeVariant1?.Invoke(AISecretTypeVariant1!);
            }
            else if (IsAISecretTypeVariant2)
            {
                aISecretTypeVariant2?.Invoke(AISecretTypeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AISecretTypeVariant1,
                typeof(string),
                AISecretTypeVariant2,
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
        public bool Equals(AISecretType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AISecretTypeVariant1, other.AISecretTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(AISecretTypeVariant2, other.AISecretTypeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AISecretType obj1, AISecretType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AISecretType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AISecretType obj1, AISecretType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AISecretType o && Equals(o);
        }
    }
}
