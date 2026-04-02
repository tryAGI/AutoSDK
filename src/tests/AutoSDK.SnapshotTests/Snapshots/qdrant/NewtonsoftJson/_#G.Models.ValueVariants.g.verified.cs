//HintName: G.Models.ValueVariants.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ValueVariants : global::System.IEquatable<ValueVariants>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ValueVariantsVariant1 { get; init; }
#else
        public string? ValueVariantsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ValueVariantsVariant1))]
#endif
        public bool IsValueVariantsVariant1 => ValueVariantsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public long? ValueVariantsVariant2 { get; init; }
#else
        public long? ValueVariantsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ValueVariantsVariant2))]
#endif
        public bool IsValueVariantsVariant2 => ValueVariantsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? ValueVariantsVariant3 { get; init; }
#else
        public bool? ValueVariantsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ValueVariantsVariant3))]
#endif
        public bool IsValueVariantsVariant3 => ValueVariantsVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueVariants(string value) => new ValueVariants((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ValueVariants @this) => @this.ValueVariantsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ValueVariants(string? value)
        {
            ValueVariantsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueVariants(long value) => new ValueVariants((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(ValueVariants @this) => @this.ValueVariantsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ValueVariants(long? value)
        {
            ValueVariantsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueVariants(bool value) => new ValueVariants((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(ValueVariants @this) => @this.ValueVariantsVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ValueVariants(bool? value)
        {
            ValueVariantsVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ValueVariants(
            string? valueVariantsVariant1,
            long? valueVariantsVariant2,
            bool? valueVariantsVariant3
            )
        {
            ValueVariantsVariant1 = valueVariantsVariant1;
            ValueVariantsVariant2 = valueVariantsVariant2;
            ValueVariantsVariant3 = valueVariantsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ValueVariantsVariant3 as object ??
            ValueVariantsVariant2 as object ??
            ValueVariantsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ValueVariantsVariant1?.ToString() ??
            ValueVariantsVariant2?.ToString() ??
            ValueVariantsVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValueVariantsVariant1 || IsValueVariantsVariant2 || IsValueVariantsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? valueVariantsVariant1 = null,
            global::System.Func<long?, TResult>? valueVariantsVariant2 = null,
            global::System.Func<bool?, TResult>? valueVariantsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValueVariantsVariant1 && valueVariantsVariant1 != null)
            {
                return valueVariantsVariant1(ValueVariantsVariant1!);
            }
            else if (IsValueVariantsVariant2 && valueVariantsVariant2 != null)
            {
                return valueVariantsVariant2(ValueVariantsVariant2!);
            }
            else if (IsValueVariantsVariant3 && valueVariantsVariant3 != null)
            {
                return valueVariantsVariant3(ValueVariantsVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? valueVariantsVariant1 = null,
            global::System.Action<long?>? valueVariantsVariant2 = null,
            global::System.Action<bool?>? valueVariantsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValueVariantsVariant1)
            {
                valueVariantsVariant1?.Invoke(ValueVariantsVariant1!);
            }
            else if (IsValueVariantsVariant2)
            {
                valueVariantsVariant2?.Invoke(ValueVariantsVariant2!);
            }
            else if (IsValueVariantsVariant3)
            {
                valueVariantsVariant3?.Invoke(ValueVariantsVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ValueVariantsVariant1,
                typeof(string),
                ValueVariantsVariant2,
                typeof(long),
                ValueVariantsVariant3,
                typeof(bool),
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
        public bool Equals(ValueVariants other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ValueVariantsVariant1, other.ValueVariantsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(ValueVariantsVariant2, other.ValueVariantsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ValueVariantsVariant3, other.ValueVariantsVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ValueVariants obj1, ValueVariants obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ValueVariants>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ValueVariants obj1, ValueVariants obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ValueVariants o && Equals(o);
        }
    }
}
