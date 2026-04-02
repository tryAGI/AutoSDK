//HintName: G.Models.CreateExpressiveResponseDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateExpressiveResponseDto : global::System.IEquatable<CreateExpressiveResponseDto>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateExpressiveResponseDtoVariant1? CreateExpressiveResponseDtoVariant1 { get; init; }
#else
        public global::G.CreateExpressiveResponseDtoVariant1? CreateExpressiveResponseDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateExpressiveResponseDtoVariant1))]
#endif
        public bool IsCreateExpressiveResponseDtoVariant1 => CreateExpressiveResponseDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateExpressiveResponseDtoVariant2? CreateExpressiveResponseDtoVariant2 { get; init; }
#else
        public global::G.CreateExpressiveResponseDtoVariant2? CreateExpressiveResponseDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateExpressiveResponseDtoVariant2))]
#endif
        public bool IsCreateExpressiveResponseDtoVariant2 => CreateExpressiveResponseDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateExpressiveResponseDto(global::G.CreateExpressiveResponseDtoVariant1 value) => new CreateExpressiveResponseDto((global::G.CreateExpressiveResponseDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateExpressiveResponseDtoVariant1?(CreateExpressiveResponseDto @this) => @this.CreateExpressiveResponseDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateExpressiveResponseDto(global::G.CreateExpressiveResponseDtoVariant1? value)
        {
            CreateExpressiveResponseDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateExpressiveResponseDto(global::G.CreateExpressiveResponseDtoVariant2 value) => new CreateExpressiveResponseDto((global::G.CreateExpressiveResponseDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateExpressiveResponseDtoVariant2?(CreateExpressiveResponseDto @this) => @this.CreateExpressiveResponseDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateExpressiveResponseDto(global::G.CreateExpressiveResponseDtoVariant2? value)
        {
            CreateExpressiveResponseDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateExpressiveResponseDto(
            global::G.CreateExpressiveResponseDtoVariant1? createExpressiveResponseDtoVariant1,
            global::G.CreateExpressiveResponseDtoVariant2? createExpressiveResponseDtoVariant2
            )
        {
            CreateExpressiveResponseDtoVariant1 = createExpressiveResponseDtoVariant1;
            CreateExpressiveResponseDtoVariant2 = createExpressiveResponseDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateExpressiveResponseDtoVariant2 as object ??
            CreateExpressiveResponseDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateExpressiveResponseDtoVariant1?.ToString() ??
            CreateExpressiveResponseDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateExpressiveResponseDtoVariant1 && IsCreateExpressiveResponseDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateExpressiveResponseDtoVariant1?, TResult>? createExpressiveResponseDtoVariant1 = null,
            global::System.Func<global::G.CreateExpressiveResponseDtoVariant2?, TResult>? createExpressiveResponseDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateExpressiveResponseDtoVariant1 && createExpressiveResponseDtoVariant1 != null)
            {
                return createExpressiveResponseDtoVariant1(CreateExpressiveResponseDtoVariant1!);
            }
            else if (IsCreateExpressiveResponseDtoVariant2 && createExpressiveResponseDtoVariant2 != null)
            {
                return createExpressiveResponseDtoVariant2(CreateExpressiveResponseDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateExpressiveResponseDtoVariant1?>? createExpressiveResponseDtoVariant1 = null,
            global::System.Action<global::G.CreateExpressiveResponseDtoVariant2?>? createExpressiveResponseDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateExpressiveResponseDtoVariant1)
            {
                createExpressiveResponseDtoVariant1?.Invoke(CreateExpressiveResponseDtoVariant1!);
            }
            else if (IsCreateExpressiveResponseDtoVariant2)
            {
                createExpressiveResponseDtoVariant2?.Invoke(CreateExpressiveResponseDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateExpressiveResponseDtoVariant1,
                typeof(global::G.CreateExpressiveResponseDtoVariant1),
                CreateExpressiveResponseDtoVariant2,
                typeof(global::G.CreateExpressiveResponseDtoVariant2),
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
        public bool Equals(CreateExpressiveResponseDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateExpressiveResponseDtoVariant1?>.Default.Equals(CreateExpressiveResponseDtoVariant1, other.CreateExpressiveResponseDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateExpressiveResponseDtoVariant2?>.Default.Equals(CreateExpressiveResponseDtoVariant2, other.CreateExpressiveResponseDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateExpressiveResponseDto obj1, CreateExpressiveResponseDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateExpressiveResponseDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateExpressiveResponseDto obj1, CreateExpressiveResponseDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateExpressiveResponseDto o && Equals(o);
        }
    }
}
