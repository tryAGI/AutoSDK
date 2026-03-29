//HintName: G.Models.BaseInputsOneOf1ItemsOneOf2Output.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf2Output : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf2Output>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>? BaseInputsOneOf1ItemsOneOf2Output1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>? BaseInputsOneOf1ItemsOneOf2Output1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf2Output1))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf2Output1 => BaseInputsOneOf1ItemsOneOf2Output1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf2Output(string value) => new BaseInputsOneOf1ItemsOneOf2Output((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BaseInputsOneOf1ItemsOneOf2Output @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2Output(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2Output(
            string? value1,
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>? baseInputsOneOf1ItemsOneOf2Output1
            )
        {
            Value1 = value1;
            BaseInputsOneOf1ItemsOneOf2Output1 = baseInputsOneOf1ItemsOneOf2Output1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseInputsOneOf1ItemsOneOf2Output1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            BaseInputsOneOf1ItemsOneOf2Output1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsBaseInputsOneOf1ItemsOneOf2Output1 || !IsValue1 && IsBaseInputsOneOf1ItemsOneOf2Output1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>?, TResult>? baseInputsOneOf1ItemsOneOf2Output1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf2Output1 && baseInputsOneOf1ItemsOneOf2Output1 != null)
            {
                return baseInputsOneOf1ItemsOneOf2Output1(BaseInputsOneOf1ItemsOneOf2Output1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>?>? baseInputsOneOf1ItemsOneOf2Output1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf2Output1)
            {
                baseInputsOneOf1ItemsOneOf2Output1?.Invoke(BaseInputsOneOf1ItemsOneOf2Output1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                BaseInputsOneOf1ItemsOneOf2Output1,
                typeof(global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf2Output other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>?>.Default.Equals(BaseInputsOneOf1ItemsOneOf2Output1, other.BaseInputsOneOf1ItemsOneOf2Output1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf2Output obj1, BaseInputsOneOf1ItemsOneOf2Output obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf2Output>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf2Output obj1, BaseInputsOneOf1ItemsOneOf2Output obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf2Output o && Equals(o);
        }
    }
}
