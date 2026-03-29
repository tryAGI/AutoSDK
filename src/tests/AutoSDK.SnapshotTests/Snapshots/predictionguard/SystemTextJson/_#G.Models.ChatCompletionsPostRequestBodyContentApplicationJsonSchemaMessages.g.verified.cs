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
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

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
        public static implicit operator string?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1
            )
        {
            Value1 = value1;
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 || !IsValue1 && IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
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
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
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
                Value1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
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
