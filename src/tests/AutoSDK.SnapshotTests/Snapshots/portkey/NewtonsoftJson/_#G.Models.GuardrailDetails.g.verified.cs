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
        public global::G.GuardrailSummary? Summary { get; init; }
#else
        public global::G.GuardrailSummary? Summary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GuardrailDetailsVariant2? GuardrailDetailsVariant2 { get; init; }
#else
        public global::G.GuardrailDetailsVariant2? GuardrailDetailsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GuardrailDetailsVariant2))]
#endif
        public bool IsGuardrailDetailsVariant2 => GuardrailDetailsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GuardrailDetails(global::G.GuardrailSummary value) => new GuardrailDetails((global::G.GuardrailSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GuardrailSummary?(GuardrailDetails @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(global::G.GuardrailSummary? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GuardrailDetails(global::G.GuardrailDetailsVariant2 value) => new GuardrailDetails((global::G.GuardrailDetailsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GuardrailDetailsVariant2?(GuardrailDetails @this) => @this.GuardrailDetailsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(global::G.GuardrailDetailsVariant2? value)
        {
            GuardrailDetailsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GuardrailDetails(
            global::G.GuardrailSummary? summary,
            global::G.GuardrailDetailsVariant2? guardrailDetailsVariant2
            )
        {
            Summary = summary;
            GuardrailDetailsVariant2 = guardrailDetailsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GuardrailDetailsVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            GuardrailDetailsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsGuardrailDetailsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GuardrailSummary?, TResult>? summary = null,
            global::System.Func<global::G.GuardrailDetailsVariant2?, TResult>? guardrailDetailsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary && summary != null)
            {
                return summary(Summary!);
            }
            else if (IsGuardrailDetailsVariant2 && guardrailDetailsVariant2 != null)
            {
                return guardrailDetailsVariant2(GuardrailDetailsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GuardrailSummary?>? summary = null,
            global::System.Action<global::G.GuardrailDetailsVariant2?>? guardrailDetailsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary)
            {
                summary?.Invoke(Summary!);
            }
            else if (IsGuardrailDetailsVariant2)
            {
                guardrailDetailsVariant2?.Invoke(GuardrailDetailsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summary,
                typeof(global::G.GuardrailSummary),
                GuardrailDetailsVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.GuardrailSummary?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GuardrailDetailsVariant2?>.Default.Equals(GuardrailDetailsVariant2, other.GuardrailDetailsVariant2) 
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
