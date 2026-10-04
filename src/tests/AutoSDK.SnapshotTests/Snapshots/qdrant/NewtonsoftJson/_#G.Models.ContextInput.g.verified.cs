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
        public bool TryPickPair(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ContextPair? value)
        {
            value = Pair;
            return IsPair;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ContextPair PickPair() => Pair is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pair' but the value was {ToString()}.");

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
        public bool TryPickContextInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::G.ContextPair>? value)
        {
            value = ContextInputVariant2;
            return IsContextInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ContextPair> PickContextInputVariant2() => ContextInputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextInputVariant2' but the value was {ToString()}.");
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
        public static ContextInput FromPair(global::G.ContextPair? value) => new ContextInput(value);

        /// <summary>
        /// 
        /// </summary>
        public ContextInput(
            global::G.ContextPair? pair,
            global::System.Collections.Generic.IList<global::G.ContextPair>? contextInputVariant2
            )
        {
            Pair = pair;
            ContextInputVariant2 = contextInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContextInputVariant2 as object ??
            Pair as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pair?.ToString() ??
            ContextInputVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPair || IsContextInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ContextPair, TResult>? pair = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ContextPair>, TResult>? contextInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Pair is { } __value0 && pair != null)
            {
                return pair(__value0);
            }
            else if (ContextInputVariant2 is { } __value1 && contextInputVariant2 != null)
            {
                return contextInputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ContextPair>? pair = null,

            global::System.Action<global::System.Collections.Generic.IList<global::G.ContextPair>>? contextInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Pair is { } __value0)
            {
                pair?.Invoke(__value0);
            }
            else if (ContextInputVariant2 is { } __value1)
            {
                contextInputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ContextPair>? pair = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ContextPair>>? contextInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Pair is { } __value0)
            {
                pair?.Invoke(__value0);
            }
            else if (ContextInputVariant2 is { } __value1)
            {
                contextInputVariant2?.Invoke(__value1);
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ContextPair>?>.Default.Equals(ContextInputVariant2, other.ContextInputVariant2) 
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
