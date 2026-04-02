//HintName: G.Models.PayloadStorageType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Type of payload storage
    /// </summary>
    public readonly partial struct PayloadStorageType : global::System.IEquatable<PayloadStorageType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadStorageTypeVariant1? PayloadStorageTypeVariant1 { get; init; }
#else
        public global::G.PayloadStorageTypeVariant1? PayloadStorageTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayloadStorageTypeVariant1))]
#endif
        public bool IsPayloadStorageTypeVariant1 => PayloadStorageTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadStorageTypeVariant2? PayloadStorageTypeVariant2 { get; init; }
#else
        public global::G.PayloadStorageTypeVariant2? PayloadStorageTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayloadStorageTypeVariant2))]
#endif
        public bool IsPayloadStorageTypeVariant2 => PayloadStorageTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadStorageTypeVariant3? PayloadStorageTypeVariant3 { get; init; }
#else
        public global::G.PayloadStorageTypeVariant3? PayloadStorageTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayloadStorageTypeVariant3))]
#endif
        public bool IsPayloadStorageTypeVariant3 => PayloadStorageTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadStorageTypeVariant4? PayloadStorageTypeVariant4 { get; init; }
#else
        public global::G.PayloadStorageTypeVariant4? PayloadStorageTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayloadStorageTypeVariant4))]
#endif
        public bool IsPayloadStorageTypeVariant4 => PayloadStorageTypeVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadStorageType(global::G.PayloadStorageTypeVariant1 value) => new PayloadStorageType((global::G.PayloadStorageTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadStorageTypeVariant1?(PayloadStorageType @this) => @this.PayloadStorageTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PayloadStorageType(global::G.PayloadStorageTypeVariant1? value)
        {
            PayloadStorageTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadStorageType(global::G.PayloadStorageTypeVariant2 value) => new PayloadStorageType((global::G.PayloadStorageTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadStorageTypeVariant2?(PayloadStorageType @this) => @this.PayloadStorageTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PayloadStorageType(global::G.PayloadStorageTypeVariant2? value)
        {
            PayloadStorageTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadStorageType(global::G.PayloadStorageTypeVariant3 value) => new PayloadStorageType((global::G.PayloadStorageTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadStorageTypeVariant3?(PayloadStorageType @this) => @this.PayloadStorageTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public PayloadStorageType(global::G.PayloadStorageTypeVariant3? value)
        {
            PayloadStorageTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadStorageType(global::G.PayloadStorageTypeVariant4 value) => new PayloadStorageType((global::G.PayloadStorageTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadStorageTypeVariant4?(PayloadStorageType @this) => @this.PayloadStorageTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public PayloadStorageType(global::G.PayloadStorageTypeVariant4? value)
        {
            PayloadStorageTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadStorageType(
            global::G.PayloadStorageTypeVariant1? payloadStorageTypeVariant1,
            global::G.PayloadStorageTypeVariant2? payloadStorageTypeVariant2,
            global::G.PayloadStorageTypeVariant3? payloadStorageTypeVariant3,
            global::G.PayloadStorageTypeVariant4? payloadStorageTypeVariant4
            )
        {
            PayloadStorageTypeVariant1 = payloadStorageTypeVariant1;
            PayloadStorageTypeVariant2 = payloadStorageTypeVariant2;
            PayloadStorageTypeVariant3 = payloadStorageTypeVariant3;
            PayloadStorageTypeVariant4 = payloadStorageTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PayloadStorageTypeVariant4 as object ??
            PayloadStorageTypeVariant3 as object ??
            PayloadStorageTypeVariant2 as object ??
            PayloadStorageTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PayloadStorageTypeVariant1?.ToString() ??
            PayloadStorageTypeVariant2?.ToString() ??
            PayloadStorageTypeVariant3?.ToString() ??
            PayloadStorageTypeVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPayloadStorageTypeVariant1 && !IsPayloadStorageTypeVariant2 && !IsPayloadStorageTypeVariant3 && !IsPayloadStorageTypeVariant4 || !IsPayloadStorageTypeVariant1 && IsPayloadStorageTypeVariant2 && !IsPayloadStorageTypeVariant3 && !IsPayloadStorageTypeVariant4 || !IsPayloadStorageTypeVariant1 && !IsPayloadStorageTypeVariant2 && IsPayloadStorageTypeVariant3 && !IsPayloadStorageTypeVariant4 || !IsPayloadStorageTypeVariant1 && !IsPayloadStorageTypeVariant2 && !IsPayloadStorageTypeVariant3 && IsPayloadStorageTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PayloadStorageTypeVariant1?, TResult>? payloadStorageTypeVariant1 = null,
            global::System.Func<global::G.PayloadStorageTypeVariant2?, TResult>? payloadStorageTypeVariant2 = null,
            global::System.Func<global::G.PayloadStorageTypeVariant3?, TResult>? payloadStorageTypeVariant3 = null,
            global::System.Func<global::G.PayloadStorageTypeVariant4?, TResult>? payloadStorageTypeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPayloadStorageTypeVariant1 && payloadStorageTypeVariant1 != null)
            {
                return payloadStorageTypeVariant1(PayloadStorageTypeVariant1!);
            }
            else if (IsPayloadStorageTypeVariant2 && payloadStorageTypeVariant2 != null)
            {
                return payloadStorageTypeVariant2(PayloadStorageTypeVariant2!);
            }
            else if (IsPayloadStorageTypeVariant3 && payloadStorageTypeVariant3 != null)
            {
                return payloadStorageTypeVariant3(PayloadStorageTypeVariant3!);
            }
            else if (IsPayloadStorageTypeVariant4 && payloadStorageTypeVariant4 != null)
            {
                return payloadStorageTypeVariant4(PayloadStorageTypeVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PayloadStorageTypeVariant1?>? payloadStorageTypeVariant1 = null,
            global::System.Action<global::G.PayloadStorageTypeVariant2?>? payloadStorageTypeVariant2 = null,
            global::System.Action<global::G.PayloadStorageTypeVariant3?>? payloadStorageTypeVariant3 = null,
            global::System.Action<global::G.PayloadStorageTypeVariant4?>? payloadStorageTypeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPayloadStorageTypeVariant1)
            {
                payloadStorageTypeVariant1?.Invoke(PayloadStorageTypeVariant1!);
            }
            else if (IsPayloadStorageTypeVariant2)
            {
                payloadStorageTypeVariant2?.Invoke(PayloadStorageTypeVariant2!);
            }
            else if (IsPayloadStorageTypeVariant3)
            {
                payloadStorageTypeVariant3?.Invoke(PayloadStorageTypeVariant3!);
            }
            else if (IsPayloadStorageTypeVariant4)
            {
                payloadStorageTypeVariant4?.Invoke(PayloadStorageTypeVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PayloadStorageTypeVariant1,
                typeof(global::G.PayloadStorageTypeVariant1),
                PayloadStorageTypeVariant2,
                typeof(global::G.PayloadStorageTypeVariant2),
                PayloadStorageTypeVariant3,
                typeof(global::G.PayloadStorageTypeVariant3),
                PayloadStorageTypeVariant4,
                typeof(global::G.PayloadStorageTypeVariant4),
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
        public bool Equals(PayloadStorageType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadStorageTypeVariant1?>.Default.Equals(PayloadStorageTypeVariant1, other.PayloadStorageTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadStorageTypeVariant2?>.Default.Equals(PayloadStorageTypeVariant2, other.PayloadStorageTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadStorageTypeVariant3?>.Default.Equals(PayloadStorageTypeVariant3, other.PayloadStorageTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadStorageTypeVariant4?>.Default.Equals(PayloadStorageTypeVariant4, other.PayloadStorageTypeVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadStorageType obj1, PayloadStorageType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadStorageType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadStorageType obj1, PayloadStorageType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadStorageType o && Equals(o);
        }
    }
}
