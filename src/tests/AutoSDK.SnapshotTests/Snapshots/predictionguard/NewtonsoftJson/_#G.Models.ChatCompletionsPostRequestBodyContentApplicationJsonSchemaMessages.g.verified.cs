//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages : global::System.IEquatable<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 { get; init; }
#else
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 != null;

        /// <summary>
        /// An array of messages used for generating completions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages(string value) => new ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages @this) => @this.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages(string? value)
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages(
            string? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1
            )
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1;
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 as object ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1?.ToString() ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 && !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 || !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 && IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1,
                typeof(string),
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1,
                typeof(global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>),
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
        public bool Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages o && Equals(o);
        }
    }
}
