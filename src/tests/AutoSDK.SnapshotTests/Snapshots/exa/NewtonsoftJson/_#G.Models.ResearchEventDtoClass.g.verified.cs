//HintName: G.Models.ResearchEventDtoClass.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClass : global::System.IEquatable<ResearchEventDtoClass>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant1? ResearchEventDtoClassVariant1 { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant1? ResearchEventDtoClassVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchEventDtoClassVariant1))]
#endif
        public bool IsResearchEventDtoClassVariant1 => ResearchEventDtoClassVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2? ResearchEventDtoClassVariant2 { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2? ResearchEventDtoClassVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchEventDtoClassVariant2))]
#endif
        public bool IsResearchEventDtoClassVariant2 => ResearchEventDtoClassVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant3? ResearchEventDtoClassVariant3 { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant3? ResearchEventDtoClassVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResearchEventDtoClassVariant3))]
#endif
        public bool IsResearchEventDtoClassVariant3 => ResearchEventDtoClassVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant1 value) => new ResearchEventDtoClass((global::G.ResearchEventDtoClassVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant1?(ResearchEventDtoClass @this) => @this.ResearchEventDtoClassVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant1? value)
        {
            ResearchEventDtoClassVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant2 value) => new ResearchEventDtoClass((global::G.ResearchEventDtoClassVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2?(ResearchEventDtoClass @this) => @this.ResearchEventDtoClassVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant2? value)
        {
            ResearchEventDtoClassVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant3 value) => new ResearchEventDtoClass((global::G.ResearchEventDtoClassVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant3?(ResearchEventDtoClass @this) => @this.ResearchEventDtoClassVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClass(global::G.ResearchEventDtoClassVariant3? value)
        {
            ResearchEventDtoClassVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClass(
            global::G.ResearchEventDtoClassVariant1? researchEventDtoClassVariant1,
            global::G.ResearchEventDtoClassVariant2? researchEventDtoClassVariant2,
            global::G.ResearchEventDtoClassVariant3? researchEventDtoClassVariant3
            )
        {
            ResearchEventDtoClassVariant1 = researchEventDtoClassVariant1;
            ResearchEventDtoClassVariant2 = researchEventDtoClassVariant2;
            ResearchEventDtoClassVariant3 = researchEventDtoClassVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResearchEventDtoClassVariant3 as object ??
            ResearchEventDtoClassVariant2 as object ??
            ResearchEventDtoClassVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResearchEventDtoClassVariant1?.ToString() ??
            ResearchEventDtoClassVariant2?.ToString() ??
            ResearchEventDtoClassVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResearchEventDtoClassVariant1 && !IsResearchEventDtoClassVariant2 && !IsResearchEventDtoClassVariant3 || !IsResearchEventDtoClassVariant1 && IsResearchEventDtoClassVariant2 && !IsResearchEventDtoClassVariant3 || !IsResearchEventDtoClassVariant1 && !IsResearchEventDtoClassVariant2 && IsResearchEventDtoClassVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant1?, TResult>? researchEventDtoClassVariant1 = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant2?, TResult>? researchEventDtoClassVariant2 = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant3?, TResult>? researchEventDtoClassVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchEventDtoClassVariant1 && researchEventDtoClassVariant1 != null)
            {
                return researchEventDtoClassVariant1(ResearchEventDtoClassVariant1!);
            }
            else if (IsResearchEventDtoClassVariant2 && researchEventDtoClassVariant2 != null)
            {
                return researchEventDtoClassVariant2(ResearchEventDtoClassVariant2!);
            }
            else if (IsResearchEventDtoClassVariant3 && researchEventDtoClassVariant3 != null)
            {
                return researchEventDtoClassVariant3(ResearchEventDtoClassVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant1?>? researchEventDtoClassVariant1 = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant2?>? researchEventDtoClassVariant2 = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant3?>? researchEventDtoClassVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResearchEventDtoClassVariant1)
            {
                researchEventDtoClassVariant1?.Invoke(ResearchEventDtoClassVariant1!);
            }
            else if (IsResearchEventDtoClassVariant2)
            {
                researchEventDtoClassVariant2?.Invoke(ResearchEventDtoClassVariant2!);
            }
            else if (IsResearchEventDtoClassVariant3)
            {
                researchEventDtoClassVariant3?.Invoke(ResearchEventDtoClassVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResearchEventDtoClassVariant1,
                typeof(global::G.ResearchEventDtoClassVariant1),
                ResearchEventDtoClassVariant2,
                typeof(global::G.ResearchEventDtoClassVariant2),
                ResearchEventDtoClassVariant3,
                typeof(global::G.ResearchEventDtoClassVariant3),
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
        public bool Equals(ResearchEventDtoClass other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant1?>.Default.Equals(ResearchEventDtoClassVariant1, other.ResearchEventDtoClassVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2?>.Default.Equals(ResearchEventDtoClassVariant2, other.ResearchEventDtoClassVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant3?>.Default.Equals(ResearchEventDtoClassVariant3, other.ResearchEventDtoClassVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClass obj1, ResearchEventDtoClass obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClass>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClass obj1, ResearchEventDtoClass obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClass o && Equals(o);
        }
    }
}
