//HintName: G.Models.BetaToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
    /// </summary>
    public readonly partial struct BetaToolChoice : global::System.IEquatable<BetaToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaToolChoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// The model will automatically decide whether to use tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaToolChoiceAuto? Auto { get; init; }
#else
        public global::G.BetaToolChoiceAuto? Auto { get; }
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
        public static implicit operator BetaToolChoice(global::G.BetaToolChoiceAuto value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaToolChoiceAuto?(BetaToolChoice @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::G.BetaToolChoiceAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        /// The model will use any available tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaToolChoiceAny? Any { get; init; }
#else
        public global::G.BetaToolChoiceAny? Any { get; }
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
        public static implicit operator BetaToolChoice(global::G.BetaToolChoiceAny value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaToolChoiceAny?(BetaToolChoice @this) => @this.Any;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::G.BetaToolChoiceAny? value)
        {
            Any = value;
        }

        /// <summary>
        /// The model will use the specified tool with `tool_choice.name`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaToolChoiceTool? Tool { get; init; }
#else
        public global::G.BetaToolChoiceTool? Tool { get; }
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
        public static implicit operator BetaToolChoice(global::G.BetaToolChoiceTool value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaToolChoiceTool?(BetaToolChoice @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::G.BetaToolChoiceTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(
            global::G.BetaToolChoiceDiscriminatorType? type,
            global::G.BetaToolChoiceAuto? auto,
            global::G.BetaToolChoiceAny? any,
            global::G.BetaToolChoiceTool? tool
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
        public bool Validate()
        {
            return IsAuto && !IsAny && !IsTool || !IsAuto && IsAny && !IsTool || !IsAuto && !IsAny && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaToolChoiceAuto?, TResult>? auto = null,
            global::System.Func<global::G.BetaToolChoiceAny?, TResult>? any = null,
            global::System.Func<global::G.BetaToolChoiceTool?, TResult>? tool = null,
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
            global::System.Action<global::G.BetaToolChoiceAuto?>? auto = null,
            global::System.Action<global::G.BetaToolChoiceAny?>? any = null,
            global::System.Action<global::G.BetaToolChoiceTool?>? tool = null,
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
                typeof(global::G.BetaToolChoiceAuto),
                Any,
                typeof(global::G.BetaToolChoiceAny),
                Tool,
                typeof(global::G.BetaToolChoiceTool),
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
        public bool Equals(BetaToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaToolChoiceAuto?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaToolChoiceAny?>.Default.Equals(Any, other.Any) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaToolChoiceTool?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaToolChoice obj1, BetaToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaToolChoice obj1, BetaToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolChoice o && Equals(o);
        }
    }
}
