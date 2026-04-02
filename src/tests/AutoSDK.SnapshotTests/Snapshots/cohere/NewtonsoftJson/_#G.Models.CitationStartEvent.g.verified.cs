//HintName: G.Models.CitationStartEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event which signifies a citation has been created.
    /// </summary>
    public readonly partial struct CitationStartEvent : global::System.IEquatable<CitationStartEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEventType? ChatStreamType { get; init; }
#else
        public global::G.ChatStreamEventType? ChatStreamType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatStreamType))]
#endif
        public bool IsChatStreamType => ChatStreamType != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CitationStartEventT3df62? T3df62 { get; init; }
#else
        public global::G.CitationStartEventT3df62? T3df62 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(T3df62))]
#endif
        public bool IsT3df62 => T3df62 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationStartEvent(global::G.ChatStreamEventType value) => new CitationStartEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(CitationStartEvent @this) => @this.ChatStreamType;

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(global::G.ChatStreamEventType? value)
        {
            ChatStreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationStartEvent(global::G.CitationStartEventT3df62 value) => new CitationStartEvent((global::G.CitationStartEventT3df62?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CitationStartEventT3df62?(CitationStartEvent @this) => @this.T3df62;

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(global::G.CitationStartEventT3df62? value)
        {
            T3df62 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(
            global::G.ChatStreamEventType? chatStreamType,
            global::G.CitationStartEventT3df62? t3df62
            )
        {
            ChatStreamType = chatStreamType;
            T3df62 = t3df62;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            T3df62 as object ??
            ChatStreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatStreamType?.ToString() ??
            T3df62?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatStreamType && IsT3df62;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? chatStreamType = null,
            global::System.Func<global::G.CitationStartEventT3df62?, TResult>? t3df62 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamType && chatStreamType != null)
            {
                return chatStreamType(ChatStreamType!);
            }
            else if (IsT3df62 && t3df62 != null)
            {
                return t3df62(T3df62!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? chatStreamType = null,
            global::System.Action<global::G.CitationStartEventT3df62?>? t3df62 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamType)
            {
                chatStreamType?.Invoke(ChatStreamType!);
            }
            else if (IsT3df62)
            {
                t3df62?.Invoke(T3df62!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatStreamType,
                typeof(global::G.ChatStreamEventType),
                T3df62,
                typeof(global::G.CitationStartEventT3df62),
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
        public bool Equals(CitationStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(ChatStreamType, other.ChatStreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CitationStartEventT3df62?>.Default.Equals(T3df62, other.T3df62) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationStartEvent obj1, CitationStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationStartEvent obj1, CitationStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationStartEvent o && Equals(o);
        }
    }
}
