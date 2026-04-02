//HintName: G.Models.ChatSearchQueriesGenerationEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatSearchQueriesGenerationEvent : global::System.IEquatable<ChatSearchQueriesGenerationEvent>
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
        public global::G.ChatSearchQueriesGenerationEvent6evypd? Event6evypd { get; init; }
#else
        public global::G.ChatSearchQueriesGenerationEvent6evypd? Event6evypd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event6evypd))]
#endif
        public bool IsEvent6evypd => Event6evypd != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatSearchQueriesGenerationEvent(global::G.ChatStreamEvent value) => new ChatSearchQueriesGenerationEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatSearchQueriesGenerationEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatSearchQueriesGenerationEvent(global::G.ChatSearchQueriesGenerationEvent6evypd value) => new ChatSearchQueriesGenerationEvent((global::G.ChatSearchQueriesGenerationEvent6evypd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchQueriesGenerationEvent6evypd?(ChatSearchQueriesGenerationEvent @this) => @this.Event6evypd;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(global::G.ChatSearchQueriesGenerationEvent6evypd? value)
        {
            Event6evypd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatSearchQueriesGenerationEvent6evypd? event6evypd
            )
        {
            Stream = stream;
            Event6evypd = event6evypd;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event6evypd as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Event6evypd?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsEvent6evypd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatSearchQueriesGenerationEvent6evypd?, TResult>? event6evypd = null,
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
            else if (IsEvent6evypd && event6evypd != null)
            {
                return event6evypd(Event6evypd!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatSearchQueriesGenerationEvent6evypd?>? event6evypd = null,
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
            else if (IsEvent6evypd)
            {
                event6evypd?.Invoke(Event6evypd!);
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
                Event6evypd,
                typeof(global::G.ChatSearchQueriesGenerationEvent6evypd),
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
        public bool Equals(ChatSearchQueriesGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchQueriesGenerationEvent6evypd?>.Default.Equals(Event6evypd, other.Event6evypd) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatSearchQueriesGenerationEvent obj1, ChatSearchQueriesGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatSearchQueriesGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatSearchQueriesGenerationEvent obj1, ChatSearchQueriesGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatSearchQueriesGenerationEvent o && Equals(o);
        }
    }
}
