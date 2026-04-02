//HintName: G.Models.ContextInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContextInput : global::System.IEquatable<ContextInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContextPair? Pair { get; init; }
#else
        public global::G.ContextPair? Pair { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pair))]
#endif
        public bool IsPair => Pair != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ContextPair>? ContextInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ContextPair>? ContextInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextInputVariant2))]
#endif
        public bool IsContextInputVariant2 => ContextInputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ContextInputVariant3 { get; init; }
#else
        public object? ContextInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextInputVariant3))]
#endif
        public bool IsContextInputVariant3 => ContextInputVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextInput(global::G.ContextPair value) => new ContextInput((global::G.ContextPair?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextPair?(ContextInput @this) => @this.Pair;

        /// <summary>
        /// 
        /// </summary>
        public ContextInput(global::G.ContextPair? value)
        {
            Pair = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContextInput(
            global::G.ContextPair? pair,
            global::System.Collections.Generic.IList<global::G.ContextPair>? contextInputVariant2,
            object? contextInputVariant3
            )
        {
            Pair = pair;
            ContextInputVariant2 = contextInputVariant2;
            ContextInputVariant3 = contextInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContextInputVariant3 as object ??
            ContextInputVariant2 as object ??
            Pair as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pair?.ToString() ??
            ContextInputVariant2?.ToString() ??
            ContextInputVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPair || IsContextInputVariant2 || IsContextInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ContextPair?, TResult>? pair = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ContextPair>?, TResult>? contextInputVariant2 = null,
            global::System.Func<object?, TResult>? contextInputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPair && pair != null)
            {
                return pair(Pair!);
            }
            else if (IsContextInputVariant2 && contextInputVariant2 != null)
            {
                return contextInputVariant2(ContextInputVariant2!);
            }
            else if (IsContextInputVariant3 && contextInputVariant3 != null)
            {
                return contextInputVariant3(ContextInputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ContextPair?>? pair = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ContextPair>?>? contextInputVariant2 = null,
            global::System.Action<object?>? contextInputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPair)
            {
                pair?.Invoke(Pair!);
            }
            else if (IsContextInputVariant2)
            {
                contextInputVariant2?.Invoke(ContextInputVariant2!);
            }
            else if (IsContextInputVariant3)
            {
                contextInputVariant3?.Invoke(ContextInputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Pair,
                typeof(global::G.ContextPair),
                ContextInputVariant2,
                typeof(global::System.Collections.Generic.IList<global::G.ContextPair>),
                ContextInputVariant3,
                typeof(object),
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
        public bool Equals(ContextInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ContextPair?>.Default.Equals(Pair, other.Pair) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ContextPair>?>.Default.Equals(ContextInputVariant2, other.ContextInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ContextInputVariant3, other.ContextInputVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContextInput obj1, ContextInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContextInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContextInput obj1, ContextInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContextInput o && Equals(o);
        }
    }
}
