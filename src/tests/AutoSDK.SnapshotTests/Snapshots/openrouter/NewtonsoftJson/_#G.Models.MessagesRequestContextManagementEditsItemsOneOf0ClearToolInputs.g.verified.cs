//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs : global::System.IEquatable<MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 { get; init; }
#else
        public bool? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 => MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 => MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 { get; init; }
#else
        public object? MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 => MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs(bool value) => new MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs @this) => @this.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs(bool? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs(
            bool? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1,
            global::System.Collections.Generic.IList<string>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2,
            object? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3
            )
        {
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 = messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1;
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 = messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2;
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 = messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 as object ??
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 as object ??
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1?.ToString().ToLowerInvariant() ??
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 && !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 && !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 || !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 && IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 && !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 || !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 && !IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 && IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 = null,
            global::System.Func<object?, TResult>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 && messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 && messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 && messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2 = null,
            global::System.Action<object?>? messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1)
            {
                messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1?.Invoke(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2)
            {
                messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2?.Invoke(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3)
            {
                messagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3?.Invoke(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1,
                typeof(bool),
                MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3,
                typeof(object),
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
        public bool Equals(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1, other.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2, other.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3, other.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs obj1, MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs obj1, MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs o && Equals(o);
        }
    }
}
