//HintName: G.Models.ThreadStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ThreadStreamEvent : global::System.IEquatable<ThreadStreamEvent>
    {
        /// <summary>
        /// Occurs when a new [thread](/docs/api-reference/threads/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ThreadStreamEventVariant1? ThreadStreamEventVariant1 { get; init; }
#else
        public global::G.ThreadStreamEventVariant1? ThreadStreamEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadStreamEventVariant1))]
#endif
        public bool IsThreadStreamEventVariant1 => ThreadStreamEventVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadStreamEvent(global::G.ThreadStreamEventVariant1 value) => new ThreadStreamEvent((global::G.ThreadStreamEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThreadStreamEventVariant1?(ThreadStreamEvent @this) => @this.ThreadStreamEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ThreadStreamEvent(global::G.ThreadStreamEventVariant1? value)
        {
            ThreadStreamEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThreadStreamEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ThreadStreamEventVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThreadStreamEventVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ThreadStreamEventVariant1?, TResult>? threadStreamEventVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThreadStreamEventVariant1 && threadStreamEventVariant1 != null)
            {
                return threadStreamEventVariant1(ThreadStreamEventVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ThreadStreamEventVariant1?>? threadStreamEventVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThreadStreamEventVariant1)
            {
                threadStreamEventVariant1?.Invoke(ThreadStreamEventVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThreadStreamEventVariant1,
                typeof(global::G.ThreadStreamEventVariant1),
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
        public bool Equals(ThreadStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ThreadStreamEventVariant1?>.Default.Equals(ThreadStreamEventVariant1, other.ThreadStreamEventVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThreadStreamEvent obj1, ThreadStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThreadStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThreadStreamEvent obj1, ThreadStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThreadStreamEvent o && Equals(o);
        }
    }
}
