//HintName: G.Models.ChatMessage2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single message in the chat history from a given role.
    /// </summary>
    public readonly partial struct ChatMessage2 : global::System.IEquatable<ChatMessage2>
    {
        /// <summary>
        /// A message from the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserMessage? UserMessage { get; init; }
#else
        public global::G.UserMessage? UserMessage { get; }
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
        public static implicit operator ChatMessage2(global::G.UserMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserMessage?(ChatMessage2 @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::G.UserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// A message from the assistant role can contain text and tool call information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantMessage? AssistantMessage { get; init; }
#else
        public global::G.AssistantMessage? AssistantMessage { get; }
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
        public static implicit operator ChatMessage2(global::G.AssistantMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantMessage?(ChatMessage2 @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::G.AssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// A message from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemMessage? SystemMessage { get; init; }
#else
        public global::G.SystemMessage? SystemMessage { get; }
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
        public static implicit operator ChatMessage2(global::G.SystemMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemMessage?(ChatMessage2 @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::G.SystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// A message from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolMessage2? Tool { get; init; }
#else
        public global::G.ToolMessage2? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessage2(global::G.ToolMessage2 value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolMessage2?(ChatMessage2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::G.ToolMessage2? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(
            global::G.UserMessage? userMessage,
            global::G.AssistantMessage? assistantMessage,
            global::G.SystemMessage? systemMessage,
            global::G.ToolMessage2? tool
            )
        {
            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            SystemMessage = systemMessage;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            SystemMessage as object ??
            AssistantMessage as object ??
            UserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsAssistantMessage && !IsSystemMessage && !IsTool || !IsUserMessage && IsAssistantMessage && !IsSystemMessage && !IsTool || !IsUserMessage && !IsAssistantMessage && IsSystemMessage && !IsTool || !IsUserMessage && !IsAssistantMessage && !IsSystemMessage && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessage,
                typeof(global::G.UserMessage),
                AssistantMessage,
                typeof(global::G.AssistantMessage),
                SystemMessage,
                typeof(global::G.SystemMessage),
                Tool,
                typeof(global::G.ToolMessage2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatMessage2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolMessage2?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessage2 obj1, ChatMessage2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessage2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessage2 obj1, ChatMessage2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessage2 o && Equals(o);
        }
    }
}
