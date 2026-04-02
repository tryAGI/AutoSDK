//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice : global::System.IEquatable<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 { get; init; }
#else
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 != null;

        /// <summary>
        /// An object representing the tool to be chosen
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 { get; init; }
#else
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(string value) => new ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice @this) => @this.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(string? value)
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 value) => new ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice((global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice @this) => @this.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1? value)
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(
            string? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1
            )
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1;
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 as object ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1?.ToString() ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 && !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 || !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 && IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 = null,
            global::System.Func<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1 = null,
            global::System.Action<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1,
                typeof(string),
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1,
                typeof(global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1),
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
        public bool Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice o && Equals(o);
        }
    }
}
