//HintName: G.Models.ChatCompletionRequestMessage.g.cs
using System.Linq;

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct ChatCompletionRequestMessage : global::System.IEquatable<ChatCompletionRequestMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestSystemMessage? Value1 { get; init; }
#else
        public global::G.ChatCompletionRequestSystemMessage? Value1 { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestUserMessage? Value2 { get; init; }
#else
        public global::G.ChatCompletionRequestUserMessage? Value2 { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestAssistantMessage? Value3 { get; init; }
#else
        public global::G.ChatCompletionRequestAssistantMessage? Value3 { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestToolMessage? Value4 { get; init; }
#else
        public global::G.ChatCompletionRequestToolMessage? Value4 { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestFunctionMessage? Value5 { get; init; }
#else
        public global::G.ChatCompletionRequestFunctionMessage? Value5 { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::G.ChatCompletionRequestSystemMessage? value1,
            global::G.ChatCompletionRequestUserMessage? value2,
            global::G.ChatCompletionRequestAssistantMessage? value3,
            global::G.ChatCompletionRequestToolMessage? value4,
            global::G.ChatCompletionRequestFunctionMessage? value5
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
                typeof(global::G.ChatCompletionRequestSystemMessage),
                Value2,
                typeof(global::G.ChatCompletionRequestUserMessage),
                Value3,
                typeof(global::G.ChatCompletionRequestAssistantMessage),
                Value4,
                typeof(global::G.ChatCompletionRequestToolMessage),
                Value5,
                typeof(global::G.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(ChatCompletionRequestMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestSystemMessage?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestUserMessage?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestAssistantMessage?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestToolMessage?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestFunctionMessage?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessage o && Equals(o);
        }
    }
}
