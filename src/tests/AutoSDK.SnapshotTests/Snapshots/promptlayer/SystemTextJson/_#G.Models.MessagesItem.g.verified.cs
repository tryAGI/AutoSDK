//HintName: G.Models.MessagesItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesItem : global::System.IEquatable<MessagesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatPromptMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
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
#if NET6_0_OR_GREATER
        public global::G.FunctionMessage? Function { get; init; }
#else
        public global::G.FunctionMessage? Function { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ToolMessage? Tool { get; init; }
#else
        public global::G.ToolMessage? Tool { get; }
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
        public global::G.PlaceholderMessage? Placeholder { get; init; }
#else
        public global::G.PlaceholderMessage? Placeholder { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Placeholder))]
#endif
        public bool IsPlaceholder => Placeholder != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeveloperMessage? Developer { get; init; }
#else
        public global::G.DeveloperMessage? Developer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.SystemMessage value) => new MessagesItem((global::G.SystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemMessage?(MessagesItem @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.SystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.UserMessage value) => new MessagesItem((global::G.UserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserMessage?(MessagesItem @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.UserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.AssistantMessage value) => new MessagesItem((global::G.AssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantMessage?(MessagesItem @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.AssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.FunctionMessage value) => new MessagesItem((global::G.FunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionMessage?(MessagesItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.FunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.ToolMessage value) => new MessagesItem((global::G.ToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolMessage?(MessagesItem @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.PlaceholderMessage value) => new MessagesItem((global::G.PlaceholderMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlaceholderMessage?(MessagesItem @this) => @this.Placeholder;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.PlaceholderMessage? value)
        {
            Placeholder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::G.DeveloperMessage value) => new MessagesItem((global::G.DeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeveloperMessage?(MessagesItem @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::G.DeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(
            global::G.ChatPromptMessageDiscriminatorRole? role,
            global::G.SystemMessage? system,
            global::G.UserMessage? user,
            global::G.AssistantMessage? assistant,
            global::G.FunctionMessage? function,
            global::G.ToolMessage? tool,
            global::G.PlaceholderMessage? placeholder,
            global::G.DeveloperMessage? developer
            )
        {
            Role = role;

            System = system;
            User = user;
            Assistant = assistant;
            Function = function;
            Tool = tool;
            Placeholder = placeholder;
            Developer = developer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Developer as object ??
            Placeholder as object ??
            Tool as object ??
            Function as object ??
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
            Function?.ToString() ??
            Tool?.ToString() ??
            Placeholder?.ToString() ??
            Developer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && IsDeveloper;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SystemMessage?, TResult>? system = null,
            global::System.Func<global::G.UserMessage?, TResult>? user = null,
            global::System.Func<global::G.AssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::G.FunctionMessage?, TResult>? function = null,
            global::System.Func<global::G.ToolMessage?, TResult>? tool = null,
            global::System.Func<global::G.PlaceholderMessage?, TResult>? placeholder = null,
            global::System.Func<global::G.DeveloperMessage?, TResult>? developer = null,
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
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsPlaceholder && placeholder != null)
            {
                return placeholder(Placeholder!);
            }
            else if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SystemMessage?>? system = null,
            global::System.Action<global::G.UserMessage?>? user = null,
            global::System.Action<global::G.AssistantMessage?>? assistant = null,
            global::System.Action<global::G.FunctionMessage?>? function = null,
            global::System.Action<global::G.ToolMessage?>? tool = null,
            global::System.Action<global::G.PlaceholderMessage?>? placeholder = null,
            global::System.Action<global::G.DeveloperMessage?>? developer = null,
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
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsPlaceholder)
            {
                placeholder?.Invoke(Placeholder!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
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
                typeof(global::G.SystemMessage),
                User,
                typeof(global::G.UserMessage),
                Assistant,
                typeof(global::G.AssistantMessage),
                Function,
                typeof(global::G.FunctionMessage),
                Tool,
                typeof(global::G.ToolMessage),
                Placeholder,
                typeof(global::G.PlaceholderMessage),
                Developer,
                typeof(global::G.DeveloperMessage),
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
        public bool Equals(MessagesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionMessage?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlaceholderMessage?>.Default.Equals(Placeholder, other.Placeholder) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeveloperMessage?>.Default.Equals(Developer, other.Developer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesItem obj1, MessagesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesItem obj1, MessagesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesItem o && Equals(o);
        }
    }
}
