//HintName: G.Models.ChatSearchResultsEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatSearchResultsEvent : global::System.IEquatable<ChatSearchResultsEvent>
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
        public global::G.ChatSearchResultsEvent44axt5? Event44axt5 { get; init; }
#else
        public global::G.ChatSearchResultsEvent44axt5? Event44axt5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event44axt5))]
#endif
        public bool IsEvent44axt5 => Event44axt5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatSearchResultsEvent(global::G.ChatStreamEvent value) => new ChatSearchResultsEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatSearchResultsEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchResultsEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatSearchResultsEvent(global::G.ChatSearchResultsEvent44axt5 value) => new ChatSearchResultsEvent((global::G.ChatSearchResultsEvent44axt5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchResultsEvent44axt5?(ChatSearchResultsEvent @this) => @this.Event44axt5;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchResultsEvent(global::G.ChatSearchResultsEvent44axt5? value)
        {
            Event44axt5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchResultsEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatSearchResultsEvent44axt5? event44axt5
            )
        {
            Stream = stream;
            Event44axt5 = event44axt5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event44axt5 as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Event44axt5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsEvent44axt5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatSearchResultsEvent44axt5?, TResult>? event44axt5 = null,
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
            else if (IsEvent44axt5 && event44axt5 != null)
            {
                return event44axt5(Event44axt5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatSearchResultsEvent44axt5?>? event44axt5 = null,
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
            else if (IsEvent44axt5)
            {
                event44axt5?.Invoke(Event44axt5!);
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
                Event44axt5,
                typeof(global::G.ChatSearchResultsEvent44axt5),
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
        public bool Equals(ChatSearchResultsEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchResultsEvent44axt5?>.Default.Equals(Event44axt5, other.Event44axt5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatSearchResultsEvent obj1, ChatSearchResultsEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatSearchResultsEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatSearchResultsEvent obj1, ChatSearchResultsEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatSearchResultsEvent o && Equals(o);
        }
    }
}
