//HintName: G.Models.CitationEndEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event which signifies a citation has finished streaming.
    /// </summary>
    public readonly partial struct CitationEndEvent : global::System.IEquatable<CitationEndEvent>
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
        public global::G.CitationEndEventFs3igt? Fs3igt { get; init; }
#else
        public global::G.CitationEndEventFs3igt? Fs3igt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fs3igt))]
#endif
        public bool IsFs3igt => Fs3igt != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationEndEvent(global::G.ChatStreamEventType value) => new CitationEndEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(CitationEndEvent @this) => @this.ChatStreamType;

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(global::G.ChatStreamEventType? value)
        {
            ChatStreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationEndEvent(global::G.CitationEndEventFs3igt value) => new CitationEndEvent((global::G.CitationEndEventFs3igt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CitationEndEventFs3igt?(CitationEndEvent @this) => @this.Fs3igt;

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(global::G.CitationEndEventFs3igt? value)
        {
            Fs3igt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(
            global::G.ChatStreamEventType? chatStreamType,
            global::G.CitationEndEventFs3igt? fs3igt
            )
        {
            ChatStreamType = chatStreamType;
            Fs3igt = fs3igt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fs3igt as object ??
            ChatStreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatStreamType?.ToString() ??
            Fs3igt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatStreamType && IsFs3igt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? chatStreamType = null,
            global::System.Func<global::G.CitationEndEventFs3igt?, TResult>? fs3igt = null,
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
            else if (IsFs3igt && fs3igt != null)
            {
                return fs3igt(Fs3igt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? chatStreamType = null,
            global::System.Action<global::G.CitationEndEventFs3igt?>? fs3igt = null,
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
            else if (IsFs3igt)
            {
                fs3igt?.Invoke(Fs3igt!);
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
                Fs3igt,
                typeof(global::G.CitationEndEventFs3igt),
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
        public bool Equals(CitationEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(ChatStreamType, other.ChatStreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CitationEndEventFs3igt?>.Default.Equals(Fs3igt, other.Fs3igt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationEndEvent obj1, CitationEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationEndEvent obj1, CitationEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationEndEvent o && Equals(o);
        }
    }
}
