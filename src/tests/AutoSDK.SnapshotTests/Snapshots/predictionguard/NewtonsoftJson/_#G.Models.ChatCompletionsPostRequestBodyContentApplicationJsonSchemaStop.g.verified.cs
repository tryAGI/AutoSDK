//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop : global::System.IEquatable<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 { get; init; }
#else
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop(string value) => new ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop @this) => @this.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop(string? value)
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop(
            string? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1,
            global::System.Collections.Generic.IList<string>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2
            )
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1;
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 as object ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1?.ToString() ??
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 || !IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1!);
            }
            else if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1,
                typeof(string),
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop o && Equals(o);
        }
    }
}
