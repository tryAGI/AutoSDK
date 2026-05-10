//HintName: G.Models.SearchAllMessagesResponseItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchAllMessagesResponseItem : global::System.IEquatable<SearchAllMessagesResponseItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchAllMessagesResponseItemDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// System message list result with agent context.<br/>
        /// Shape is identical to UpdateSystemMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemMessageListResult? SystemMessage { get; init; }
#else
        public global::G.SystemMessageListResult? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystemMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SystemMessageListResult? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SystemMessageListResult PickSystemMessage() => IsSystemMessage
            ? SystemMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");

        /// <summary>
        /// User message list result with agent context.<br/>
        /// Shape is identical to UpdateUserMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserMessageListResult? UserMessage { get; init; }
#else
        public global::G.UserMessageListResult? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.UserMessageListResult? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.UserMessageListResult PickUserMessage() => IsUserMessage
            ? UserMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// Reasoning message list result with agent context.<br/>
        /// Shape is identical to UpdateReasoningMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningMessageListResult? ReasoningMessage { get; init; }
#else
        public global::G.ReasoningMessageListResult? ReasoningMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningMessage))]
#endif
        public bool IsReasoningMessage => ReasoningMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ReasoningMessageListResult? value)
        {
            value = ReasoningMessage;
            return IsReasoningMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningMessageListResult PickReasoningMessage() => IsReasoningMessage
            ? ReasoningMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningMessage' but the value was {ToString()}.");

        /// <summary>
        /// Assistant message list result with agent context.<br/>
        /// Shape is identical to UpdateAssistantMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantMessageListResult? AssistantMessage { get; init; }
#else
        public global::G.AssistantMessageListResult? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssistantMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.AssistantMessageListResult? value)
        {
            value = AssistantMessage;
            return IsAssistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantMessageListResult PickAssistantMessage() => IsAssistantMessage
            ? AssistantMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssistantMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::G.SystemMessageListResult value) => new SearchAllMessagesResponseItem((global::G.SystemMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemMessageListResult?(SearchAllMessagesResponseItem @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::G.SystemMessageListResult? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchAllMessagesResponseItem FromSystemMessage(global::G.SystemMessageListResult? value) => new SearchAllMessagesResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::G.UserMessageListResult value) => new SearchAllMessagesResponseItem((global::G.UserMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserMessageListResult?(SearchAllMessagesResponseItem @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::G.UserMessageListResult? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchAllMessagesResponseItem FromUserMessage(global::G.UserMessageListResult? value) => new SearchAllMessagesResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::G.ReasoningMessageListResult value) => new SearchAllMessagesResponseItem((global::G.ReasoningMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningMessageListResult?(SearchAllMessagesResponseItem @this) => @this.ReasoningMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::G.ReasoningMessageListResult? value)
        {
            ReasoningMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchAllMessagesResponseItem FromReasoningMessage(global::G.ReasoningMessageListResult? value) => new SearchAllMessagesResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::G.AssistantMessageListResult value) => new SearchAllMessagesResponseItem((global::G.AssistantMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantMessageListResult?(SearchAllMessagesResponseItem @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::G.AssistantMessageListResult? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchAllMessagesResponseItem FromAssistantMessage(global::G.AssistantMessageListResult? value) => new SearchAllMessagesResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(
            global::G.SearchAllMessagesResponseItemDiscriminatorMessageType? messageType,
            global::G.SystemMessageListResult? systemMessage,
            global::G.UserMessageListResult? userMessage,
            global::G.ReasoningMessageListResult? reasoningMessage,
            global::G.AssistantMessageListResult? assistantMessage
            )
        {
            MessageType = messageType;

            SystemMessage = systemMessage;
            UserMessage = userMessage;
            ReasoningMessage = reasoningMessage;
            AssistantMessage = assistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantMessage as object ??
            ReasoningMessage as object ??
            UserMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SystemMessage?.ToString() ??
            UserMessage?.ToString() ??
            ReasoningMessage?.ToString() ??
            AssistantMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsUserMessage && !IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && IsUserMessage && !IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && !IsUserMessage && IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && !IsUserMessage && !IsReasoningMessage && IsAssistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SystemMessageListResult, TResult>? systemMessage = null,
            global::System.Func<global::G.UserMessageListResult, TResult>? userMessage = null,
            global::System.Func<global::G.ReasoningMessageListResult, TResult>? reasoningMessage = null,
            global::System.Func<global::G.AssistantMessageListResult, TResult>? assistantMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }
            else if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsReasoningMessage && reasoningMessage != null)
            {
                return reasoningMessage(ReasoningMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SystemMessageListResult>? systemMessage = null,

            global::System.Action<global::G.UserMessageListResult>? userMessage = null,

            global::System.Action<global::G.ReasoningMessageListResult>? reasoningMessage = null,

            global::System.Action<global::G.AssistantMessageListResult>? assistantMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsReasoningMessage)
            {
                reasoningMessage?.Invoke(ReasoningMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.SystemMessageListResult>? systemMessage = null,
            global::System.Action<global::G.UserMessageListResult>? userMessage = null,
            global::System.Action<global::G.ReasoningMessageListResult>? reasoningMessage = null,
            global::System.Action<global::G.AssistantMessageListResult>? assistantMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsReasoningMessage)
            {
                reasoningMessage?.Invoke(ReasoningMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemMessage,
                typeof(global::G.SystemMessageListResult),
                UserMessage,
                typeof(global::G.UserMessageListResult),
                ReasoningMessage,
                typeof(global::G.ReasoningMessageListResult),
                AssistantMessage,
                typeof(global::G.AssistantMessageListResult),
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
        public bool Equals(SearchAllMessagesResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SystemMessageListResult?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserMessageListResult?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningMessageListResult?>.Default.Equals(ReasoningMessage, other.ReasoningMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantMessageListResult?>.Default.Equals(AssistantMessage, other.AssistantMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchAllMessagesResponseItem obj1, SearchAllMessagesResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchAllMessagesResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchAllMessagesResponseItem obj1, SearchAllMessagesResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchAllMessagesResponseItem o && Equals(o);
        }
    }
}
