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
        public string? BaseInputsOneOf1ItemsOneOf2OutputVariant1 { get; init; }
#else
        public string? BaseInputsOneOf1ItemsOneOf2OutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf2OutputVariant1))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf2OutputVariant1 => BaseInputsOneOf1ItemsOneOf2OutputVariant1 != null;

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
        public static implicit operator string?(BaseInputsOneOf1ItemsOneOf2Output @this) => @this.BaseInputsOneOf1ItemsOneOf2OutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2Output(string? value)
        {
            BaseInputsOneOf1ItemsOneOf2OutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf2Output(
            string? baseInputsOneOf1ItemsOneOf2OutputVariant1,
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>? baseInputsOneOf1ItemsOneOf2Output1
            )
        {
            BaseInputsOneOf1ItemsOneOf2OutputVariant1 = baseInputsOneOf1ItemsOneOf2OutputVariant1;
            BaseInputsOneOf1ItemsOneOf2Output1 = baseInputsOneOf1ItemsOneOf2Output1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseInputsOneOf1ItemsOneOf2Output1 as object ??
            BaseInputsOneOf1ItemsOneOf2OutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1ItemsOneOf2OutputVariant1?.ToString() ??
            BaseInputsOneOf1ItemsOneOf2Output1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1ItemsOneOf2OutputVariant1 && !IsBaseInputsOneOf1ItemsOneOf2Output1 || !IsBaseInputsOneOf1ItemsOneOf2OutputVariant1 && IsBaseInputsOneOf1ItemsOneOf2Output1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? baseInputsOneOf1ItemsOneOf2OutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>?, TResult>? baseInputsOneOf1ItemsOneOf2Output1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf2OutputVariant1 && baseInputsOneOf1ItemsOneOf2OutputVariant1 != null)
            {
                return baseInputsOneOf1ItemsOneOf2OutputVariant1(BaseInputsOneOf1ItemsOneOf2OutputVariant1!);
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
            global::System.Action<string?>? baseInputsOneOf1ItemsOneOf2OutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>?>? baseInputsOneOf1ItemsOneOf2Output1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf2OutputVariant1)
            {
                baseInputsOneOf1ItemsOneOf2OutputVariant1?.Invoke(BaseInputsOneOf1ItemsOneOf2OutputVariant1!);
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
                BaseInputsOneOf1ItemsOneOf2OutputVariant1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BaseInputsOneOf1ItemsOneOf2OutputVariant1, other.BaseInputsOneOf1ItemsOneOf2OutputVariant1) &&
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
