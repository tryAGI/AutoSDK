//HintName: G.Models.BaseInputs.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputs : global::System.IEquatable<BaseInputs>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BaseInputsVariant1 { get; init; }
#else
        public string? BaseInputsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsVariant1))]
#endif
        public bool IsBaseInputsVariant1 => BaseInputsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>? BaseInputs1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>? BaseInputs1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputs1))]
#endif
        public bool IsBaseInputs1 => BaseInputs1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? BaseInputsVariant3 { get; init; }
#else
        public object? BaseInputsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsVariant3))]
#endif
        public bool IsBaseInputsVariant3 => BaseInputsVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputs(string value) => new BaseInputs((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BaseInputs @this) => @this.BaseInputsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputs(string? value)
        {
            BaseInputsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputs(
            string? baseInputsVariant1,
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>? baseInputs1,
            object? baseInputsVariant3
            )
        {
            BaseInputsVariant1 = baseInputsVariant1;
            BaseInputs1 = baseInputs1;
            BaseInputsVariant3 = baseInputsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseInputsVariant3 as object ??
            BaseInputs1 as object ??
            BaseInputsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsVariant1?.ToString() ??
            BaseInputs1?.ToString() ??
            BaseInputsVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsVariant1 && !IsBaseInputs1 && !IsBaseInputsVariant3 || !IsBaseInputsVariant1 && IsBaseInputs1 && !IsBaseInputsVariant3 || !IsBaseInputsVariant1 && !IsBaseInputs1 && IsBaseInputsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? baseInputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>?, TResult>? baseInputs1 = null,
            global::System.Func<object?, TResult>? baseInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsVariant1 && baseInputsVariant1 != null)
            {
                return baseInputsVariant1(BaseInputsVariant1!);
            }
            else if (IsBaseInputs1 && baseInputs1 != null)
            {
                return baseInputs1(BaseInputs1!);
            }
            else if (IsBaseInputsVariant3 && baseInputsVariant3 != null)
            {
                return baseInputsVariant3(BaseInputsVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? baseInputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>?>? baseInputs1 = null,
            global::System.Action<object?>? baseInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsVariant1)
            {
                baseInputsVariant1?.Invoke(BaseInputsVariant1!);
            }
            else if (IsBaseInputs1)
            {
                baseInputs1?.Invoke(BaseInputs1!);
            }
            else if (IsBaseInputsVariant3)
            {
                baseInputsVariant3?.Invoke(BaseInputsVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsVariant1,
                typeof(string),
                BaseInputs1,
                typeof(global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>),
                BaseInputsVariant3,
                typeof(object),
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
        public bool Equals(BaseInputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BaseInputsVariant1, other.BaseInputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1Items>?>.Default.Equals(BaseInputs1, other.BaseInputs1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(BaseInputsVariant3, other.BaseInputsVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputs obj1, BaseInputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputs obj1, BaseInputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputs o && Equals(o);
        }
    }
}
