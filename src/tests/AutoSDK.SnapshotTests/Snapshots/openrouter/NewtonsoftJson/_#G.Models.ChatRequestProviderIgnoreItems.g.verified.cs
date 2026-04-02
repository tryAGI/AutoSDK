//HintName: G.Models.ChatRequestProviderIgnoreItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestProviderIgnoreItems : global::System.IEquatable<ChatRequestProviderIgnoreItems>
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
        public string? ChatRequestProviderIgnoreItemsVariant2 { get; init; }
#else
        public string? ChatRequestProviderIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestProviderIgnoreItemsVariant2))]
#endif
        public bool IsChatRequestProviderIgnoreItemsVariant2 => ChatRequestProviderIgnoreItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderIgnoreItems(global::G.ProviderName value) => new ChatRequestProviderIgnoreItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ChatRequestProviderIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderIgnoreItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderIgnoreItems(string value) => new ChatRequestProviderIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatRequestProviderIgnoreItems @this) => @this.ChatRequestProviderIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderIgnoreItems(string? value)
        {
            ChatRequestProviderIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderIgnoreItems(
            global::G.ProviderName? providerName,
            string? chatRequestProviderIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            ChatRequestProviderIgnoreItemsVariant2 = chatRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestProviderIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ChatRequestProviderIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsChatRequestProviderIgnoreItemsVariant2 || !IsProviderName && IsChatRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? chatRequestProviderIgnoreItemsVariant2 = null,
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
            else if (IsChatRequestProviderIgnoreItemsVariant2 && chatRequestProviderIgnoreItemsVariant2 != null)
            {
                return chatRequestProviderIgnoreItemsVariant2(ChatRequestProviderIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? chatRequestProviderIgnoreItemsVariant2 = null,
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
            else if (IsChatRequestProviderIgnoreItemsVariant2)
            {
                chatRequestProviderIgnoreItemsVariant2?.Invoke(ChatRequestProviderIgnoreItemsVariant2!);
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
                ChatRequestProviderIgnoreItemsVariant2,
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
        public bool Equals(ChatRequestProviderIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatRequestProviderIgnoreItemsVariant2, other.ChatRequestProviderIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestProviderIgnoreItems obj1, ChatRequestProviderIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestProviderIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestProviderIgnoreItems obj1, ChatRequestProviderIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestProviderIgnoreItems o && Equals(o);
        }
    }
}
