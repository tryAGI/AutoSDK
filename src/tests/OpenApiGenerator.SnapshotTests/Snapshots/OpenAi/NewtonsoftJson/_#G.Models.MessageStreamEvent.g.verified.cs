//HintName: G.Models.MessageStreamEvent.g.cs
using System.Linq;

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant1? Value1 { get; init; }
#else
        public global::G.MessageStreamEventVariant1? Value1 { get; }
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
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant1 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant1?(MessageStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant2? Value2 { get; init; }
#else
        public global::G.MessageStreamEventVariant2? Value2 { get; }
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
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant2 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant2?(MessageStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant3? Value3 { get; init; }
#else
        public global::G.MessageStreamEventVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant3 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant3?(MessageStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant4? Value4 { get; init; }
#else
        public global::G.MessageStreamEventVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant4 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant4?(MessageStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant5? Value5 { get; init; }
#else
        public global::G.MessageStreamEventVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant5 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant5?(MessageStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::G.MessageStreamEventVariant1? value1,
            global::G.MessageStreamEventVariant2? value2,
            global::G.MessageStreamEventVariant3? value3,
            global::G.MessageStreamEventVariant4? value4,
            global::G.MessageStreamEventVariant5? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return !IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 || IsValue1 && !IsValue2 && IsValue3 && IsValue4 && IsValue5 || IsValue1 && IsValue2 && !IsValue3 && IsValue4 && IsValue5 || IsValue1 && IsValue2 && IsValue3 && !IsValue4 && IsValue5 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && !IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.MessageStreamEventVariant1),
                Value2,
                typeof(global::G.MessageStreamEventVariant2),
                Value3,
                typeof(global::G.MessageStreamEventVariant3),
                Value4,
                typeof(global::G.MessageStreamEventVariant4),
                Value5,
                typeof(global::G.MessageStreamEventVariant5),
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
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant5?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageStreamEvent o && Equals(o);
        }
    }
}
