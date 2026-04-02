//HintName: G.Models.ChatRequestProviderOnlyItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestProviderOnlyItems : global::System.IEquatable<ChatRequestProviderOnlyItems>
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
        public string? ChatRequestProviderOnlyItemsVariant2 { get; init; }
#else
        public string? ChatRequestProviderOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestProviderOnlyItemsVariant2))]
#endif
        public bool IsChatRequestProviderOnlyItemsVariant2 => ChatRequestProviderOnlyItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderOnlyItems(global::G.ProviderName value) => new ChatRequestProviderOnlyItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ChatRequestProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOnlyItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestProviderOnlyItems(string value) => new ChatRequestProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatRequestProviderOnlyItems @this) => @this.ChatRequestProviderOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOnlyItems(string? value)
        {
            ChatRequestProviderOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestProviderOnlyItems(
            global::G.ProviderName? providerName,
            string? chatRequestProviderOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            ChatRequestProviderOnlyItemsVariant2 = chatRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestProviderOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ChatRequestProviderOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsChatRequestProviderOnlyItemsVariant2 || !IsProviderName && IsChatRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? chatRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsChatRequestProviderOnlyItemsVariant2 && chatRequestProviderOnlyItemsVariant2 != null)
            {
                return chatRequestProviderOnlyItemsVariant2(ChatRequestProviderOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? chatRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsChatRequestProviderOnlyItemsVariant2)
            {
                chatRequestProviderOnlyItemsVariant2?.Invoke(ChatRequestProviderOnlyItemsVariant2!);
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
                ChatRequestProviderOnlyItemsVariant2,
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
        public bool Equals(ChatRequestProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatRequestProviderOnlyItemsVariant2, other.ChatRequestProviderOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestProviderOnlyItems obj1, ChatRequestProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestProviderOnlyItems obj1, ChatRequestProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestProviderOnlyItems o && Equals(o);
        }
    }
}
