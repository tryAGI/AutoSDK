//HintName: G.Models.ChatCompletionRequestMessageContentPart.g.cs
using System.Linq;

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct ChatCompletionRequestMessageContentPart : global::System.IEquatable<ChatCompletionRequestMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartText? Value1 { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartText? Value1 { get; }
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
        public static implicit operator ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestMessageContentPart @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartImage? Value2 { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartImage? Value2 { get; }
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
        public static implicit operator ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestMessageContentPart @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(
            global::G.ChatCompletionRequestMessageContentPartText? value1,
            global::G.ChatCompletionRequestMessageContentPartImage? value2
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
            return !IsValue1 && IsValue2 || IsValue1 && !IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ChatCompletionRequestMessageContentPartText),
                Value2,
                typeof(global::G.ChatCompletionRequestMessageContentPartImage),
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
        public bool Equals(ChatCompletionRequestMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessageContentPart o && Equals(o);
        }
    }
}
