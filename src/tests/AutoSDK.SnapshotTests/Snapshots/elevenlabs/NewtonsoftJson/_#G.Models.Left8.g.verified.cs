//HintName: G.Models.Left8.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Left operand of the binary operator.
    /// </summary>
    public readonly partial struct Left8 : global::System.IEquatable<Left8>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ASTLessThanOperatorNodeOutputLeftDiscriminatorType? Type { get; }

        /// <summary>
        /// String literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTStringNodeOutput? StringLiteral { get; init; }
#else
        public global::G.ASTStringNodeOutput? StringLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringLiteral))]
#endif
        public bool IsStringLiteral => StringLiteral != null;

        /// <summary>
        /// Number literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTNumberNodeOutput? NumberLiteral { get; init; }
#else
        public global::G.ASTNumberNodeOutput? NumberLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberLiteral))]
#endif
        public bool IsNumberLiteral => NumberLiteral != null;

        /// <summary>
        /// Boolean literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTBooleanNodeOutput? BooleanLiteral { get; init; }
#else
        public global::G.ASTBooleanNodeOutput? BooleanLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanLiteral))]
#endif
        public bool IsBooleanLiteral => BooleanLiteral != null;

        /// <summary>
        /// Prompt evaluated by an LLM to a boolean value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTLLMNodeOutput? Llm { get; init; }
#else
        public global::G.ASTLLMNodeOutput? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// Reference to a dynamic variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTDynamicVariableNodeOutput? DynamicVariable { get; init; }
#else
        public global::G.ASTDynamicVariableNodeOutput? DynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariable))]
#endif
        public bool IsDynamicVariable => DynamicVariable != null;

        /// <summary>
        /// Evaluates to true if any child is true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTOrOperatorNodeOutput? OrOperator { get; init; }
#else
        public global::G.ASTOrOperatorNodeOutput? OrOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrOperator))]
#endif
        public bool IsOrOperator => OrOperator != null;

        /// <summary>
        /// Evaluates to true if all children are true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTAndOperatorNodeOutput? AndOperator { get; init; }
#else
        public global::G.ASTAndOperatorNodeOutput? AndOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AndOperator))]
#endif
        public bool IsAndOperator => AndOperator != null;

        /// <summary>
        /// Evaluates to true if the left value equals the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTEqualsOperatorNodeOutput? EqOperator { get; init; }
#else
        public global::G.ASTEqualsOperatorNodeOutput? EqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EqOperator))]
#endif
        public bool IsEqOperator => EqOperator != null;

        /// <summary>
        /// Evaluates to true if the left value does not equal the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTNotEqualsOperatorNodeOutput? NeqOperator { get; init; }
#else
        public global::G.ASTNotEqualsOperatorNodeOutput? NeqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NeqOperator))]
#endif
        public bool IsNeqOperator => NeqOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is greater than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTGreaterThanOperatorNodeOutput? GtOperator { get; init; }
#else
        public global::G.ASTGreaterThanOperatorNodeOutput? GtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GtOperator))]
#endif
        public bool IsGtOperator => GtOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is less than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTLessThanOperatorNodeOutput? LtOperator { get; init; }
#else
        public global::G.ASTLessThanOperatorNodeOutput? LtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LtOperator))]
#endif
        public bool IsLtOperator => LtOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is greater than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? GteOperator { get; init; }
#else
        public global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? GteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GteOperator))]
#endif
        public bool IsGteOperator => GteOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is less than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTLessThanOrEqualsOperatorNodeOutput? LteOperator { get; init; }
#else
        public global::G.ASTLessThanOrEqualsOperatorNodeOutput? LteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LteOperator))]
#endif
        public bool IsLteOperator => LteOperator != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTStringNodeOutput value) => new Left8((global::G.ASTStringNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTStringNodeOutput?(Left8 @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTStringNodeOutput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTNumberNodeOutput value) => new Left8((global::G.ASTNumberNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTNumberNodeOutput?(Left8 @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTNumberNodeOutput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTBooleanNodeOutput value) => new Left8((global::G.ASTBooleanNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTBooleanNodeOutput?(Left8 @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTBooleanNodeOutput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTLLMNodeOutput value) => new Left8((global::G.ASTLLMNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLLMNodeOutput?(Left8 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTLLMNodeOutput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTDynamicVariableNodeOutput value) => new Left8((global::G.ASTDynamicVariableNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTDynamicVariableNodeOutput?(Left8 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTDynamicVariableNodeOutput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTOrOperatorNodeOutput value) => new Left8((global::G.ASTOrOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTOrOperatorNodeOutput?(Left8 @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTOrOperatorNodeOutput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTAndOperatorNodeOutput value) => new Left8((global::G.ASTAndOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTAndOperatorNodeOutput?(Left8 @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTAndOperatorNodeOutput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTEqualsOperatorNodeOutput value) => new Left8((global::G.ASTEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTEqualsOperatorNodeOutput?(Left8 @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTEqualsOperatorNodeOutput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTNotEqualsOperatorNodeOutput value) => new Left8((global::G.ASTNotEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTNotEqualsOperatorNodeOutput?(Left8 @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTNotEqualsOperatorNodeOutput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTGreaterThanOperatorNodeOutput value) => new Left8((global::G.ASTGreaterThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTGreaterThanOperatorNodeOutput?(Left8 @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTGreaterThanOperatorNodeOutput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTLessThanOperatorNodeOutput value) => new Left8((global::G.ASTLessThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLessThanOperatorNodeOutput?(Left8 @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTLessThanOperatorNodeOutput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput value) => new Left8((global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?(Left8 @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Left8(global::G.ASTLessThanOrEqualsOperatorNodeOutput value) => new Left8((global::G.ASTLessThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLessThanOrEqualsOperatorNodeOutput?(Left8 @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public Left8(global::G.ASTLessThanOrEqualsOperatorNodeOutput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Left8(
            global::G.ASTLessThanOperatorNodeOutputLeftDiscriminatorType? type,
            global::G.ASTStringNodeOutput? stringLiteral,
            global::G.ASTNumberNodeOutput? numberLiteral,
            global::G.ASTBooleanNodeOutput? booleanLiteral,
            global::G.ASTLLMNodeOutput? llm,
            global::G.ASTDynamicVariableNodeOutput? dynamicVariable,
            global::G.ASTOrOperatorNodeOutput? orOperator,
            global::G.ASTAndOperatorNodeOutput? andOperator,
            global::G.ASTEqualsOperatorNodeOutput? eqOperator,
            global::G.ASTNotEqualsOperatorNodeOutput? neqOperator,
            global::G.ASTGreaterThanOperatorNodeOutput? gtOperator,
            global::G.ASTLessThanOperatorNodeOutput? ltOperator,
            global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator,
            global::G.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator
            )
        {
            Type = type;

            StringLiteral = stringLiteral;
            NumberLiteral = numberLiteral;
            BooleanLiteral = booleanLiteral;
            Llm = llm;
            DynamicVariable = dynamicVariable;
            OrOperator = orOperator;
            AndOperator = andOperator;
            EqOperator = eqOperator;
            NeqOperator = neqOperator;
            GtOperator = gtOperator;
            LtOperator = ltOperator;
            GteOperator = gteOperator;
            LteOperator = lteOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LteOperator as object ??
            GteOperator as object ??
            LtOperator as object ??
            GtOperator as object ??
            NeqOperator as object ??
            EqOperator as object ??
            AndOperator as object ??
            OrOperator as object ??
            DynamicVariable as object ??
            Llm as object ??
            BooleanLiteral as object ??
            NumberLiteral as object ??
            StringLiteral as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringLiteral?.ToString() ??
            NumberLiteral?.ToString() ??
            BooleanLiteral?.ToString() ??
            Llm?.ToString() ??
            DynamicVariable?.ToString() ??
            OrOperator?.ToString() ??
            AndOperator?.ToString() ??
            EqOperator?.ToString() ??
            NeqOperator?.ToString() ??
            GtOperator?.ToString() ??
            LtOperator?.ToString() ??
            GteOperator?.ToString() ??
            LteOperator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && IsLteOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ASTStringNodeOutput?, TResult>? stringLiteral = null,
            global::System.Func<global::G.ASTNumberNodeOutput?, TResult>? numberLiteral = null,
            global::System.Func<global::G.ASTBooleanNodeOutput?, TResult>? booleanLiteral = null,
            global::System.Func<global::G.ASTLLMNodeOutput?, TResult>? llm = null,
            global::System.Func<global::G.ASTDynamicVariableNodeOutput?, TResult>? dynamicVariable = null,
            global::System.Func<global::G.ASTOrOperatorNodeOutput?, TResult>? orOperator = null,
            global::System.Func<global::G.ASTAndOperatorNodeOutput?, TResult>? andOperator = null,
            global::System.Func<global::G.ASTEqualsOperatorNodeOutput?, TResult>? eqOperator = null,
            global::System.Func<global::G.ASTNotEqualsOperatorNodeOutput?, TResult>? neqOperator = null,
            global::System.Func<global::G.ASTGreaterThanOperatorNodeOutput?, TResult>? gtOperator = null,
            global::System.Func<global::G.ASTLessThanOperatorNodeOutput?, TResult>? ltOperator = null,
            global::System.Func<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?, TResult>? gteOperator = null,
            global::System.Func<global::G.ASTLessThanOrEqualsOperatorNodeOutput?, TResult>? lteOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral && stringLiteral != null)
            {
                return stringLiteral(StringLiteral!);
            }
            else if (IsNumberLiteral && numberLiteral != null)
            {
                return numberLiteral(NumberLiteral!);
            }
            else if (IsBooleanLiteral && booleanLiteral != null)
            {
                return booleanLiteral(BooleanLiteral!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsDynamicVariable && dynamicVariable != null)
            {
                return dynamicVariable(DynamicVariable!);
            }
            else if (IsOrOperator && orOperator != null)
            {
                return orOperator(OrOperator!);
            }
            else if (IsAndOperator && andOperator != null)
            {
                return andOperator(AndOperator!);
            }
            else if (IsEqOperator && eqOperator != null)
            {
                return eqOperator(EqOperator!);
            }
            else if (IsNeqOperator && neqOperator != null)
            {
                return neqOperator(NeqOperator!);
            }
            else if (IsGtOperator && gtOperator != null)
            {
                return gtOperator(GtOperator!);
            }
            else if (IsLtOperator && ltOperator != null)
            {
                return ltOperator(LtOperator!);
            }
            else if (IsGteOperator && gteOperator != null)
            {
                return gteOperator(GteOperator!);
            }
            else if (IsLteOperator && lteOperator != null)
            {
                return lteOperator(LteOperator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ASTStringNodeOutput?>? stringLiteral = null,
            global::System.Action<global::G.ASTNumberNodeOutput?>? numberLiteral = null,
            global::System.Action<global::G.ASTBooleanNodeOutput?>? booleanLiteral = null,
            global::System.Action<global::G.ASTLLMNodeOutput?>? llm = null,
            global::System.Action<global::G.ASTDynamicVariableNodeOutput?>? dynamicVariable = null,
            global::System.Action<global::G.ASTOrOperatorNodeOutput?>? orOperator = null,
            global::System.Action<global::G.ASTAndOperatorNodeOutput?>? andOperator = null,
            global::System.Action<global::G.ASTEqualsOperatorNodeOutput?>? eqOperator = null,
            global::System.Action<global::G.ASTNotEqualsOperatorNodeOutput?>? neqOperator = null,
            global::System.Action<global::G.ASTGreaterThanOperatorNodeOutput?>? gtOperator = null,
            global::System.Action<global::G.ASTLessThanOperatorNodeOutput?>? ltOperator = null,
            global::System.Action<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?>? gteOperator = null,
            global::System.Action<global::G.ASTLessThanOrEqualsOperatorNodeOutput?>? lteOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral)
            {
                stringLiteral?.Invoke(StringLiteral!);
            }
            else if (IsNumberLiteral)
            {
                numberLiteral?.Invoke(NumberLiteral!);
            }
            else if (IsBooleanLiteral)
            {
                booleanLiteral?.Invoke(BooleanLiteral!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsOrOperator)
            {
                orOperator?.Invoke(OrOperator!);
            }
            else if (IsAndOperator)
            {
                andOperator?.Invoke(AndOperator!);
            }
            else if (IsEqOperator)
            {
                eqOperator?.Invoke(EqOperator!);
            }
            else if (IsNeqOperator)
            {
                neqOperator?.Invoke(NeqOperator!);
            }
            else if (IsGtOperator)
            {
                gtOperator?.Invoke(GtOperator!);
            }
            else if (IsLtOperator)
            {
                ltOperator?.Invoke(LtOperator!);
            }
            else if (IsGteOperator)
            {
                gteOperator?.Invoke(GteOperator!);
            }
            else if (IsLteOperator)
            {
                lteOperator?.Invoke(LteOperator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringLiteral,
                typeof(global::G.ASTStringNodeOutput),
                NumberLiteral,
                typeof(global::G.ASTNumberNodeOutput),
                BooleanLiteral,
                typeof(global::G.ASTBooleanNodeOutput),
                Llm,
                typeof(global::G.ASTLLMNodeOutput),
                DynamicVariable,
                typeof(global::G.ASTDynamicVariableNodeOutput),
                OrOperator,
                typeof(global::G.ASTOrOperatorNodeOutput),
                AndOperator,
                typeof(global::G.ASTAndOperatorNodeOutput),
                EqOperator,
                typeof(global::G.ASTEqualsOperatorNodeOutput),
                NeqOperator,
                typeof(global::G.ASTNotEqualsOperatorNodeOutput),
                GtOperator,
                typeof(global::G.ASTGreaterThanOperatorNodeOutput),
                LtOperator,
                typeof(global::G.ASTLessThanOperatorNodeOutput),
                GteOperator,
                typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput),
                LteOperator,
                typeof(global::G.ASTLessThanOrEqualsOperatorNodeOutput),
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
        public bool Equals(Left8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ASTStringNodeOutput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTNumberNodeOutput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTBooleanNodeOutput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLLMNodeOutput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTDynamicVariableNodeOutput?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTOrOperatorNodeOutput?>.Default.Equals(OrOperator, other.OrOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTAndOperatorNodeOutput?>.Default.Equals(AndOperator, other.AndOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTEqualsOperatorNodeOutput?>.Default.Equals(EqOperator, other.EqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTNotEqualsOperatorNodeOutput?>.Default.Equals(NeqOperator, other.NeqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTGreaterThanOperatorNodeOutput?>.Default.Equals(GtOperator, other.GtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLessThanOperatorNodeOutput?>.Default.Equals(LtOperator, other.LtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?>.Default.Equals(GteOperator, other.GteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLessThanOrEqualsOperatorNodeOutput?>.Default.Equals(LteOperator, other.LteOperator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Left8 obj1, Left8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Left8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Left8 obj1, Left8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Left8 o && Equals(o);
        }
    }
}
