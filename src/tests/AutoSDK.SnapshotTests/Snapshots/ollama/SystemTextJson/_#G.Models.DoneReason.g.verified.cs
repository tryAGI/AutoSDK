//HintName: G.Models.DoneReason.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Reason why the model is done generating a response.
    /// </summary>
    public readonly partial struct DoneReason : global::System.IEquatable<DoneReason>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DoneReasonVariant1 { get; init; }
#else
        public string? DoneReasonVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoneReasonVariant1))]
#endif
        public bool IsDoneReasonVariant1 => DoneReasonVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DoneReasonEnum? Enum { get; init; }
#else
        public global::G.DoneReasonEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DoneReason(string value) => new DoneReason((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DoneReason @this) => @this.DoneReasonVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DoneReason(string? value)
        {
            DoneReasonVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DoneReason(global::G.DoneReasonEnum value) => new DoneReason((global::G.DoneReasonEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DoneReasonEnum?(DoneReason @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public DoneReason(global::G.DoneReasonEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DoneReason(
            string? doneReasonVariant1,
            global::G.DoneReasonEnum? @enum
            )
        {
            DoneReasonVariant1 = doneReasonVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            DoneReasonVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DoneReasonVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDoneReasonVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? doneReasonVariant1 = null,
            global::System.Func<global::G.DoneReasonEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDoneReasonVariant1 && doneReasonVariant1 != null)
            {
                return doneReasonVariant1(DoneReasonVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? doneReasonVariant1 = null,
            global::System.Action<global::G.DoneReasonEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDoneReasonVariant1)
            {
                doneReasonVariant1?.Invoke(DoneReasonVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DoneReasonVariant1,
                typeof(string),
                Enum,
                typeof(global::G.DoneReasonEnum),
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
        public bool Equals(DoneReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DoneReasonVariant1, other.DoneReasonVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DoneReasonEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DoneReason obj1, DoneReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DoneReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DoneReason obj1, DoneReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DoneReason o && Equals(o);
        }
    }
}
