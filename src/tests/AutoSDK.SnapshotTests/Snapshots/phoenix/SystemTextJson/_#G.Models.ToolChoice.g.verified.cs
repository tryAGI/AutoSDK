//HintName: G.Models.ToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptToolsToolChoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptToolChoiceNone? None { get; init; }
#else
        public global::G.PromptToolChoiceNone? None { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptToolChoiceZeroOrMore? ZeroOrMore { get; init; }
#else
        public global::G.PromptToolChoiceZeroOrMore? ZeroOrMore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ZeroOrMore))]
#endif
        public bool IsZeroOrMore => ZeroOrMore != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptToolChoiceOneOrMore? OneOrMore { get; init; }
#else
        public global::G.PromptToolChoiceOneOrMore? OneOrMore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OneOrMore))]
#endif
        public bool IsOneOrMore => OneOrMore != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptToolChoiceSpecificFunctionTool? SpecificFunction { get; init; }
#else
        public global::G.PromptToolChoiceSpecificFunctionTool? SpecificFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecificFunction))]
#endif
        public bool IsSpecificFunction => SpecificFunction != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.PromptToolChoiceNone value) => new ToolChoice((global::G.PromptToolChoiceNone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptToolChoiceNone?(ToolChoice @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.PromptToolChoiceNone? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.PromptToolChoiceZeroOrMore value) => new ToolChoice((global::G.PromptToolChoiceZeroOrMore?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptToolChoiceZeroOrMore?(ToolChoice @this) => @this.ZeroOrMore;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.PromptToolChoiceZeroOrMore? value)
        {
            ZeroOrMore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.PromptToolChoiceOneOrMore value) => new ToolChoice((global::G.PromptToolChoiceOneOrMore?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptToolChoiceOneOrMore?(ToolChoice @this) => @this.OneOrMore;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.PromptToolChoiceOneOrMore? value)
        {
            OneOrMore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::G.PromptToolChoiceSpecificFunctionTool value) => new ToolChoice((global::G.PromptToolChoiceSpecificFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptToolChoiceSpecificFunctionTool?(ToolChoice @this) => @this.SpecificFunction;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::G.PromptToolChoiceSpecificFunctionTool? value)
        {
            SpecificFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::G.PromptToolsToolChoiceDiscriminatorType? type,
            global::G.PromptToolChoiceNone? none,
            global::G.PromptToolChoiceZeroOrMore? zeroOrMore,
            global::G.PromptToolChoiceOneOrMore? oneOrMore,
            global::G.PromptToolChoiceSpecificFunctionTool? specificFunction
            )
        {
            Type = type;

            None = none;
            ZeroOrMore = zeroOrMore;
            OneOrMore = oneOrMore;
            SpecificFunction = specificFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpecificFunction as object ??
            OneOrMore as object ??
            ZeroOrMore as object ??
            None as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            ZeroOrMore?.ToString() ??
            OneOrMore?.ToString() ??
            SpecificFunction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsZeroOrMore && !IsOneOrMore && !IsSpecificFunction || !IsNone && IsZeroOrMore && !IsOneOrMore && !IsSpecificFunction || !IsNone && !IsZeroOrMore && IsOneOrMore && !IsSpecificFunction || !IsNone && !IsZeroOrMore && !IsOneOrMore && IsSpecificFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptToolChoiceNone?, TResult>? none = null,
            global::System.Func<global::G.PromptToolChoiceZeroOrMore?, TResult>? zeroOrMore = null,
            global::System.Func<global::G.PromptToolChoiceOneOrMore?, TResult>? oneOrMore = null,
            global::System.Func<global::G.PromptToolChoiceSpecificFunctionTool?, TResult>? specificFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsZeroOrMore && zeroOrMore != null)
            {
                return zeroOrMore(ZeroOrMore!);
            }
            else if (IsOneOrMore && oneOrMore != null)
            {
                return oneOrMore(OneOrMore!);
            }
            else if (IsSpecificFunction && specificFunction != null)
            {
                return specificFunction(SpecificFunction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptToolChoiceNone?>? none = null,
            global::System.Action<global::G.PromptToolChoiceZeroOrMore?>? zeroOrMore = null,
            global::System.Action<global::G.PromptToolChoiceOneOrMore?>? oneOrMore = null,
            global::System.Action<global::G.PromptToolChoiceSpecificFunctionTool?>? specificFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsZeroOrMore)
            {
                zeroOrMore?.Invoke(ZeroOrMore!);
            }
            else if (IsOneOrMore)
            {
                oneOrMore?.Invoke(OneOrMore!);
            }
            else if (IsSpecificFunction)
            {
                specificFunction?.Invoke(SpecificFunction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::G.PromptToolChoiceNone),
                ZeroOrMore,
                typeof(global::G.PromptToolChoiceZeroOrMore),
                OneOrMore,
                typeof(global::G.PromptToolChoiceOneOrMore),
                SpecificFunction,
                typeof(global::G.PromptToolChoiceSpecificFunctionTool),
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
                global::System.Collections.Generic.EqualityComparer<global::G.PromptToolChoiceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptToolChoiceZeroOrMore?>.Default.Equals(ZeroOrMore, other.ZeroOrMore) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptToolChoiceOneOrMore?>.Default.Equals(OneOrMore, other.OneOrMore) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptToolChoiceSpecificFunctionTool?>.Default.Equals(SpecificFunction, other.SpecificFunction) 
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
