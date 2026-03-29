//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf0Content : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf0Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>? BaseInputsOneOf1ItemsOneOf0Content0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>? BaseInputsOneOf1ItemsOneOf0Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf0Content0))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf0Content0 => BaseInputsOneOf1ItemsOneOf0Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0Content(string value) => new BaseInputsOneOf1ItemsOneOf0Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BaseInputsOneOf1ItemsOneOf0Content @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0Content(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0Content(
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>? baseInputsOneOf1ItemsOneOf0Content0,
            string? value2
            )
        {
            BaseInputsOneOf1ItemsOneOf0Content0 = baseInputsOneOf1ItemsOneOf0Content0;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            BaseInputsOneOf1ItemsOneOf0Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1ItemsOneOf0Content0?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1ItemsOneOf0Content0 && !IsValue2 || !IsBaseInputsOneOf1ItemsOneOf0Content0 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>?, TResult>? baseInputsOneOf1ItemsOneOf0Content0 = null,
            global::System.Func<string?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf0Content0 && baseInputsOneOf1ItemsOneOf0Content0 != null)
            {
                return baseInputsOneOf1ItemsOneOf0Content0(BaseInputsOneOf1ItemsOneOf0Content0!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>?>? baseInputsOneOf1ItemsOneOf0Content0 = null,
            global::System.Action<string?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf0Content0)
            {
                baseInputsOneOf1ItemsOneOf0Content0?.Invoke(BaseInputsOneOf1ItemsOneOf0Content0!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsOneOf1ItemsOneOf0Content0,
                typeof(global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>),
                Value2,
                typeof(string),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf0Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>?>.Default.Equals(BaseInputsOneOf1ItemsOneOf0Content0, other.BaseInputsOneOf1ItemsOneOf0Content0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf0Content obj1, BaseInputsOneOf1ItemsOneOf0Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf0Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf0Content obj1, BaseInputsOneOf1ItemsOneOf0Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf0Content o && Equals(o);
        }
    }
}
