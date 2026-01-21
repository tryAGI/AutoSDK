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
        /// Developer-provided instructions that the model should follow, regardless of<br/>
        /// messages sent by the user. With o1 models and newer, `developer` messages<br/>
        /// replace the previous `system` messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestDeveloperMessage? Developer { get; init; }
#else
        public global::G.ChatCompletionRequestDeveloperMessage? Developer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;

        /// <summary>
        /// Developer-provided instructions that the model should follow, regardless of<br/>
        /// messages sent by the user. With o1 models and newer, use `developer` messages<br/>
        /// for this purpose instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestSystemMessage? System { get; init; }
#else
        public global::G.ChatCompletionRequestSystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// Messages sent by an end user, containing prompts or additional context<br/>
        /// information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestUserMessage? User { get; init; }
#else
        public global::G.ChatCompletionRequestUserMessage? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// Messages sent by the model in response to user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestAssistantMessage? Assistant { get; init; }
#else
        public global::G.ChatCompletionRequestAssistantMessage? Assistant { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestToolMessage? Tool { get; init; }
#else
        public global::G.ChatCompletionRequestToolMessage? Tool { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestFunctionMessage? Function { get; init; }
#else
        public global::G.ChatCompletionRequestFunctionMessage? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestDeveloperMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestDeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestDeveloperMessage?(ChatCompletionRequestMessage @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestDeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage((global::G.ChatCompletionRequestFunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::G.ChatCompletionRequestFunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::G.ChatCompletionRequestDeveloperMessage? developer,
            global::G.ChatCompletionRequestSystemMessage? system,
            global::G.ChatCompletionRequestUserMessage? user,
            global::G.ChatCompletionRequestAssistantMessage? assistant,
            global::G.ChatCompletionRequestToolMessage? tool,
            global::G.ChatCompletionRequestFunctionMessage? function
            )
        {
            Developer = developer;
            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object ??
            Developer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Developer?.ToString() ??
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString() ??
            Function?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeveloper && !IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && !IsAssistant && IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && !IsAssistant && !IsTool && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestDeveloperMessage?, TResult>? developer = null,
            global::System.Func<global::G.ChatCompletionRequestSystemMessage?, TResult>? system = null,
            global::System.Func<global::G.ChatCompletionRequestUserMessage?, TResult>? user = null,
            global::System.Func<global::G.ChatCompletionRequestAssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::G.ChatCompletionRequestToolMessage?, TResult>? tool = null,
            global::System.Func<global::G.ChatCompletionRequestFunctionMessage?, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestDeveloperMessage?>? developer = null,
            global::System.Action<global::G.ChatCompletionRequestSystemMessage?>? system = null,
            global::System.Action<global::G.ChatCompletionRequestUserMessage?>? user = null,
            global::System.Action<global::G.ChatCompletionRequestAssistantMessage?>? assistant = null,
            global::System.Action<global::G.ChatCompletionRequestToolMessage?>? tool = null,
            global::System.Action<global::G.ChatCompletionRequestFunctionMessage?>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Developer,
                typeof(global::G.ChatCompletionRequestDeveloperMessage),
                System,
                typeof(global::G.ChatCompletionRequestSystemMessage),
                User,
                typeof(global::G.ChatCompletionRequestUserMessage),
                Assistant,
                typeof(global::G.ChatCompletionRequestAssistantMessage),
                Tool,
                typeof(global::G.ChatCompletionRequestToolMessage),
                Function,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestDeveloperMessage?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestAssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestFunctionMessage?>.Default.Equals(Function, other.Function) 
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
