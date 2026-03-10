//HintName: G.Models.ForwardConditionVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ForwardConditionVariant1 : global::System.IEquatable<ForwardConditionVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Condition that is always true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowUnconditionalModelInput? Unconditional { get; init; }
#else
        public global::G.WorkflowUnconditionalModelInput? Unconditional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unconditional))]
#endif
        public bool IsUnconditional => Unconditional != null;

        /// <summary>
        /// Condition described using human language and evaluated by an LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowLLMConditionModelInput? Llm { get; init; }
#else
        public global::G.WorkflowLLMConditionModelInput? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// Condition based on the result of the last executed tool dispatch node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowResultConditionModelInput? Result { get; init; }
#else
        public global::G.WorkflowResultConditionModelInput? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// Condition described using a deterministic expression.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowExpressionConditionModelInput? Expression { get; init; }
#else
        public global::G.WorkflowExpressionConditionModelInput? Expression { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Expression))]
#endif
        public bool IsExpression => Expression != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant1(global::G.WorkflowUnconditionalModelInput value) => new ForwardConditionVariant1((global::G.WorkflowUnconditionalModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowUnconditionalModelInput?(ForwardConditionVariant1 @this) => @this.Unconditional;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant1(global::G.WorkflowUnconditionalModelInput? value)
        {
            Unconditional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant1(global::G.WorkflowLLMConditionModelInput value) => new ForwardConditionVariant1((global::G.WorkflowLLMConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowLLMConditionModelInput?(ForwardConditionVariant1 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant1(global::G.WorkflowLLMConditionModelInput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant1(global::G.WorkflowResultConditionModelInput value) => new ForwardConditionVariant1((global::G.WorkflowResultConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowResultConditionModelInput?(ForwardConditionVariant1 @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant1(global::G.WorkflowResultConditionModelInput? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant1(global::G.WorkflowExpressionConditionModelInput value) => new ForwardConditionVariant1((global::G.WorkflowExpressionConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowExpressionConditionModelInput?(ForwardConditionVariant1 @this) => @this.Expression;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant1(global::G.WorkflowExpressionConditionModelInput? value)
        {
            Expression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant1(
            global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? type,
            global::G.WorkflowUnconditionalModelInput? unconditional,
            global::G.WorkflowLLMConditionModelInput? llm,
            global::G.WorkflowResultConditionModelInput? result,
            global::G.WorkflowExpressionConditionModelInput? expression
            )
        {
            Type = type;

            Unconditional = unconditional;
            Llm = llm;
            Result = result;
            Expression = expression;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Expression as object ??
            Result as object ??
            Llm as object ??
            Unconditional as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Unconditional?.ToString() ??
            Llm?.ToString() ??
            Result?.ToString() ??
            Expression?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnconditional && !IsLlm && !IsResult && !IsExpression || !IsUnconditional && IsLlm && !IsResult && !IsExpression || !IsUnconditional && !IsLlm && IsResult && !IsExpression || !IsUnconditional && !IsLlm && !IsResult && IsExpression;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WorkflowUnconditionalModelInput?, TResult>? unconditional = null,
            global::System.Func<global::G.WorkflowLLMConditionModelInput?, TResult>? llm = null,
            global::System.Func<global::G.WorkflowResultConditionModelInput?, TResult>? result = null,
            global::System.Func<global::G.WorkflowExpressionConditionModelInput?, TResult>? expression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnconditional && unconditional != null)
            {
                return unconditional(Unconditional!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsExpression && expression != null)
            {
                return expression(Expression!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WorkflowUnconditionalModelInput?>? unconditional = null,
            global::System.Action<global::G.WorkflowLLMConditionModelInput?>? llm = null,
            global::System.Action<global::G.WorkflowResultConditionModelInput?>? result = null,
            global::System.Action<global::G.WorkflowExpressionConditionModelInput?>? expression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnconditional)
            {
                unconditional?.Invoke(Unconditional!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsExpression)
            {
                expression?.Invoke(Expression!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Unconditional,
                typeof(global::G.WorkflowUnconditionalModelInput),
                Llm,
                typeof(global::G.WorkflowLLMConditionModelInput),
                Result,
                typeof(global::G.WorkflowResultConditionModelInput),
                Expression,
                typeof(global::G.WorkflowExpressionConditionModelInput),
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
        public bool Equals(ForwardConditionVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowUnconditionalModelInput?>.Default.Equals(Unconditional, other.Unconditional) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowLLMConditionModelInput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowResultConditionModelInput?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowExpressionConditionModelInput?>.Default.Equals(Expression, other.Expression) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ForwardConditionVariant1 obj1, ForwardConditionVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ForwardConditionVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ForwardConditionVariant1 obj1, ForwardConditionVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ForwardConditionVariant1 o && Equals(o);
        }
    }
}
