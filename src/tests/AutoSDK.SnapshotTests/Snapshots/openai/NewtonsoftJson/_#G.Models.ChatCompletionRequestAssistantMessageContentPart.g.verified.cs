//HintName: G.Models.ChatCompletionRequestAssistantMessageContentPart.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestAssistantMessageContentPart : global::System.IEquatable<ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartRefusal? RefusalContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartRefusal? RefusalContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalContentPart))]
#endif
        public bool IsRefusalContentPart => RefusalContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestAssistantMessageContentPart((global::G.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::G.ChatCompletionRequestMessageContentPartRefusal value) => new ChatCompletionRequestAssistantMessageContentPart((global::G.ChatCompletionRequestMessageContentPartRefusal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartRefusal?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.RefusalContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::G.ChatCompletionRequestMessageContentPartRefusal? value)
        {
            RefusalContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(
            global::G.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::G.ChatCompletionRequestMessageContentPartRefusal? refusalContentPart
            )
        {
            TextContentPart = textContentPart;
            RefusalContentPart = refusalContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RefusalContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            RefusalContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsRefusalContentPart || !IsTextContentPart && IsRefusalContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartRefusal?, TResult>? refusalContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }
            else if (IsRefusalContentPart && refusalContentPart != null)
            {
                return refusalContentPart(RefusalContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartRefusal?>? refusalContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsRefusalContentPart)
            {
                refusalContentPart?.Invoke(RefusalContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartText),
                RefusalContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartRefusal),
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
        public bool Equals(ChatCompletionRequestAssistantMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartRefusal?>.Default.Equals(RefusalContentPart, other.RefusalContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestAssistantMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestAssistantMessageContentPart o && Equals(o);
        }
    }
}
