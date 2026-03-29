//HintName: G.Models.ResearchEventDtoClassVariant2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClassVariant2 : global::System.IEquatable<ResearchEventDtoClassVariant2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2Variant1? PlanDefinition { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2Variant1? PlanDefinition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlanDefinition))]
#endif
        public bool IsPlanDefinition => PlanDefinition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2Variant2? PlanOperation { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2Variant2? PlanOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlanOperation))]
#endif
        public bool IsPlanOperation => PlanOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2Variant3? PlanOutput { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2Variant3? PlanOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlanOutput))]
#endif
        public bool IsPlanOutput => PlanOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant1 value) => new ResearchEventDtoClassVariant2((global::G.ResearchEventDtoClassVariant2Variant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2Variant1?(ResearchEventDtoClassVariant2 @this) => @this.PlanDefinition;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant1? value)
        {
            PlanDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant2 value) => new ResearchEventDtoClassVariant2((global::G.ResearchEventDtoClassVariant2Variant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2Variant2?(ResearchEventDtoClassVariant2 @this) => @this.PlanOperation;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant2? value)
        {
            PlanOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant3 value) => new ResearchEventDtoClassVariant2((global::G.ResearchEventDtoClassVariant2Variant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2Variant3?(ResearchEventDtoClassVariant2 @this) => @this.PlanOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant2(global::G.ResearchEventDtoClassVariant2Variant3? value)
        {
            PlanOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant2(
            global::G.ResearchEventDtoClassVariant2Variant1? planDefinition,
            global::G.ResearchEventDtoClassVariant2Variant2? planOperation,
            global::G.ResearchEventDtoClassVariant2Variant3? planOutput
            )
        {
            PlanDefinition = planDefinition;
            PlanOperation = planOperation;
            PlanOutput = planOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlanOutput as object ??
            PlanOperation as object ??
            PlanDefinition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlanDefinition?.ToString() ??
            PlanOperation?.ToString() ??
            PlanOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlanDefinition && !IsPlanOperation && !IsPlanOutput || !IsPlanDefinition && IsPlanOperation && !IsPlanOutput || !IsPlanDefinition && !IsPlanOperation && IsPlanOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant2Variant1?, TResult>? planDefinition = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant2Variant2?, TResult>? planOperation = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant2Variant3?, TResult>? planOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlanDefinition && planDefinition != null)
            {
                return planDefinition(PlanDefinition!);
            }
            else if (IsPlanOperation && planOperation != null)
            {
                return planOperation(PlanOperation!);
            }
            else if (IsPlanOutput && planOutput != null)
            {
                return planOutput(PlanOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant2Variant1?>? planDefinition = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant2Variant2?>? planOperation = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant2Variant3?>? planOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlanDefinition)
            {
                planDefinition?.Invoke(PlanDefinition!);
            }
            else if (IsPlanOperation)
            {
                planOperation?.Invoke(PlanOperation!);
            }
            else if (IsPlanOutput)
            {
                planOutput?.Invoke(PlanOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlanDefinition,
                typeof(global::G.ResearchEventDtoClassVariant2Variant1),
                PlanOperation,
                typeof(global::G.ResearchEventDtoClassVariant2Variant2),
                PlanOutput,
                typeof(global::G.ResearchEventDtoClassVariant2Variant3),
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
        public bool Equals(ResearchEventDtoClassVariant2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2Variant1?>.Default.Equals(PlanDefinition, other.PlanDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2Variant2?>.Default.Equals(PlanOperation, other.PlanOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2Variant3?>.Default.Equals(PlanOutput, other.PlanOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClassVariant2 obj1, ResearchEventDtoClassVariant2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClassVariant2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClassVariant2 obj1, ResearchEventDtoClassVariant2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClassVariant2 o && Equals(o);
        }
    }
}
