//HintName: G.Models.SchemaOverridesVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SchemaOverridesVariant12 : global::System.IEquatable<SchemaOverridesVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource? Source { get; }

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
        public bool TryPickConstant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConstantSchemaOverride? value)
        {
            value = Constant;
            return IsConstant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConstantSchemaOverride PickConstant() => Constant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Constant' but the value was {ToString()}.");

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
        public bool TryPickDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DynamicVariableSchemaOverride? value)
        {
            value = DynamicVariable;
            return IsDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DynamicVariableSchemaOverride PickDynamicVariable() => DynamicVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicVariable' but the value was {ToString()}.");

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
        public bool TryPickLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.LLMSchemaOverride? value)
        {
            value = Llm;
            return IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.LLMSchemaOverride PickLlm() => Llm is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Llm' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SchemaOverridesVariant12(global::G.ConstantSchemaOverride value) => new SchemaOverridesVariant12((global::G.ConstantSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConstantSchemaOverride?(SchemaOverridesVariant12 @this) => @this.Constant;

        /// <summary>
        /// 
        /// </summary>
        public SchemaOverridesVariant12(global::G.ConstantSchemaOverride? value)
        {
            Constant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SchemaOverridesVariant12 FromConstant(global::G.ConstantSchemaOverride? value) => new SchemaOverridesVariant12(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SchemaOverridesVariant12(global::G.DynamicVariableSchemaOverride value) => new SchemaOverridesVariant12((global::G.DynamicVariableSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DynamicVariableSchemaOverride?(SchemaOverridesVariant12 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public SchemaOverridesVariant12(global::G.DynamicVariableSchemaOverride? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SchemaOverridesVariant12 FromDynamicVariable(global::G.DynamicVariableSchemaOverride? value) => new SchemaOverridesVariant12(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SchemaOverridesVariant12(global::G.LLMSchemaOverride value) => new SchemaOverridesVariant12((global::G.LLMSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMSchemaOverride?(SchemaOverridesVariant12 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public SchemaOverridesVariant12(global::G.LLMSchemaOverride? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SchemaOverridesVariant12 FromLlm(global::G.LLMSchemaOverride? value) => new SchemaOverridesVariant12(value);

        /// <summary>
        /// 
        /// </summary>
        public SchemaOverridesVariant12(
            global::G.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource? source,
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
            global::System.Func<global::G.ConstantSchemaOverride, TResult>? constant = null,
            global::System.Func<global::G.DynamicVariableSchemaOverride, TResult>? dynamicVariable = null,
            global::System.Func<global::G.LLMSchemaOverride, TResult>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Constant is { } __value0 && constant != null)
            {
                return constant(__value0);
            }
            else if (DynamicVariable is { } __value1 && dynamicVariable != null)
            {
                return dynamicVariable(__value1);
            }
            else if (Llm is { } __value2 && llm != null)
            {
                return llm(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConstantSchemaOverride>? constant = null,

            global::System.Action<global::G.DynamicVariableSchemaOverride>? dynamicVariable = null,

            global::System.Action<global::G.LLMSchemaOverride>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Constant is { } __value0)
            {
                constant?.Invoke(__value0);
            }
            else if (DynamicVariable is { } __value1)
            {
                dynamicVariable?.Invoke(__value1);
            }
            else if (Llm is { } __value2)
            {
                llm?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ConstantSchemaOverride>? constant = null,
            global::System.Action<global::G.DynamicVariableSchemaOverride>? dynamicVariable = null,
            global::System.Action<global::G.LLMSchemaOverride>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Constant is { } __value0)
            {
                constant?.Invoke(__value0);
            }
            else if (DynamicVariable is { } __value1)
            {
                dynamicVariable?.Invoke(__value1);
            }
            else if (Llm is { } __value2)
            {
                llm?.Invoke(__value2);
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
        public bool Equals(SchemaOverridesVariant12 other)
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
        public static bool operator ==(SchemaOverridesVariant12 obj1, SchemaOverridesVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SchemaOverridesVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SchemaOverridesVariant12 obj1, SchemaOverridesVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SchemaOverridesVariant12 o && Equals(o);
        }
    }
}
