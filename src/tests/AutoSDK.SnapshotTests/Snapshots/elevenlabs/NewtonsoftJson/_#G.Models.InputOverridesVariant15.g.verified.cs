//HintName: G.Models.InputOverridesVariant15.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputOverridesVariant15 : global::System.IEquatable<InputOverridesVariant15>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Source { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConstantSchemaOverride? Constant { get; init; }
#else
        public global::G.ConstantSchemaOverride? Constant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Constant))]
#endif
        public bool IsConstant => Constant != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DynamicVariableSchemaOverride? DynamicVariable { get; init; }
#else
        public global::G.DynamicVariableSchemaOverride? DynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariable))]
#endif
        public bool IsDynamicVariable => DynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMSchemaOverride? Llm { get; init; }
#else
        public global::G.LLMSchemaOverride? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant15(global::G.ConstantSchemaOverride value) => new InputOverridesVariant15((global::G.ConstantSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConstantSchemaOverride?(InputOverridesVariant15 @this) => @this.Constant;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant15(global::G.ConstantSchemaOverride? value)
        {
            Constant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant15(global::G.DynamicVariableSchemaOverride value) => new InputOverridesVariant15((global::G.DynamicVariableSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DynamicVariableSchemaOverride?(InputOverridesVariant15 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant15(global::G.DynamicVariableSchemaOverride? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant15(global::G.LLMSchemaOverride value) => new InputOverridesVariant15((global::G.LLMSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMSchemaOverride?(InputOverridesVariant15 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant15(global::G.LLMSchemaOverride? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant15(
            global::G.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? source,
            global::G.ConstantSchemaOverride? constant,
            global::G.DynamicVariableSchemaOverride? dynamicVariable,
            global::G.LLMSchemaOverride? llm
            )
        {
            Source = source;

            Constant = constant;
            DynamicVariable = dynamicVariable;
            Llm = llm;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Llm as object ??
            DynamicVariable as object ??
            Constant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Constant?.ToString() ??
            DynamicVariable?.ToString() ??
            Llm?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConstant && !IsDynamicVariable && !IsLlm || !IsConstant && IsDynamicVariable && !IsLlm || !IsConstant && !IsDynamicVariable && IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConstantSchemaOverride?, TResult>? constant = null,
            global::System.Func<global::G.DynamicVariableSchemaOverride?, TResult>? dynamicVariable = null,
            global::System.Func<global::G.LLMSchemaOverride?, TResult>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstant && constant != null)
            {
                return constant(Constant!);
            }
            else if (IsDynamicVariable && dynamicVariable != null)
            {
                return dynamicVariable(DynamicVariable!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConstantSchemaOverride?>? constant = null,
            global::System.Action<global::G.DynamicVariableSchemaOverride?>? dynamicVariable = null,
            global::System.Action<global::G.LLMSchemaOverride?>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstant)
            {
                constant?.Invoke(Constant!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Constant,
                typeof(global::G.ConstantSchemaOverride),
                DynamicVariable,
                typeof(global::G.DynamicVariableSchemaOverride),
                Llm,
                typeof(global::G.LLMSchemaOverride),
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
        public bool Equals(InputOverridesVariant15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConstantSchemaOverride?>.Default.Equals(Constant, other.Constant) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DynamicVariableSchemaOverride?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMSchemaOverride?>.Default.Equals(Llm, other.Llm) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputOverridesVariant15 obj1, InputOverridesVariant15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputOverridesVariant15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputOverridesVariant15 obj1, InputOverridesVariant15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputOverridesVariant15 o && Equals(o);
        }
    }
}
