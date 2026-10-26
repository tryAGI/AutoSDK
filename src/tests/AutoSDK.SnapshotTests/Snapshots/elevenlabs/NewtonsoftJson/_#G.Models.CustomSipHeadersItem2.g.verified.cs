//HintName: G.Models.CustomSipHeadersItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomSipHeadersItem2 : global::System.IEquatable<CustomSipHeadersItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type { get; }

        /// <summary>
        /// Custom SIP header for phone transfers with a static (validated) value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomSIPHeader? Static { get; init; }
#else
        public global::G.CustomSIPHeader? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStatic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CustomSIPHeader? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomSIPHeader PickStatic() => Static is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");

        /// <summary>
        /// Custom SIP header for phone transfers with a dynamic variable reference.<br/>
        /// The value is a variable name that will be resolved at runtime.<br/>
        /// Value is not validated here since it will be substituted with actual value later.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomSIPHeaderWithDynamicVariable? Dynamic { get; init; }
#else
        public global::G.CustomSIPHeaderWithDynamicVariable? Dynamic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CustomSIPHeaderWithDynamicVariable? value)
        {
            value = Dynamic;
            return IsDynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomSIPHeaderWithDynamicVariable PickDynamic() => Dynamic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dynamic' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomSipHeadersItem2(global::G.CustomSIPHeader value) => new CustomSipHeadersItem2((global::G.CustomSIPHeader?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomSIPHeader?(CustomSipHeadersItem2 @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem2(global::G.CustomSIPHeader? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CustomSipHeadersItem2 FromStatic(global::G.CustomSIPHeader? value) => new CustomSipHeadersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomSipHeadersItem2(global::G.CustomSIPHeaderWithDynamicVariable value) => new CustomSipHeadersItem2((global::G.CustomSIPHeaderWithDynamicVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomSIPHeaderWithDynamicVariable?(CustomSipHeadersItem2 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem2(global::G.CustomSIPHeaderWithDynamicVariable? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CustomSipHeadersItem2 FromDynamic(global::G.CustomSIPHeaderWithDynamicVariable? value) => new CustomSipHeadersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public CustomSipHeadersItem2(
            global::G.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? type,
            global::G.CustomSIPHeader? @static,
            global::G.CustomSIPHeaderWithDynamicVariable? dynamic
            )
        {
            Type = type;

            Static = @static;
            Dynamic = dynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dynamic as object ??
            Static as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Static?.ToString() ??
            Dynamic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStatic && !IsDynamic || !IsStatic && IsDynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CustomSIPHeader, TResult>? @static = null,
            global::System.Func<global::G.CustomSIPHeaderWithDynamicVariable, TResult>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0 && @static != null)
            {
                return @static(__value0);
            }
            else if (Dynamic is { } __value1 && dynamic != null)
            {
                return dynamic(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CustomSIPHeader>? @static = null,

            global::System.Action<global::G.CustomSIPHeaderWithDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
            else if (Dynamic is { } __value1)
            {
                dynamic?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.CustomSIPHeader>? @static = null,
            global::System.Action<global::G.CustomSIPHeaderWithDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
            else if (Dynamic is { } __value1)
            {
                dynamic?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Static,
                typeof(global::G.CustomSIPHeader),
                Dynamic,
                typeof(global::G.CustomSIPHeaderWithDynamicVariable),
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
        public bool Equals(CustomSipHeadersItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CustomSIPHeader?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomSIPHeaderWithDynamicVariable?>.Default.Equals(Dynamic, other.Dynamic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomSipHeadersItem2 obj1, CustomSipHeadersItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomSipHeadersItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomSipHeadersItem2 obj1, CustomSipHeadersItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomSipHeadersItem2 o && Equals(o);
        }
    }
}
