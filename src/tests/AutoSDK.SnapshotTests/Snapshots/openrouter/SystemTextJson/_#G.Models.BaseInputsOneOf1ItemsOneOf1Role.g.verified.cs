//HintName: G.Models.BaseInputsOneOf1ItemsOneOf1Role.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf1Role : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf1Role>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseInputsOneOf1ItemsOneOf1Role0? BaseInputsOneOf1ItemsOneOf1Role0 { get; init; }
#else
        public global::G.BaseInputsOneOf1ItemsOneOf1Role0? BaseInputsOneOf1ItemsOneOf1Role0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf1Role0))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf1Role0 => BaseInputsOneOf1ItemsOneOf1Role0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseInputsOneOf1ItemsOneOf1Role1? BaseInputsOneOf1ItemsOneOf1Role1 { get; init; }
#else
        public global::G.BaseInputsOneOf1ItemsOneOf1Role1? BaseInputsOneOf1ItemsOneOf1Role1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf1Role1))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf1Role1 => BaseInputsOneOf1ItemsOneOf1Role1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseInputsOneOf1ItemsOneOf1Role2? BaseInputsOneOf1ItemsOneOf1Role2 { get; init; }
#else
        public global::G.BaseInputsOneOf1ItemsOneOf1Role2? BaseInputsOneOf1ItemsOneOf1Role2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf1Role2))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf1Role2 => BaseInputsOneOf1ItemsOneOf1Role2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role0 value) => new BaseInputsOneOf1ItemsOneOf1Role((global::G.BaseInputsOneOf1ItemsOneOf1Role0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseInputsOneOf1ItemsOneOf1Role0?(BaseInputsOneOf1ItemsOneOf1Role @this) => @this.BaseInputsOneOf1ItemsOneOf1Role0;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role0? value)
        {
            BaseInputsOneOf1ItemsOneOf1Role0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role1 value) => new BaseInputsOneOf1ItemsOneOf1Role((global::G.BaseInputsOneOf1ItemsOneOf1Role1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseInputsOneOf1ItemsOneOf1Role1?(BaseInputsOneOf1ItemsOneOf1Role @this) => @this.BaseInputsOneOf1ItemsOneOf1Role1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role1? value)
        {
            BaseInputsOneOf1ItemsOneOf1Role1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role2 value) => new BaseInputsOneOf1ItemsOneOf1Role((global::G.BaseInputsOneOf1ItemsOneOf1Role2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseInputsOneOf1ItemsOneOf1Role2?(BaseInputsOneOf1ItemsOneOf1Role @this) => @this.BaseInputsOneOf1ItemsOneOf1Role2;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1Role(global::G.BaseInputsOneOf1ItemsOneOf1Role2? value)
        {
            BaseInputsOneOf1ItemsOneOf1Role2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf1Role(
            global::G.BaseInputsOneOf1ItemsOneOf1Role0? baseInputsOneOf1ItemsOneOf1Role0,
            global::G.BaseInputsOneOf1ItemsOneOf1Role1? baseInputsOneOf1ItemsOneOf1Role1,
            global::G.BaseInputsOneOf1ItemsOneOf1Role2? baseInputsOneOf1ItemsOneOf1Role2
            )
        {
            BaseInputsOneOf1ItemsOneOf1Role0 = baseInputsOneOf1ItemsOneOf1Role0;
            BaseInputsOneOf1ItemsOneOf1Role1 = baseInputsOneOf1ItemsOneOf1Role1;
            BaseInputsOneOf1ItemsOneOf1Role2 = baseInputsOneOf1ItemsOneOf1Role2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseInputsOneOf1ItemsOneOf1Role2 as object ??
            BaseInputsOneOf1ItemsOneOf1Role1 as object ??
            BaseInputsOneOf1ItemsOneOf1Role0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1ItemsOneOf1Role0?.ToValueString() ??
            BaseInputsOneOf1ItemsOneOf1Role1?.ToValueString() ??
            BaseInputsOneOf1ItemsOneOf1Role2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1ItemsOneOf1Role0 && !IsBaseInputsOneOf1ItemsOneOf1Role1 && !IsBaseInputsOneOf1ItemsOneOf1Role2 || !IsBaseInputsOneOf1ItemsOneOf1Role0 && IsBaseInputsOneOf1ItemsOneOf1Role1 && !IsBaseInputsOneOf1ItemsOneOf1Role2 || !IsBaseInputsOneOf1ItemsOneOf1Role0 && !IsBaseInputsOneOf1ItemsOneOf1Role1 && IsBaseInputsOneOf1ItemsOneOf1Role2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseInputsOneOf1ItemsOneOf1Role0?, TResult>? baseInputsOneOf1ItemsOneOf1Role0 = null,
            global::System.Func<global::G.BaseInputsOneOf1ItemsOneOf1Role1?, TResult>? baseInputsOneOf1ItemsOneOf1Role1 = null,
            global::System.Func<global::G.BaseInputsOneOf1ItemsOneOf1Role2?, TResult>? baseInputsOneOf1ItemsOneOf1Role2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf1Role0 && baseInputsOneOf1ItemsOneOf1Role0 != null)
            {
                return baseInputsOneOf1ItemsOneOf1Role0(BaseInputsOneOf1ItemsOneOf1Role0!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf1Role1 && baseInputsOneOf1ItemsOneOf1Role1 != null)
            {
                return baseInputsOneOf1ItemsOneOf1Role1(BaseInputsOneOf1ItemsOneOf1Role1!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf1Role2 && baseInputsOneOf1ItemsOneOf1Role2 != null)
            {
                return baseInputsOneOf1ItemsOneOf1Role2(BaseInputsOneOf1ItemsOneOf1Role2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseInputsOneOf1ItemsOneOf1Role0?>? baseInputsOneOf1ItemsOneOf1Role0 = null,
            global::System.Action<global::G.BaseInputsOneOf1ItemsOneOf1Role1?>? baseInputsOneOf1ItemsOneOf1Role1 = null,
            global::System.Action<global::G.BaseInputsOneOf1ItemsOneOf1Role2?>? baseInputsOneOf1ItemsOneOf1Role2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf1Role0)
            {
                baseInputsOneOf1ItemsOneOf1Role0?.Invoke(BaseInputsOneOf1ItemsOneOf1Role0!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf1Role1)
            {
                baseInputsOneOf1ItemsOneOf1Role1?.Invoke(BaseInputsOneOf1ItemsOneOf1Role1!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf1Role2)
            {
                baseInputsOneOf1ItemsOneOf1Role2?.Invoke(BaseInputsOneOf1ItemsOneOf1Role2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsOneOf1ItemsOneOf1Role0,
                typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role0),
                BaseInputsOneOf1ItemsOneOf1Role1,
                typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role1),
                BaseInputsOneOf1ItemsOneOf1Role2,
                typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role2),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf1Role other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseInputsOneOf1ItemsOneOf1Role0?>.Default.Equals(BaseInputsOneOf1ItemsOneOf1Role0, other.BaseInputsOneOf1ItemsOneOf1Role0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseInputsOneOf1ItemsOneOf1Role1?>.Default.Equals(BaseInputsOneOf1ItemsOneOf1Role1, other.BaseInputsOneOf1ItemsOneOf1Role1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseInputsOneOf1ItemsOneOf1Role2?>.Default.Equals(BaseInputsOneOf1ItemsOneOf1Role2, other.BaseInputsOneOf1ItemsOneOf1Role2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf1Role obj1, BaseInputsOneOf1ItemsOneOf1Role obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf1Role>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf1Role obj1, BaseInputsOneOf1ItemsOneOf1Role obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf1Role o && Equals(o);
        }
    }
}
