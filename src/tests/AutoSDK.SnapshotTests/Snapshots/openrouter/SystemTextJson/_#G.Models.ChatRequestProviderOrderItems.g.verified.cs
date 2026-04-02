//HintName: G.Models.ChatRequestProviderOrderItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestProviderOrderItems : global::System.IEquatable<ChatRequestProviderOrderItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderName? ProviderName { get; init; }
#else
        public global::G.ProviderName? ProviderName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderName))]
#endif
        public bool IsProviderName => ProviderName != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatRequestProviderOrderItemsVariant2 { get; init; }
#else
        public string? ChatRequestProviderOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestProviderOrderItemsVariant2))]
#endif
        public bool IsChatRequestProviderOrderItemsVariant2 => ChatRequestProviderOrderItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderOrderItems(global::G.ProviderName value) => new ChatRequestProviderOrderItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ChatRequestProviderOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOrderItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderOrderItems(string value) => new ChatRequestProviderOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatRequestProviderOrderItems @this) => @this.ChatRequestProviderOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOrderItems(string? value)
        {
            ChatRequestProviderOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOrderItems(
            global::G.ProviderName? providerName,
            string? chatRequestProviderOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            ChatRequestProviderOrderItemsVariant2 = chatRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestProviderOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ChatRequestProviderOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsChatRequestProviderOrderItemsVariant2 || !IsProviderName && IsChatRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? chatRequestProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName && providerName != null)
            {
                return providerName(ProviderName!);
            }
            else if (IsChatRequestProviderOrderItemsVariant2 && chatRequestProviderOrderItemsVariant2 != null)
            {
                return chatRequestProviderOrderItemsVariant2(ChatRequestProviderOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? chatRequestProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsChatRequestProviderOrderItemsVariant2)
            {
                chatRequestProviderOrderItemsVariant2?.Invoke(ChatRequestProviderOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderName,
                typeof(global::G.ProviderName),
                ChatRequestProviderOrderItemsVariant2,
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
        public bool Equals(ChatRequestProviderOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatRequestProviderOrderItemsVariant2, other.ChatRequestProviderOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestProviderOrderItems obj1, ChatRequestProviderOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestProviderOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestProviderOrderItems obj1, ChatRequestProviderOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestProviderOrderItems o && Equals(o);
        }
    }
}
