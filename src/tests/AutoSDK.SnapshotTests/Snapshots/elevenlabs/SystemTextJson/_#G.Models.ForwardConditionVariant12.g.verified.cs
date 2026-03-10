//HintName: G.Models.ForwardConditionVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ForwardConditionVariant12 : global::System.IEquatable<ForwardConditionVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Condition that is always true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowUnconditionalModelOutput? Unconditional { get; init; }
#else
        public global::G.WorkflowUnconditionalModelOutput? Unconditional { get; }
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
        public global::G.WorkflowLLMConditionModelOutput? Llm { get; init; }
#else
        public global::G.WorkflowLLMConditionModelOutput? Llm { get; }
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
        public global::G.WorkflowResultConditionModelOutput? Result { get; init; }
#else
        public global::G.WorkflowResultConditionModelOutput? Result { get; }
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
        public global::G.WorkflowExpressionConditionModelOutput? Expression { get; init; }
#else
        public global::G.WorkflowExpressionConditionModelOutput? Expression { get; }
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
        public static implicit operator ForwardConditionVariant12(global::G.WorkflowUnconditionalModelOutput value) => new ForwardConditionVariant12((global::G.WorkflowUnconditionalModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowUnconditionalModelOutput?(ForwardConditionVariant12 @this) => @this.Unconditional;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant12(global::G.WorkflowUnconditionalModelOutput? value)
        {
            Unconditional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant12(global::G.WorkflowLLMConditionModelOutput value) => new ForwardConditionVariant12((global::G.WorkflowLLMConditionModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowLLMConditionModelOutput?(ForwardConditionVariant12 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant12(global::G.WorkflowLLMConditionModelOutput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant12(global::G.WorkflowResultConditionModelOutput value) => new ForwardConditionVariant12((global::G.WorkflowResultConditionModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowResultConditionModelOutput?(ForwardConditionVariant12 @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant12(global::G.WorkflowResultConditionModelOutput? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ForwardConditionVariant12(global::G.WorkflowExpressionConditionModelOutput value) => new ForwardConditionVariant12((global::G.WorkflowExpressionConditionModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowExpressionConditionModelOutput?(ForwardConditionVariant12 @this) => @this.Expression;

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant12(global::G.WorkflowExpressionConditionModelOutput? value)
        {
            Expression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ForwardConditionVariant12(
            global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? type,
            global::G.WorkflowUnconditionalModelOutput? unconditional,
            global::G.WorkflowLLMConditionModelOutput? llm,
            global::G.WorkflowResultConditionModelOutput? result,
            global::G.WorkflowExpressionConditionModelOutput? expression
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
            global::System.Func<global::G.WorkflowUnconditionalModelOutput?, TResult>? unconditional = null,
            global::System.Func<global::G.WorkflowLLMConditionModelOutput?, TResult>? llm = null,
            global::System.Func<global::G.WorkflowResultConditionModelOutput?, TResult>? result = null,
            global::System.Func<global::G.WorkflowExpressionConditionModelOutput?, TResult>? expression = null,
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
            global::System.Action<global::G.WorkflowUnconditionalModelOutput?>? unconditional = null,
            global::System.Action<global::G.WorkflowLLMConditionModelOutput?>? llm = null,
            global::System.Action<global::G.WorkflowResultConditionModelOutput?>? result = null,
            global::System.Action<global::G.WorkflowExpressionConditionModelOutput?>? expression = null,
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
                typeof(global::G.WorkflowUnconditionalModelOutput),
                Llm,
                typeof(global::G.WorkflowLLMConditionModelOutput),
                Result,
                typeof(global::G.WorkflowResultConditionModelOutput),
                Expression,
                typeof(global::G.WorkflowExpressionConditionModelOutput),
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
        public bool Equals(ForwardConditionVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowUnconditionalModelOutput?>.Default.Equals(Unconditional, other.Unconditional) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowLLMConditionModelOutput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowResultConditionModelOutput?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowExpressionConditionModelOutput?>.Default.Equals(Expression, other.Expression) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ForwardConditionVariant12 obj1, ForwardConditionVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ForwardConditionVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ForwardConditionVariant12 obj1, ForwardConditionVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ForwardConditionVariant12 o && Equals(o);
        }
    }
}
