//HintName: G.Models.ResearchEventDtoClassVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClassVariant1 : global::System.IEquatable<ResearchEventDtoClassVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant1Variant1? ResearchDefinition { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant1Variant1? ResearchDefinition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchDefinition))]
#endif
        public bool IsResearchDefinition => ResearchDefinition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant1Variant2? ResearchOutput { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant1Variant2? ResearchOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchOutput))]
#endif
        public bool IsResearchOutput => ResearchOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant1(global::G.ResearchEventDtoClassVariant1Variant1 value) => new ResearchEventDtoClassVariant1((global::G.ResearchEventDtoClassVariant1Variant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant1Variant1?(ResearchEventDtoClassVariant1 @this) => @this.ResearchDefinition;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(global::G.ResearchEventDtoClassVariant1Variant1? value)
        {
            ResearchDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant1(global::G.ResearchEventDtoClassVariant1Variant2 value) => new ResearchEventDtoClassVariant1((global::G.ResearchEventDtoClassVariant1Variant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant1Variant2?(ResearchEventDtoClassVariant1 @this) => @this.ResearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(global::G.ResearchEventDtoClassVariant1Variant2? value)
        {
            ResearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant1(
            global::G.ResearchEventDtoClassVariant1Variant1? researchDefinition,
            global::G.ResearchEventDtoClassVariant1Variant2? researchOutput
            )
        {
            ResearchDefinition = researchDefinition;
            ResearchOutput = researchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResearchOutput as object ??
            ResearchDefinition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResearchDefinition?.ToString() ??
            ResearchOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResearchDefinition && !IsResearchOutput || !IsResearchDefinition && IsResearchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant1Variant1?, TResult>? researchDefinition = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant1Variant2?, TResult>? researchOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchDefinition && researchDefinition != null)
            {
                return researchDefinition(ResearchDefinition!);
            }
            else if (IsResearchOutput && researchOutput != null)
            {
                return researchOutput(ResearchOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant1Variant1?>? researchDefinition = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant1Variant2?>? researchOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchDefinition)
            {
                researchDefinition?.Invoke(ResearchDefinition!);
            }
            else if (IsResearchOutput)
            {
                researchOutput?.Invoke(ResearchOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResearchDefinition,
                typeof(global::G.ResearchEventDtoClassVariant1Variant1),
                ResearchOutput,
                typeof(global::G.ResearchEventDtoClassVariant1Variant2),
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
        public bool Equals(ResearchEventDtoClassVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant1Variant1?>.Default.Equals(ResearchDefinition, other.ResearchDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant1Variant2?>.Default.Equals(ResearchOutput, other.ResearchOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClassVariant1 obj1, ResearchEventDtoClassVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClassVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClassVariant1 obj1, ResearchEventDtoClassVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClassVariant1 o && Equals(o);
        }
    }
}
