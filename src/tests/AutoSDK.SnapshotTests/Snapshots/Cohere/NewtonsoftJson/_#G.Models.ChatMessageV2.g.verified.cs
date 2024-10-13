//HintName: G.Models.ChatMessageV2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single message in the chat history from a given role.
    /// </summary>
    public readonly partial struct ChatMessageV2 : global::System.IEquatable<ChatMessageV2>
    {
        /// <summary>
        /// A message from the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserMessage? User { get; init; }
#else
        public global::G.UserMessage? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::G.UserMessage value) => new ChatMessageV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserMessage?(ChatMessageV2 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::G.UserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// A message from the assistant role can contain text and tool call information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantMessage? Assistant { get; init; }
#else
        public global::G.AssistantMessage? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::G.AssistantMessage value) => new ChatMessageV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantMessage?(ChatMessageV2 @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::G.AssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// A message from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemMessage? System { get; init; }
#else
        public global::G.SystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::G.SystemMessage value) => new ChatMessageV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemMessage?(ChatMessageV2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::G.SystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// A message from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolMessageV2? Tool { get; init; }
#else
        public global::G.ToolMessageV2? Tool { get; }
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
        public static implicit operator ChatMessageV2(global::G.ToolMessageV2 value) => new ChatMessageV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolMessageV2?(ChatMessageV2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::G.ToolMessageV2? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(
            global::G.UserMessage? user,
            global::G.AssistantMessage? assistant,
            global::G.SystemMessage? system,
            global::G.ToolMessageV2? tool
            )
        {
            User = user;
            Assistant = assistant;
            System = system;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            System as object ??
            Assistant as object ??
            User as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsAssistant && !IsSystem && !IsTool || !IsUser && IsAssistant && !IsSystem && !IsTool || !IsUser && !IsAssistant && IsSystem && !IsTool || !IsUser && !IsAssistant && !IsSystem && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UserMessage?, TResult>? user = null,
            global::System.Func<global::G.AssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::G.SystemMessage?, TResult>? system = null,
            global::System.Func<global::G.ToolMessageV2?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UserMessage?>? user = null,
            global::System.Action<global::G.AssistantMessage?>? assistant = null,
            global::System.Action<global::G.SystemMessage?>? system = null,
            global::System.Action<global::G.ToolMessageV2?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::G.UserMessage),
                Assistant,
                typeof(global::G.AssistantMessage),
                System,
                typeof(global::G.SystemMessage),
                Tool,
                typeof(global::G.ToolMessageV2),
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
        public bool Equals(ChatMessageV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolMessageV2?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageV2 obj1, ChatMessageV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageV2 obj1, ChatMessageV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageV2 o && Equals(o);
        }


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChatMessageV2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChatMessageV2>(
                json,
                jsonSerializerOptions);
        }

    }
}
