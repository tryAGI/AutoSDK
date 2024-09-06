//HintName: G.Models.ChatContentStartEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed delta event which signifies that a new content block has started.
    /// </summary>
    public readonly partial struct ChatContentStartEvent : global::System.IEquatable<ChatContentStartEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEventType? Value1 { get; init; }
#else
        public global::G.ChatStreamEventType? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentStartEvent(global::G.ChatStreamEventType value) => new ChatContentStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatContentStartEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(global::G.ChatStreamEventType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentStartEventVariant2? Value2 { get; init; }
#else
        public global::G.ChatContentStartEventVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentStartEvent(global::G.ChatContentStartEventVariant2 value) => new ChatContentStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentStartEventVariant2?(ChatContentStartEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(global::G.ChatContentStartEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(
            global::G.ChatStreamEventType? value1,
            global::G.ChatContentStartEventVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ChatStreamEventType),
                Value2,
                typeof(global::G.ChatContentStartEventVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatContentStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentStartEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentStartEvent obj1, ChatContentStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentStartEvent obj1, ChatContentStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentStartEvent o && Equals(o);
        }
    }
}
