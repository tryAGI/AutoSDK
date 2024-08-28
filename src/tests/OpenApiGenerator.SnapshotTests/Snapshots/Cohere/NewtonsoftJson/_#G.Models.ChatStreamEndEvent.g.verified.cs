//HintName: G.Models.ChatStreamEndEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatStreamEndEvent : global::System.IEquatable<ChatStreamEndEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEvent? Value1 { get; init; }
#else
        public global::G.ChatStreamEvent? Value1 { get; }
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
        public static implicit operator ChatStreamEndEvent(global::G.ChatStreamEvent value) => new ChatStreamEndEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatStreamEndEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(global::G.ChatStreamEvent? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEndEventVariant2? Value2 { get; init; }
#else
        public global::G.ChatStreamEndEventVariant2? Value2 { get; }
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
        public static implicit operator ChatStreamEndEvent(global::G.ChatStreamEndEventVariant2 value) => new ChatStreamEndEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEndEventVariant2?(ChatStreamEndEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(global::G.ChatStreamEndEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(
            global::G.ChatStreamEvent? value1,
            global::G.ChatStreamEndEventVariant2? value2
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
                typeof(global::G.ChatStreamEvent),
                Value2,
                typeof(global::G.ChatStreamEndEventVariant2),
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
        public bool Equals(ChatStreamEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEndEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatStreamEndEvent obj1, ChatStreamEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatStreamEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatStreamEndEvent obj1, ChatStreamEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatStreamEndEvent o && Equals(o);
        }
    }
}
