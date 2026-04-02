//HintName: G.Models.ChatDebugEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatDebugEvent : global::System.IEquatable<ChatDebugEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEvent? Stream { get; init; }
#else
        public global::G.ChatStreamEvent? Stream { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stream))]
#endif
        public bool IsStream => Stream != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatDebugEvent352j0t? Event352j0t { get; init; }
#else
        public global::G.ChatDebugEvent352j0t? Event352j0t { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event352j0t))]
#endif
        public bool IsEvent352j0t => Event352j0t != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatDebugEvent(global::G.ChatStreamEvent value) => new ChatDebugEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatDebugEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatDebugEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatDebugEvent(global::G.ChatDebugEvent352j0t value) => new ChatDebugEvent((global::G.ChatDebugEvent352j0t?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatDebugEvent352j0t?(ChatDebugEvent @this) => @this.Event352j0t;

        /// <summary>
        /// 
        /// </summary>
        public ChatDebugEvent(global::G.ChatDebugEvent352j0t? value)
        {
            Event352j0t = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatDebugEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatDebugEvent352j0t? event352j0t
            )
        {
            Stream = stream;
            Event352j0t = event352j0t;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event352j0t as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Event352j0t?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsEvent352j0t;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatDebugEvent352j0t?, TResult>? event352j0t = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream && stream != null)
            {
                return stream(Stream!);
            }
            else if (IsEvent352j0t && event352j0t != null)
            {
                return event352j0t(Event352j0t!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatDebugEvent352j0t?>? event352j0t = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
            else if (IsEvent352j0t)
            {
                event352j0t?.Invoke(Event352j0t!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stream,
                typeof(global::G.ChatStreamEvent),
                Event352j0t,
                typeof(global::G.ChatDebugEvent352j0t),
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
        public bool Equals(ChatDebugEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatDebugEvent352j0t?>.Default.Equals(Event352j0t, other.Event352j0t) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatDebugEvent obj1, ChatDebugEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatDebugEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatDebugEvent obj1, ChatDebugEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatDebugEvent o && Equals(o);
        }
    }
}
