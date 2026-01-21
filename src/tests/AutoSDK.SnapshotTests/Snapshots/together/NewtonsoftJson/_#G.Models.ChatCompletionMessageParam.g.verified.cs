//HintName: G.Models.ChatCompletionMessageParam.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionMessageParam : global::System.IEquatable<ChatCompletionMessageParam>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionSystemMessageParam? System { get; init; }
#else
        public global::G.ChatCompletionSystemMessageParam? System { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionUserMessageParam? User { get; init; }
#else
        public global::G.ChatCompletionUserMessageParam? User { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionAssistantMessageParam? Assistant { get; init; }
#else
        public global::G.ChatCompletionAssistantMessageParam? Assistant { get; }
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
        public global::G.ChatCompletionToolMessageParam? Tool { get; init; }
#else
        public global::G.ChatCompletionToolMessageParam? Tool { get; }
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
        public global::G.ChatCompletionFunctionMessageParam? Function { get; init; }
#else
        public global::G.ChatCompletionFunctionMessageParam? Function { get; }
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
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionSystemMessageParam value) => new ChatCompletionMessageParam((global::G.ChatCompletionSystemMessageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionSystemMessageParam?(ChatCompletionMessageParam @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionSystemMessageParam? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionUserMessageParam value) => new ChatCompletionMessageParam((global::G.ChatCompletionUserMessageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionUserMessageParam?(ChatCompletionMessageParam @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionUserMessageParam? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionAssistantMessageParam value) => new ChatCompletionMessageParam((global::G.ChatCompletionAssistantMessageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionAssistantMessageParam?(ChatCompletionMessageParam @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionAssistantMessageParam? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionToolMessageParam value) => new ChatCompletionMessageParam((global::G.ChatCompletionToolMessageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionToolMessageParam?(ChatCompletionMessageParam @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionToolMessageParam? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionFunctionMessageParam value) => new ChatCompletionMessageParam((global::G.ChatCompletionFunctionMessageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionFunctionMessageParam?(ChatCompletionMessageParam @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionFunctionMessageParam? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(
            global::G.ChatCompletionSystemMessageParam? system,
            global::G.ChatCompletionUserMessageParam? user,
            global::G.ChatCompletionAssistantMessageParam? assistant,
            global::G.ChatCompletionToolMessageParam? tool,
            global::G.ChatCompletionFunctionMessageParam? function
            )
        {
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
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
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
            return IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && !IsTool && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionSystemMessageParam?, TResult>? system = null,
            global::System.Func<global::G.ChatCompletionUserMessageParam?, TResult>? user = null,
            global::System.Func<global::G.ChatCompletionAssistantMessageParam?, TResult>? assistant = null,
            global::System.Func<global::G.ChatCompletionToolMessageParam?, TResult>? tool = null,
            global::System.Func<global::G.ChatCompletionFunctionMessageParam?, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
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
            global::System.Action<global::G.ChatCompletionSystemMessageParam?>? system = null,
            global::System.Action<global::G.ChatCompletionUserMessageParam?>? user = null,
            global::System.Action<global::G.ChatCompletionAssistantMessageParam?>? assistant = null,
            global::System.Action<global::G.ChatCompletionToolMessageParam?>? tool = null,
            global::System.Action<global::G.ChatCompletionFunctionMessageParam?>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
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
                System,
                typeof(global::G.ChatCompletionSystemMessageParam),
                User,
                typeof(global::G.ChatCompletionUserMessageParam),
                Assistant,
                typeof(global::G.ChatCompletionAssistantMessageParam),
                Tool,
                typeof(global::G.ChatCompletionToolMessageParam),
                Function,
                typeof(global::G.ChatCompletionFunctionMessageParam),
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
        public bool Equals(ChatCompletionMessageParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionSystemMessageParam?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionUserMessageParam?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionAssistantMessageParam?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionToolMessageParam?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionFunctionMessageParam?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageParam o && Equals(o);
        }
    }
}
