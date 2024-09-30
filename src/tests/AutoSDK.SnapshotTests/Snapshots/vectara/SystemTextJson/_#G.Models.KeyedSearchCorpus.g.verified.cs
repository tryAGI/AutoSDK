//HintName: G.Models.KeyedSearchCorpus.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KeyedSearchCorpus : global::System.IEquatable<KeyedSearchCorpus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchCorpus? Value1 { get; init; }
#else
        public global::G.SearchCorpus? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyedSearchCorpus(global::G.SearchCorpus value) => new KeyedSearchCorpus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchCorpus?(KeyedSearchCorpus @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(global::G.SearchCorpus? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyedSearchCorpusVariant2? Value2 { get; init; }
#else
        public global::G.KeyedSearchCorpusVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyedSearchCorpus(global::G.KeyedSearchCorpusVariant2 value) => new KeyedSearchCorpus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyedSearchCorpusVariant2?(KeyedSearchCorpus @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(global::G.KeyedSearchCorpusVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(
            global::G.SearchCorpus? value1,
            global::G.KeyedSearchCorpusVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SearchCorpus?, TResult>? value1 = null,
            global::System.Func<global::G.KeyedSearchCorpusVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SearchCorpus?>? value1 = null,
            global::System.Action<global::G.KeyedSearchCorpusVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.SearchCorpus),
                Value2,
                typeof(global::G.KeyedSearchCorpusVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(KeyedSearchCorpus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SearchCorpus?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyedSearchCorpusVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KeyedSearchCorpus obj1, KeyedSearchCorpus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KeyedSearchCorpus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KeyedSearchCorpus obj1, KeyedSearchCorpus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KeyedSearchCorpus o && Equals(o);
        }
    }
}
