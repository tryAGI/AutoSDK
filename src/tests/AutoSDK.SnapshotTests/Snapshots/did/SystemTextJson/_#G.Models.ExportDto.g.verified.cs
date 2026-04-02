//HintName: G.Models.ExportDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExportDto : global::System.IEquatable<ExportDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExportDtoVariant1? ExportDtoVariant1 { get; init; }
#else
        public global::G.ExportDtoVariant1? ExportDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExportDtoVariant1))]
#endif
        public bool IsExportDtoVariant1 => ExportDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExportDtoVariant2? ExportDtoVariant2 { get; init; }
#else
        public global::G.ExportDtoVariant2? ExportDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExportDtoVariant2))]
#endif
        public bool IsExportDtoVariant2 => ExportDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportDto(global::G.ExportDtoVariant1 value) => new ExportDto((global::G.ExportDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExportDtoVariant1?(ExportDto @this) => @this.ExportDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ExportDto(global::G.ExportDtoVariant1? value)
        {
            ExportDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportDto(global::G.ExportDtoVariant2 value) => new ExportDto((global::G.ExportDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExportDtoVariant2?(ExportDto @this) => @this.ExportDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ExportDto(global::G.ExportDtoVariant2? value)
        {
            ExportDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExportDto(
            global::G.ExportDtoVariant1? exportDtoVariant1,
            global::G.ExportDtoVariant2? exportDtoVariant2
            )
        {
            ExportDtoVariant1 = exportDtoVariant1;
            ExportDtoVariant2 = exportDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExportDtoVariant2 as object ??
            ExportDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExportDtoVariant1?.ToString() ??
            ExportDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExportDtoVariant1 && IsExportDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExportDtoVariant1?, TResult>? exportDtoVariant1 = null,
            global::System.Func<global::G.ExportDtoVariant2?, TResult>? exportDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExportDtoVariant1 && exportDtoVariant1 != null)
            {
                return exportDtoVariant1(ExportDtoVariant1!);
            }
            else if (IsExportDtoVariant2 && exportDtoVariant2 != null)
            {
                return exportDtoVariant2(ExportDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExportDtoVariant1?>? exportDtoVariant1 = null,
            global::System.Action<global::G.ExportDtoVariant2?>? exportDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExportDtoVariant1)
            {
                exportDtoVariant1?.Invoke(ExportDtoVariant1!);
            }
            else if (IsExportDtoVariant2)
            {
                exportDtoVariant2?.Invoke(ExportDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExportDtoVariant1,
                typeof(global::G.ExportDtoVariant1),
                ExportDtoVariant2,
                typeof(global::G.ExportDtoVariant2),
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
        public bool Equals(ExportDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExportDtoVariant1?>.Default.Equals(ExportDtoVariant1, other.ExportDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExportDtoVariant2?>.Default.Equals(ExportDtoVariant2, other.ExportDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExportDto obj1, ExportDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExportDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExportDto obj1, ExportDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExportDto o && Equals(o);
        }
    }
}
