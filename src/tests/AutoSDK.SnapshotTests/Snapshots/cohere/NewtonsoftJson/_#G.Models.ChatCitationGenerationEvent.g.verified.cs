//HintName: G.Models.ChatCitationGenerationEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCitationGenerationEvent : global::System.IEquatable<ChatCitationGenerationEvent>
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
        public global::G.ChatCitationGenerationEventLg3v2o? Lg3v2o { get; init; }
#else
        public global::G.ChatCitationGenerationEventLg3v2o? Lg3v2o { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lg3v2o))]
#endif
        public bool IsLg3v2o => Lg3v2o != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCitationGenerationEvent(global::G.ChatStreamEvent value) => new ChatCitationGenerationEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatCitationGenerationEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatCitationGenerationEvent(global::G.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCitationGenerationEvent(global::G.ChatCitationGenerationEventLg3v2o value) => new ChatCitationGenerationEvent((global::G.ChatCitationGenerationEventLg3v2o?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCitationGenerationEventLg3v2o?(ChatCitationGenerationEvent @this) => @this.Lg3v2o;

        /// <summary>
        /// 
        /// </summary>
        public ChatCitationGenerationEvent(global::G.ChatCitationGenerationEventLg3v2o? value)
        {
            Lg3v2o = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCitationGenerationEvent(
            global::G.ChatStreamEvent? stream,
            global::G.ChatCitationGenerationEventLg3v2o? lg3v2o
            )
        {
            Stream = stream;
            Lg3v2o = lg3v2o;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lg3v2o as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Lg3v2o?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsLg3v2o;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? stream = null,
            global::System.Func<global::G.ChatCitationGenerationEventLg3v2o?, TResult>? lg3v2o = null,
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
            else if (IsLg3v2o && lg3v2o != null)
            {
                return lg3v2o(Lg3v2o!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? stream = null,
            global::System.Action<global::G.ChatCitationGenerationEventLg3v2o?>? lg3v2o = null,
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
            else if (IsLg3v2o)
            {
                lg3v2o?.Invoke(Lg3v2o!);
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
                Lg3v2o,
                typeof(global::G.ChatCitationGenerationEventLg3v2o),
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
        public bool Equals(ChatCitationGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCitationGenerationEventLg3v2o?>.Default.Equals(Lg3v2o, other.Lg3v2o) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCitationGenerationEvent obj1, ChatCitationGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCitationGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCitationGenerationEvent obj1, ChatCitationGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCitationGenerationEvent o && Equals(o);
        }
    }
}
