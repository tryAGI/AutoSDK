//HintName: G.Models.GuardrailDetails.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GuardrailDetails : global::System.IEquatable<GuardrailDetails>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GuardrailSummary? Value1 { get; init; }
#else
        public global::G.GuardrailSummary? Value1 { get; }
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
        public global::G.GuardrailDetailsVariant2? Value2 { get; init; }
#else
        public global::G.GuardrailDetailsVariant2? Value2 { get; }
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
        public static implicit operator GuardrailDetails(global::G.GuardrailSummary value) => new GuardrailDetails((global::G.GuardrailSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GuardrailSummary?(GuardrailDetails @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(global::G.GuardrailSummary? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GuardrailDetails(global::G.GuardrailDetailsVariant2 value) => new GuardrailDetails((global::G.GuardrailDetailsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GuardrailDetailsVariant2?(GuardrailDetails @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(global::G.GuardrailDetailsVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(
            global::G.GuardrailSummary? value1,
            global::G.GuardrailDetailsVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GuardrailSummary?, TResult>? value1 = null,
            global::System.Func<global::G.GuardrailDetailsVariant2?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GuardrailSummary?>? value1 = null,
            global::System.Action<global::G.GuardrailDetailsVariant2?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.GuardrailSummary),
                Value2,
                typeof(global::G.GuardrailDetailsVariant2),
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
        public bool Equals(GuardrailDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GuardrailSummary?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GuardrailDetailsVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GuardrailDetails obj1, GuardrailDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GuardrailDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GuardrailDetails obj1, GuardrailDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailDetails o && Equals(o);
        }
    }
}
