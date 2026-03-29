//HintName: G.Models.ChatCompletionRequestMessage.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessage : global::System.IEquatable<ChatCompletionRequestMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestSystemMessage? SystemMessage { get; init; }
#else
        public global::G.ChatCompletionRequestSystemMessage? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// New role by OpenAI for select models. Must be explicitly used for models that support it. When used with incompatible models or providers, Portkey automatically converts it to a system role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestDeveloperMessage? DeveloperMessage { get; init; }
#else
        public global::G.ChatCompletionRequestDeveloperMessage? DeveloperMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeveloperMessage))]
#endif
        public bool IsDeveloperMessage => DeveloperMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestUserMessage? UserMessage { get; init; }
#else
        public global::G.ChatCompletionRequestUserMessage? UserMessage { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestAssistantMessage? AssistantMessage { get; init; }
#else
        public global::G.ChatCompletionRequestAssistantMessage? AssistantMessage { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestToolMessage? ToolMessage { get; init; }
#else
        public global::G.ChatCompletionRequestToolMessage? ToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMessage))]
#endif
        public bool IsToolMessage => ToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestFunctionMessage? FunctionMessage { get; init; }
#else
        public global::G.ChatCompletionRequestFunctionMessage? FunctionMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionMessage))]
#endif
        public bool IsFunctionMessage => FunctionMessage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestDeveloperMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestDeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestDeveloperMessage?(ChatCompletionRequestMessage @this) => @this.DeveloperMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestDeveloperMessage? value)
        {
            DeveloperMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.ToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage? value)
        {
            ToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestFunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.FunctionMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage? value)
        {
            FunctionMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::G.ChatCompletionRequestSystemMessage? systemMessage,
            global::G.ChatCompletionRequestDeveloperMessage? developerMessage,
            global::G.ChatCompletionRequestUserMessage? userMessage,
            global::G.ChatCompletionRequestAssistantMessage? assistantMessage,
            global::G.ChatCompletionRequestToolMessage? toolMessage,
            global::G.ChatCompletionRequestFunctionMessage? functionMessage
            )
        {
            SystemMessage = systemMessage;
            DeveloperMessage = developerMessage;
            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            ToolMessage = toolMessage;
            FunctionMessage = functionMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionMessage as object ??
            ToolMessage as object ??
            AssistantMessage as object ??
            UserMessage as object ??
            DeveloperMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SystemMessage?.ToString() ??
            DeveloperMessage?.ToString() ??
            UserMessage?.ToString() ??
            AssistantMessage?.ToString() ??
            ToolMessage?.ToString() ??
            FunctionMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && IsAssistantMessage && !IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && IsToolMessage && !IsFunctionMessage || !IsSystemMessage && !IsDeveloperMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage && IsFunctionMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestSystemMessage?, TResult>? systemMessage = null,
            global::System.Func<global::G.ChatCompletionRequestDeveloperMessage?, TResult>? developerMessage = null,
            global::System.Func<global::G.ChatCompletionRequestUserMessage?, TResult>? userMessage = null,
            global::System.Func<global::G.ChatCompletionRequestAssistantMessage?, TResult>? assistantMessage = null,
            global::System.Func<global::G.ChatCompletionRequestToolMessage?, TResult>? toolMessage = null,
            global::System.Func<global::G.ChatCompletionRequestFunctionMessage?, TResult>? functionMessage = null,
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
            else if (IsDeveloperMessage && developerMessage != null)
            {
                return developerMessage(DeveloperMessage!);
            }
            else if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }
            else if (IsToolMessage && toolMessage != null)
            {
                return toolMessage(ToolMessage!);
            }
            else if (IsFunctionMessage && functionMessage != null)
            {
                return functionMessage(FunctionMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestSystemMessage?>? systemMessage = null,
            global::System.Action<global::G.ChatCompletionRequestDeveloperMessage?>? developerMessage = null,
            global::System.Action<global::G.ChatCompletionRequestUserMessage?>? userMessage = null,
            global::System.Action<global::G.ChatCompletionRequestAssistantMessage?>? assistantMessage = null,
            global::System.Action<global::G.ChatCompletionRequestToolMessage?>? toolMessage = null,
            global::System.Action<global::G.ChatCompletionRequestFunctionMessage?>? functionMessage = null,
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
            else if (IsDeveloperMessage)
            {
                developerMessage?.Invoke(DeveloperMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
            else if (IsToolMessage)
            {
                toolMessage?.Invoke(ToolMessage!);
            }
            else if (IsFunctionMessage)
            {
                functionMessage?.Invoke(FunctionMessage!);
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
                typeof(global::G.ChatCompletionRequestSystemMessage),
                DeveloperMessage,
                typeof(global::G.ChatCompletionRequestDeveloperMessage),
                UserMessage,
                typeof(global::G.ChatCompletionRequestUserMessage),
                AssistantMessage,
                typeof(global::G.ChatCompletionRequestAssistantMessage),
                ToolMessage,
                typeof(global::G.ChatCompletionRequestToolMessage),
                FunctionMessage,
                typeof(global::G.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(ChatCompletionRequestMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestSystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestDeveloperMessage?>.Default.Equals(DeveloperMessage, other.DeveloperMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestUserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestAssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestToolMessage?>.Default.Equals(ToolMessage, other.ToolMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestFunctionMessage?>.Default.Equals(FunctionMessage, other.FunctionMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessage o && Equals(o);
        }
    }
}
