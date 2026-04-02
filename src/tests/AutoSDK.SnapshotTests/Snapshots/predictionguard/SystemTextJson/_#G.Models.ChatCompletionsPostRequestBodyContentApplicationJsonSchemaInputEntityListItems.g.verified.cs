//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems : global::System.IEquatable<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 { get; init; }
#else
        public string? ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1))]
#endif
        public bool IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 => ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems(string value) => new ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems @this) => @this.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems(string? value)
        {
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 && chatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 != null)
            {
                return chatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1)
            {
                chatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1?.Invoke(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1,
                typeof(string),
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
        public bool Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1, other.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj1, ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems o && Equals(o);
        }
    }
}
