//HintName: G.Models.ChatTextGenerationEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatTextGenerationEvent : global::System.IEquatable<ChatTextGenerationEvent>
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
        public global::G.ChatTextGenerationEvent8yyj22? Event8yyj22 { get; init; }
#else
        public global::G.ChatTextGenerationEvent8yyj22? Event8yyj22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event8yyj22))]
#endif
        public bool IsEvent8yyj22 => Event8yyj22 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatTextGenerationEvent(global::G.ChatStreamEvent value) => new ChatTextGenerationEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatTextGenerationEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatTextGenerationEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatTextGenerationEvent(global::G.ChatTextGenerationEvent8yyj22 value) => new ChatTextGenerationEvent((global::G.ChatTextGenerationEvent8yyj22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatTextGenerationEvent8yyj22?(ChatTextGenerationEvent @this) => @this.Event8yyj22;

        /// <summary>
        /// 
        /// </summary>
        public ChatTextGenerationEvent(global::G.ChatTextGenerationEvent8yyj22? value)
        {
            Event8yyj22 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatTextGenerationEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatTextGenerationEvent8yyj22? event8yyj22
            )
        {
            Stream = stream;
            Event8yyj22 = event8yyj22;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event8yyj22 as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Event8yyj22?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsEvent8yyj22;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatTextGenerationEvent8yyj22?, TResult>? event8yyj22 = null,
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
            else if (IsEvent8yyj22 && event8yyj22 != null)
            {
                return event8yyj22(Event8yyj22!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatTextGenerationEvent8yyj22?>? event8yyj22 = null,
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
            else if (IsEvent8yyj22)
            {
                event8yyj22?.Invoke(Event8yyj22!);
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
                Event8yyj22,
                typeof(global::G.ChatTextGenerationEvent8yyj22),
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
        public bool Equals(ChatTextGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatTextGenerationEvent8yyj22?>.Default.Equals(Event8yyj22, other.Event8yyj22) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatTextGenerationEvent obj1, ChatTextGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatTextGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatTextGenerationEvent obj1, ChatTextGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatTextGenerationEvent o && Equals(o);
        }
    }
}
