//HintName: G.Models.ToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// The model will automatically decide whether to use tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolChoiceAuto? Auto { get; init; }
#else
        public global::G.ToolChoiceAuto? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.ToolChoiceAuto value) => new ToolChoice((global::G.ToolChoiceAuto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolChoiceAuto?(ToolChoice @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.ToolChoiceAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        /// The model will use any available tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolChoiceAny? Any { get; init; }
#else
        public global::G.ToolChoiceAny? Any { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Any))]
#endif
        public bool IsAny => Any != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.ToolChoiceAny value) => new ToolChoice((global::G.ToolChoiceAny?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolChoiceAny?(ToolChoice @this) => @this.Any;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.ToolChoiceAny? value)
        {
            Any = value;
        }

        /// <summary>
        /// The model will use the specified tool with `tool_choice.name`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolChoiceTool? Tool { get; init; }
#else
        public global::G.ToolChoiceTool? Tool { get; }
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
        public static implicit operator ToolChoice(global::G.ToolChoiceTool value) => new ToolChoice((global::G.ToolChoiceTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolChoiceTool?(ToolChoice @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.ToolChoiceTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::G.ToolChoiceDiscriminatorType? type,
            global::G.ToolChoiceAuto? auto,
            global::G.ToolChoiceAny? any,
            global::G.ToolChoiceTool? tool
            )
        {
            Type = type;

            Auto = auto;
            Any = any;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Any as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Auto?.ToString() ??
            Any?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsAny && !IsTool || !IsAuto && IsAny && !IsTool || !IsAuto && !IsAny && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolChoiceAuto?, TResult>? auto = null,
            global::System.Func<global::G.ToolChoiceAny?, TResult>? any = null,
            global::System.Func<global::G.ToolChoiceTool?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }
            else if (IsAny && any != null)
            {
                return any(Any!);
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
            global::System.Action<global::G.ToolChoiceAuto?>? auto = null,
            global::System.Action<global::G.ToolChoiceAny?>? any = null,
            global::System.Action<global::G.ToolChoiceTool?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
            else if (IsAny)
            {
                any?.Invoke(Any!);
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
                Auto,
                typeof(global::G.ToolChoiceAuto),
                Any,
                typeof(global::G.ToolChoiceAny),
                Tool,
                typeof(global::G.ToolChoiceTool),
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
        public bool Equals(ToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolChoiceAuto?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolChoiceAny?>.Default.Equals(Any, other.Any) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolChoiceTool?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice obj1, ToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice obj1, ToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice o && Equals(o);
        }
    }
}
