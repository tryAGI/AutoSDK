//HintName: G.Models.ChatToolCallsGenerationEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatToolCallsGenerationEvent : global::System.IEquatable<ChatToolCallsGenerationEvent>
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
        public global::G.ChatToolCallsGenerationEventNykiww? Nykiww { get; init; }
#else
        public global::G.ChatToolCallsGenerationEventNykiww? Nykiww { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nykiww))]
#endif
        public bool IsNykiww => Nykiww != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsGenerationEvent(global::G.ChatStreamEvent value) => new ChatToolCallsGenerationEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatToolCallsGenerationEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsGenerationEvent(global::G.ChatToolCallsGenerationEventNykiww value) => new ChatToolCallsGenerationEvent((global::G.ChatToolCallsGenerationEventNykiww?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallsGenerationEventNykiww?(ChatToolCallsGenerationEvent @this) => @this.Nykiww;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(global::G.ChatToolCallsGenerationEventNykiww? value)
        {
            Nykiww = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatToolCallsGenerationEventNykiww? nykiww
            )
        {
            Stream = stream;
            Nykiww = nykiww;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Nykiww as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Nykiww?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsNykiww;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatToolCallsGenerationEventNykiww?, TResult>? nykiww = null,
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
            else if (IsNykiww && nykiww != null)
            {
                return nykiww(Nykiww!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatToolCallsGenerationEventNykiww?>? nykiww = null,
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
            else if (IsNykiww)
            {
                nykiww?.Invoke(Nykiww!);
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
                Nykiww,
                typeof(global::G.ChatToolCallsGenerationEventNykiww),
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
        public bool Equals(ChatToolCallsGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallsGenerationEventNykiww?>.Default.Equals(Nykiww, other.Nykiww) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallsGenerationEvent obj1, ChatToolCallsGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallsGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallsGenerationEvent obj1, ChatToolCallsGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallsGenerationEvent o && Equals(o);
        }
    }
}
