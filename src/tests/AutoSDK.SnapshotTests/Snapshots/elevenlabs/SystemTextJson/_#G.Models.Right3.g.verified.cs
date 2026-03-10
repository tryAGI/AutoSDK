//HintName: G.Models.Right3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Right operand of the binary operator.
    /// </summary>
    public readonly partial struct Right3 : global::System.IEquatable<Right3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ASTGreaterThanOperatorNodeInputRightDiscriminatorType? Type { get; }

        /// <summary>
        /// String literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ASTStringNodeInput? StringLiteral { get; init; }
#else
        public global::G.ASTStringNodeInput? StringLiteral { get; }
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
        public global::G.ASTNumberNodeInput? NumberLiteral { get; init; }
#else
        public global::G.ASTNumberNodeInput? NumberLiteral { get; }
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
        public global::G.ASTBooleanNodeInput? BooleanLiteral { get; init; }
#else
        public global::G.ASTBooleanNodeInput? BooleanLiteral { get; }
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
        public global::G.ASTLLMNodeInput? Llm { get; init; }
#else
        public global::G.ASTLLMNodeInput? Llm { get; }
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
        public global::G.ASTDynamicVariableNodeInput? DynamicVariable { get; init; }
#else
        public global::G.ASTDynamicVariableNodeInput? DynamicVariable { get; }
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
        public global::G.ASTOrOperatorNodeInput? OrOperator { get; init; }
#else
        public global::G.ASTOrOperatorNodeInput? OrOperator { get; }
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
        public global::G.ASTAndOperatorNodeInput? AndOperator { get; init; }
#else
        public global::G.ASTAndOperatorNodeInput? AndOperator { get; }
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
        public global::G.ASTEqualsOperatorNodeInput? EqOperator { get; init; }
#else
        public global::G.ASTEqualsOperatorNodeInput? EqOperator { get; }
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
        public global::G.ASTNotEqualsOperatorNodeInput? NeqOperator { get; init; }
#else
        public global::G.ASTNotEqualsOperatorNodeInput? NeqOperator { get; }
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
        public global::G.ASTGreaterThanOperatorNodeInput? GtOperator { get; init; }
#else
        public global::G.ASTGreaterThanOperatorNodeInput? GtOperator { get; }
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
        public global::G.ASTLessThanOperatorNodeInput? LtOperator { get; init; }
#else
        public global::G.ASTLessThanOperatorNodeInput? LtOperator { get; }
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
        public global::G.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; init; }
#else
        public global::G.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; }
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
        public global::G.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; init; }
#else
        public global::G.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; }
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
        public static implicit operator Right3(global::G.ASTStringNodeInput value) => new Right3((global::G.ASTStringNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTStringNodeInput?(Right3 @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTStringNodeInput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTNumberNodeInput value) => new Right3((global::G.ASTNumberNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTNumberNodeInput?(Right3 @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTNumberNodeInput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTBooleanNodeInput value) => new Right3((global::G.ASTBooleanNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTBooleanNodeInput?(Right3 @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTBooleanNodeInput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTLLMNodeInput value) => new Right3((global::G.ASTLLMNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLLMNodeInput?(Right3 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTLLMNodeInput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTDynamicVariableNodeInput value) => new Right3((global::G.ASTDynamicVariableNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTDynamicVariableNodeInput?(Right3 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTDynamicVariableNodeInput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTOrOperatorNodeInput value) => new Right3((global::G.ASTOrOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTOrOperatorNodeInput?(Right3 @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTOrOperatorNodeInput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTAndOperatorNodeInput value) => new Right3((global::G.ASTAndOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTAndOperatorNodeInput?(Right3 @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTAndOperatorNodeInput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTEqualsOperatorNodeInput value) => new Right3((global::G.ASTEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTEqualsOperatorNodeInput?(Right3 @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTEqualsOperatorNodeInput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTNotEqualsOperatorNodeInput value) => new Right3((global::G.ASTNotEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTNotEqualsOperatorNodeInput?(Right3 @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTNotEqualsOperatorNodeInput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTGreaterThanOperatorNodeInput value) => new Right3((global::G.ASTGreaterThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTGreaterThanOperatorNodeInput?(Right3 @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTGreaterThanOperatorNodeInput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTLessThanOperatorNodeInput value) => new Right3((global::G.ASTLessThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLessThanOperatorNodeInput?(Right3 @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTLessThanOperatorNodeInput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTGreaterThanOrEqualsOperatorNodeInput value) => new Right3((global::G.ASTGreaterThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTGreaterThanOrEqualsOperatorNodeInput?(Right3 @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTGreaterThanOrEqualsOperatorNodeInput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Right3(global::G.ASTLessThanOrEqualsOperatorNodeInput value) => new Right3((global::G.ASTLessThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ASTLessThanOrEqualsOperatorNodeInput?(Right3 @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public Right3(global::G.ASTLessThanOrEqualsOperatorNodeInput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Right3(
            global::G.ASTGreaterThanOperatorNodeInputRightDiscriminatorType? type,
            global::G.ASTStringNodeInput? stringLiteral,
            global::G.ASTNumberNodeInput? numberLiteral,
            global::G.ASTBooleanNodeInput? booleanLiteral,
            global::G.ASTLLMNodeInput? llm,
            global::G.ASTDynamicVariableNodeInput? dynamicVariable,
            global::G.ASTOrOperatorNodeInput? orOperator,
            global::G.ASTAndOperatorNodeInput? andOperator,
            global::G.ASTEqualsOperatorNodeInput? eqOperator,
            global::G.ASTNotEqualsOperatorNodeInput? neqOperator,
            global::G.ASTGreaterThanOperatorNodeInput? gtOperator,
            global::G.ASTLessThanOperatorNodeInput? ltOperator,
            global::G.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator,
            global::G.ASTLessThanOrEqualsOperatorNodeInput? lteOperator
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
            global::System.Func<global::G.ASTStringNodeInput?, TResult>? stringLiteral = null,
            global::System.Func<global::G.ASTNumberNodeInput?, TResult>? numberLiteral = null,
            global::System.Func<global::G.ASTBooleanNodeInput?, TResult>? booleanLiteral = null,
            global::System.Func<global::G.ASTLLMNodeInput?, TResult>? llm = null,
            global::System.Func<global::G.ASTDynamicVariableNodeInput?, TResult>? dynamicVariable = null,
            global::System.Func<global::G.ASTOrOperatorNodeInput?, TResult>? orOperator = null,
            global::System.Func<global::G.ASTAndOperatorNodeInput?, TResult>? andOperator = null,
            global::System.Func<global::G.ASTEqualsOperatorNodeInput?, TResult>? eqOperator = null,
            global::System.Func<global::G.ASTNotEqualsOperatorNodeInput?, TResult>? neqOperator = null,
            global::System.Func<global::G.ASTGreaterThanOperatorNodeInput?, TResult>? gtOperator = null,
            global::System.Func<global::G.ASTLessThanOperatorNodeInput?, TResult>? ltOperator = null,
            global::System.Func<global::G.ASTGreaterThanOrEqualsOperatorNodeInput?, TResult>? gteOperator = null,
            global::System.Func<global::G.ASTLessThanOrEqualsOperatorNodeInput?, TResult>? lteOperator = null,
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
            global::System.Action<global::G.ASTStringNodeInput?>? stringLiteral = null,
            global::System.Action<global::G.ASTNumberNodeInput?>? numberLiteral = null,
            global::System.Action<global::G.ASTBooleanNodeInput?>? booleanLiteral = null,
            global::System.Action<global::G.ASTLLMNodeInput?>? llm = null,
            global::System.Action<global::G.ASTDynamicVariableNodeInput?>? dynamicVariable = null,
            global::System.Action<global::G.ASTOrOperatorNodeInput?>? orOperator = null,
            global::System.Action<global::G.ASTAndOperatorNodeInput?>? andOperator = null,
            global::System.Action<global::G.ASTEqualsOperatorNodeInput?>? eqOperator = null,
            global::System.Action<global::G.ASTNotEqualsOperatorNodeInput?>? neqOperator = null,
            global::System.Action<global::G.ASTGreaterThanOperatorNodeInput?>? gtOperator = null,
            global::System.Action<global::G.ASTLessThanOperatorNodeInput?>? ltOperator = null,
            global::System.Action<global::G.ASTGreaterThanOrEqualsOperatorNodeInput?>? gteOperator = null,
            global::System.Action<global::G.ASTLessThanOrEqualsOperatorNodeInput?>? lteOperator = null,
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
                typeof(global::G.ASTStringNodeInput),
                NumberLiteral,
                typeof(global::G.ASTNumberNodeInput),
                BooleanLiteral,
                typeof(global::G.ASTBooleanNodeInput),
                Llm,
                typeof(global::G.ASTLLMNodeInput),
                DynamicVariable,
                typeof(global::G.ASTDynamicVariableNodeInput),
                OrOperator,
                typeof(global::G.ASTOrOperatorNodeInput),
                AndOperator,
                typeof(global::G.ASTAndOperatorNodeInput),
                EqOperator,
                typeof(global::G.ASTEqualsOperatorNodeInput),
                NeqOperator,
                typeof(global::G.ASTNotEqualsOperatorNodeInput),
                GtOperator,
                typeof(global::G.ASTGreaterThanOperatorNodeInput),
                LtOperator,
                typeof(global::G.ASTLessThanOperatorNodeInput),
                GteOperator,
                typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput),
                LteOperator,
                typeof(global::G.ASTLessThanOrEqualsOperatorNodeInput),
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
        public bool Equals(Right3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ASTStringNodeInput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTNumberNodeInput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTBooleanNodeInput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLLMNodeInput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTDynamicVariableNodeInput?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTOrOperatorNodeInput?>.Default.Equals(OrOperator, other.OrOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTAndOperatorNodeInput?>.Default.Equals(AndOperator, other.AndOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTEqualsOperatorNodeInput?>.Default.Equals(EqOperator, other.EqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTNotEqualsOperatorNodeInput?>.Default.Equals(NeqOperator, other.NeqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTGreaterThanOperatorNodeInput?>.Default.Equals(GtOperator, other.GtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLessThanOperatorNodeInput?>.Default.Equals(LtOperator, other.LtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTGreaterThanOrEqualsOperatorNodeInput?>.Default.Equals(GteOperator, other.GteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ASTLessThanOrEqualsOperatorNodeInput?>.Default.Equals(LteOperator, other.LteOperator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Right3 obj1, Right3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Right3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Right3 obj1, Right3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Right3 o && Equals(o);
        }
    }
}
