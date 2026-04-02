//HintName: G.Models.LLMConfigCreateDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LLMConfigCreateDto : global::System.IEquatable<LLMConfigCreateDto>
    {
        /// <summary>
        /// Create-request shapes: `provider` is required. Plain interfaces (no Omit/Pick) so TSOA can generate routes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant1? LLMConfigCreateDtoVariant1 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant1? LLMConfigCreateDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant1))]
#endif
        public bool IsLLMConfigCreateDtoVariant1 => LLMConfigCreateDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant2? LLMConfigCreateDtoVariant2 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant2? LLMConfigCreateDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant2))]
#endif
        public bool IsLLMConfigCreateDtoVariant2 => LLMConfigCreateDtoVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant3? LLMConfigCreateDtoVariant3 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant3? LLMConfigCreateDtoVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant3))]
#endif
        public bool IsLLMConfigCreateDtoVariant3 => LLMConfigCreateDtoVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant4? LLMConfigCreateDtoVariant4 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant4? LLMConfigCreateDtoVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant4))]
#endif
        public bool IsLLMConfigCreateDtoVariant4 => LLMConfigCreateDtoVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant5? LLMConfigCreateDtoVariant5 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant5? LLMConfigCreateDtoVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant5))]
#endif
        public bool IsLLMConfigCreateDtoVariant5 => LLMConfigCreateDtoVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigCreateDtoVariant6? LLMConfigCreateDtoVariant6 { get; init; }
#else
        public global::G.LLMConfigCreateDtoVariant6? LLMConfigCreateDtoVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigCreateDtoVariant6))]
#endif
        public bool IsLLMConfigCreateDtoVariant6 => LLMConfigCreateDtoVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant1 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant1?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant1? value)
        {
            LLMConfigCreateDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant2 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant2?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant2? value)
        {
            LLMConfigCreateDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant3 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant3?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant3;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant3? value)
        {
            LLMConfigCreateDtoVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant4 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant4?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant4;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant4? value)
        {
            LLMConfigCreateDtoVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant5 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant5?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant5;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant5? value)
        {
            LLMConfigCreateDtoVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant6 value) => new LLMConfigCreateDto((global::G.LLMConfigCreateDtoVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigCreateDtoVariant6?(LLMConfigCreateDto @this) => @this.LLMConfigCreateDtoVariant6;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::G.LLMConfigCreateDtoVariant6? value)
        {
            LLMConfigCreateDtoVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(
            global::G.LLMConfigCreateDtoVariant1? lLMConfigCreateDtoVariant1,
            global::G.LLMConfigCreateDtoVariant2? lLMConfigCreateDtoVariant2,
            global::G.LLMConfigCreateDtoVariant3? lLMConfigCreateDtoVariant3,
            global::G.LLMConfigCreateDtoVariant4? lLMConfigCreateDtoVariant4,
            global::G.LLMConfigCreateDtoVariant5? lLMConfigCreateDtoVariant5,
            global::G.LLMConfigCreateDtoVariant6? lLMConfigCreateDtoVariant6
            )
        {
            LLMConfigCreateDtoVariant1 = lLMConfigCreateDtoVariant1;
            LLMConfigCreateDtoVariant2 = lLMConfigCreateDtoVariant2;
            LLMConfigCreateDtoVariant3 = lLMConfigCreateDtoVariant3;
            LLMConfigCreateDtoVariant4 = lLMConfigCreateDtoVariant4;
            LLMConfigCreateDtoVariant5 = lLMConfigCreateDtoVariant5;
            LLMConfigCreateDtoVariant6 = lLMConfigCreateDtoVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LLMConfigCreateDtoVariant6 as object ??
            LLMConfigCreateDtoVariant5 as object ??
            LLMConfigCreateDtoVariant4 as object ??
            LLMConfigCreateDtoVariant3 as object ??
            LLMConfigCreateDtoVariant2 as object ??
            LLMConfigCreateDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LLMConfigCreateDtoVariant1?.ToString() ??
            LLMConfigCreateDtoVariant2?.ToString() ??
            LLMConfigCreateDtoVariant3?.ToString() ??
            LLMConfigCreateDtoVariant4?.ToString() ??
            LLMConfigCreateDtoVariant5?.ToString() ??
            LLMConfigCreateDtoVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLLMConfigCreateDtoVariant1 || IsLLMConfigCreateDtoVariant2 || IsLLMConfigCreateDtoVariant3 || IsLLMConfigCreateDtoVariant4 || IsLLMConfigCreateDtoVariant5 || IsLLMConfigCreateDtoVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LLMConfigCreateDtoVariant1?, TResult>? lLMConfigCreateDtoVariant1 = null,
            global::System.Func<global::G.LLMConfigCreateDtoVariant2?, TResult>? lLMConfigCreateDtoVariant2 = null,
            global::System.Func<global::G.LLMConfigCreateDtoVariant3?, TResult>? lLMConfigCreateDtoVariant3 = null,
            global::System.Func<global::G.LLMConfigCreateDtoVariant4?, TResult>? lLMConfigCreateDtoVariant4 = null,
            global::System.Func<global::G.LLMConfigCreateDtoVariant5?, TResult>? lLMConfigCreateDtoVariant5 = null,
            global::System.Func<global::G.LLMConfigCreateDtoVariant6?, TResult>? lLMConfigCreateDtoVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLLMConfigCreateDtoVariant1 && lLMConfigCreateDtoVariant1 != null)
            {
                return lLMConfigCreateDtoVariant1(LLMConfigCreateDtoVariant1!);
            }
            else if (IsLLMConfigCreateDtoVariant2 && lLMConfigCreateDtoVariant2 != null)
            {
                return lLMConfigCreateDtoVariant2(LLMConfigCreateDtoVariant2!);
            }
            else if (IsLLMConfigCreateDtoVariant3 && lLMConfigCreateDtoVariant3 != null)
            {
                return lLMConfigCreateDtoVariant3(LLMConfigCreateDtoVariant3!);
            }
            else if (IsLLMConfigCreateDtoVariant4 && lLMConfigCreateDtoVariant4 != null)
            {
                return lLMConfigCreateDtoVariant4(LLMConfigCreateDtoVariant4!);
            }
            else if (IsLLMConfigCreateDtoVariant5 && lLMConfigCreateDtoVariant5 != null)
            {
                return lLMConfigCreateDtoVariant5(LLMConfigCreateDtoVariant5!);
            }
            else if (IsLLMConfigCreateDtoVariant6 && lLMConfigCreateDtoVariant6 != null)
            {
                return lLMConfigCreateDtoVariant6(LLMConfigCreateDtoVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LLMConfigCreateDtoVariant1?>? lLMConfigCreateDtoVariant1 = null,
            global::System.Action<global::G.LLMConfigCreateDtoVariant2?>? lLMConfigCreateDtoVariant2 = null,
            global::System.Action<global::G.LLMConfigCreateDtoVariant3?>? lLMConfigCreateDtoVariant3 = null,
            global::System.Action<global::G.LLMConfigCreateDtoVariant4?>? lLMConfigCreateDtoVariant4 = null,
            global::System.Action<global::G.LLMConfigCreateDtoVariant5?>? lLMConfigCreateDtoVariant5 = null,
            global::System.Action<global::G.LLMConfigCreateDtoVariant6?>? lLMConfigCreateDtoVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLLMConfigCreateDtoVariant1)
            {
                lLMConfigCreateDtoVariant1?.Invoke(LLMConfigCreateDtoVariant1!);
            }
            else if (IsLLMConfigCreateDtoVariant2)
            {
                lLMConfigCreateDtoVariant2?.Invoke(LLMConfigCreateDtoVariant2!);
            }
            else if (IsLLMConfigCreateDtoVariant3)
            {
                lLMConfigCreateDtoVariant3?.Invoke(LLMConfigCreateDtoVariant3!);
            }
            else if (IsLLMConfigCreateDtoVariant4)
            {
                lLMConfigCreateDtoVariant4?.Invoke(LLMConfigCreateDtoVariant4!);
            }
            else if (IsLLMConfigCreateDtoVariant5)
            {
                lLMConfigCreateDtoVariant5?.Invoke(LLMConfigCreateDtoVariant5!);
            }
            else if (IsLLMConfigCreateDtoVariant6)
            {
                lLMConfigCreateDtoVariant6?.Invoke(LLMConfigCreateDtoVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LLMConfigCreateDtoVariant1,
                typeof(global::G.LLMConfigCreateDtoVariant1),
                LLMConfigCreateDtoVariant2,
                typeof(global::G.LLMConfigCreateDtoVariant2),
                LLMConfigCreateDtoVariant3,
                typeof(global::G.LLMConfigCreateDtoVariant3),
                LLMConfigCreateDtoVariant4,
                typeof(global::G.LLMConfigCreateDtoVariant4),
                LLMConfigCreateDtoVariant5,
                typeof(global::G.LLMConfigCreateDtoVariant5),
                LLMConfigCreateDtoVariant6,
                typeof(global::G.LLMConfigCreateDtoVariant6),
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
        public bool Equals(LLMConfigCreateDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant1?>.Default.Equals(LLMConfigCreateDtoVariant1, other.LLMConfigCreateDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant2?>.Default.Equals(LLMConfigCreateDtoVariant2, other.LLMConfigCreateDtoVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant3?>.Default.Equals(LLMConfigCreateDtoVariant3, other.LLMConfigCreateDtoVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant4?>.Default.Equals(LLMConfigCreateDtoVariant4, other.LLMConfigCreateDtoVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant5?>.Default.Equals(LLMConfigCreateDtoVariant5, other.LLMConfigCreateDtoVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigCreateDtoVariant6?>.Default.Equals(LLMConfigCreateDtoVariant6, other.LLMConfigCreateDtoVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LLMConfigCreateDto obj1, LLMConfigCreateDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LLMConfigCreateDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LLMConfigCreateDto obj1, LLMConfigCreateDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LLMConfigCreateDto o && Equals(o);
        }
    }
}
