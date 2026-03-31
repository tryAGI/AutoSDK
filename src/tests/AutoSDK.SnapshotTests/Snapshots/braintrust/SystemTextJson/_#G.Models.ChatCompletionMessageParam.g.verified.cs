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
        public global::G.ChatCompletionMessageParamSystem? System { get; init; }
#else
        public global::G.ChatCompletionMessageParamSystem? System { get; }
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
        public global::G.ChatCompletionMessageParamUser? User { get; init; }
#else
        public global::G.ChatCompletionMessageParamUser? User { get; }
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
        public global::G.ChatCompletionMessageParamAssistant? Assistant { get; init; }
#else
        public global::G.ChatCompletionMessageParamAssistant? Assistant { get; }
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
        public global::G.ChatCompletionMessageParamTool? Tool { get; init; }
#else
        public global::G.ChatCompletionMessageParamTool? Tool { get; }
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
        public global::G.ChatCompletionMessageParamFunction? Function { get; init; }
#else
        public global::G.ChatCompletionMessageParamFunction? Function { get; }
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
        public global::G.ChatCompletionMessageParamDeveloper? Developer { get; init; }
#else
        public global::G.ChatCompletionMessageParamDeveloper? Developer { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionMessageParamFallback? Fallback { get; init; }
#else
        public global::G.ChatCompletionMessageParamFallback? Fallback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fallback))]
#endif
        public bool IsFallback => Fallback != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamSystem value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamSystem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamSystem?(ChatCompletionMessageParam @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamSystem? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamUser value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamUser?(ChatCompletionMessageParam @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamUser? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamAssistant value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamAssistant?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamAssistant?(ChatCompletionMessageParam @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamAssistant? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamTool value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamTool?(ChatCompletionMessageParam @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamFunction value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamFunction?(ChatCompletionMessageParam @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamDeveloper value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamDeveloper?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamDeveloper?(ChatCompletionMessageParam @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamDeveloper? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::G.ChatCompletionMessageParamFallback value) => new ChatCompletionMessageParam((global::G.ChatCompletionMessageParamFallback?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionMessageParamFallback?(ChatCompletionMessageParam @this) => @this.Fallback;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::G.ChatCompletionMessageParamFallback? value)
        {
            Fallback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(
            global::G.ChatCompletionMessageParamSystem? system,
            global::G.ChatCompletionMessageParamUser? user,
            global::G.ChatCompletionMessageParamAssistant? assistant,
            global::G.ChatCompletionMessageParamTool? tool,
            global::G.ChatCompletionMessageParamFunction? function,
            global::G.ChatCompletionMessageParamDeveloper? developer,
            global::G.ChatCompletionMessageParamFallback? fallback
            )
        {
            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
            Developer = developer;
            Fallback = fallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fallback as object ??
            Developer as object ??
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
            Function?.ToString() ??
            Developer?.ToString() ??
            Fallback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem || IsUser || IsAssistant || IsTool || IsFunction || IsDeveloper || IsFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionMessageParamSystem?, TResult>? system = null,
            global::System.Func<global::G.ChatCompletionMessageParamUser?, TResult>? user = null,
            global::System.Func<global::G.ChatCompletionMessageParamAssistant?, TResult>? assistant = null,
            global::System.Func<global::G.ChatCompletionMessageParamTool?, TResult>? tool = null,
            global::System.Func<global::G.ChatCompletionMessageParamFunction?, TResult>? function = null,
            global::System.Func<global::G.ChatCompletionMessageParamDeveloper?, TResult>? developer = null,
            global::System.Func<global::G.ChatCompletionMessageParamFallback?, TResult>? fallback = null,
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
            else if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }
            else if (IsFallback && fallback != null)
            {
                return fallback(Fallback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionMessageParamSystem?>? system = null,
            global::System.Action<global::G.ChatCompletionMessageParamUser?>? user = null,
            global::System.Action<global::G.ChatCompletionMessageParamAssistant?>? assistant = null,
            global::System.Action<global::G.ChatCompletionMessageParamTool?>? tool = null,
            global::System.Action<global::G.ChatCompletionMessageParamFunction?>? function = null,
            global::System.Action<global::G.ChatCompletionMessageParamDeveloper?>? developer = null,
            global::System.Action<global::G.ChatCompletionMessageParamFallback?>? fallback = null,
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
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsFallback)
            {
                fallback?.Invoke(Fallback!);
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
                typeof(global::G.ChatCompletionMessageParamSystem),
                User,
                typeof(global::G.ChatCompletionMessageParamUser),
                Assistant,
                typeof(global::G.ChatCompletionMessageParamAssistant),
                Tool,
                typeof(global::G.ChatCompletionMessageParamTool),
                Function,
                typeof(global::G.ChatCompletionMessageParamFunction),
                Developer,
                typeof(global::G.ChatCompletionMessageParamDeveloper),
                Fallback,
                typeof(global::G.ChatCompletionMessageParamFallback),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamSystem?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamUser?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamAssistant?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamTool?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamDeveloper?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionMessageParamFallback?>.Default.Equals(Fallback, other.Fallback) 
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
