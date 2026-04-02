//HintName: G.Models.CreateDocumentDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateDocumentDto : global::System.IEquatable<CreateDocumentDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDocumentDtoVariant1? CreateDocumentDtoVariant1 { get; init; }
#else
        public global::G.CreateDocumentDtoVariant1? CreateDocumentDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateDocumentDtoVariant1))]
#endif
        public bool IsCreateDocumentDtoVariant1 => CreateDocumentDtoVariant1 != null;

        /// <summary>
        /// Construct a type with the properties of T except for those in type K.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDocumentDtoVariant2? CreateDocumentDtoVariant2 { get; init; }
#else
        public global::G.CreateDocumentDtoVariant2? CreateDocumentDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateDocumentDtoVariant2))]
#endif
        public bool IsCreateDocumentDtoVariant2 => CreateDocumentDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentDto(global::G.CreateDocumentDtoVariant1 value) => new CreateDocumentDto((global::G.CreateDocumentDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDocumentDtoVariant1?(CreateDocumentDto @this) => @this.CreateDocumentDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentDto(global::G.CreateDocumentDtoVariant1? value)
        {
            CreateDocumentDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentDto(global::G.CreateDocumentDtoVariant2 value) => new CreateDocumentDto((global::G.CreateDocumentDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDocumentDtoVariant2?(CreateDocumentDto @this) => @this.CreateDocumentDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentDto(global::G.CreateDocumentDtoVariant2? value)
        {
            CreateDocumentDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentDto(
            global::G.CreateDocumentDtoVariant1? createDocumentDtoVariant1,
            global::G.CreateDocumentDtoVariant2? createDocumentDtoVariant2
            )
        {
            CreateDocumentDtoVariant1 = createDocumentDtoVariant1;
            CreateDocumentDtoVariant2 = createDocumentDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateDocumentDtoVariant2 as object ??
            CreateDocumentDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateDocumentDtoVariant1?.ToString() ??
            CreateDocumentDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateDocumentDtoVariant1 && IsCreateDocumentDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateDocumentDtoVariant1?, TResult>? createDocumentDtoVariant1 = null,
            global::System.Func<global::G.CreateDocumentDtoVariant2?, TResult>? createDocumentDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateDocumentDtoVariant1 && createDocumentDtoVariant1 != null)
            {
                return createDocumentDtoVariant1(CreateDocumentDtoVariant1!);
            }
            else if (IsCreateDocumentDtoVariant2 && createDocumentDtoVariant2 != null)
            {
                return createDocumentDtoVariant2(CreateDocumentDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateDocumentDtoVariant1?>? createDocumentDtoVariant1 = null,
            global::System.Action<global::G.CreateDocumentDtoVariant2?>? createDocumentDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateDocumentDtoVariant1)
            {
                createDocumentDtoVariant1?.Invoke(CreateDocumentDtoVariant1!);
            }
            else if (IsCreateDocumentDtoVariant2)
            {
                createDocumentDtoVariant2?.Invoke(CreateDocumentDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateDocumentDtoVariant1,
                typeof(global::G.CreateDocumentDtoVariant1),
                CreateDocumentDtoVariant2,
                typeof(global::G.CreateDocumentDtoVariant2),
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
        public bool Equals(CreateDocumentDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDocumentDtoVariant1?>.Default.Equals(CreateDocumentDtoVariant1, other.CreateDocumentDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDocumentDtoVariant2?>.Default.Equals(CreateDocumentDtoVariant2, other.CreateDocumentDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateDocumentDto obj1, CreateDocumentDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateDocumentDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateDocumentDto obj1, CreateDocumentDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateDocumentDto o && Equals(o);
        }
    }
}
