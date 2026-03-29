//HintName: G.Models.Provider.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Provider : global::System.IEquatable<Provider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderName? Value1 { get; init; }
#else
        public global::G.ProviderName? Value1 { get; }
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
        public global::G.ModelProviderName? Value2 { get; init; }
#else
        public global::G.ModelProviderName? Value2 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ProviderEnum? Value3 { get; init; }
#else
        public global::G.ProviderEnum? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ProviderName value) => new Provider((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(Provider @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ProviderName? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ModelProviderName value) => new Provider((global::G.ModelProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelProviderName?(Provider @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ModelProviderName? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ProviderEnum value) => new Provider((global::G.ProviderEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderEnum?(Provider @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ProviderEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Provider(
            global::G.ProviderName? value1,
            global::G.ModelProviderName? value2,
            global::G.ProviderEnum? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToValueString() ??
            Value3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? value1 = null,
            global::System.Func<global::G.ModelProviderName?, TResult>? value2 = null,
            global::System.Func<global::G.ProviderEnum?, TResult>? value3 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? value1 = null,
            global::System.Action<global::G.ModelProviderName?>? value2 = null,
            global::System.Action<global::G.ProviderEnum?>? value3 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                typeof(global::G.ProviderName),
                Value2,
                typeof(global::G.ModelProviderName),
                Value3,
                typeof(global::G.ProviderEnum),
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
        public bool Equals(Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelProviderName?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderEnum?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Provider obj1, Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Provider obj1, Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider o && Equals(o);
        }
    }
}
