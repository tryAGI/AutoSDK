//HintName: G.Models.StructuredIndexingTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that indexes structured documents into the Vectara platform with full control over document structure, sections, metadata, tables, and images.
    /// </summary>
    public readonly partial struct StructuredIndexingTool : global::System.IEquatable<StructuredIndexingTool>
    {
        /// <summary>
        /// Base properties shared by all tool types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolBase? Base { get; init; }
#else
        public global::G.ToolBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StructuredIndexingToolVariant2? StructuredIndexingToolVariant2 { get; init; }
#else
        public global::G.StructuredIndexingToolVariant2? StructuredIndexingToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexingToolVariant2))]
#endif
        public bool IsStructuredIndexingToolVariant2 => StructuredIndexingToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingTool(global::G.ToolBase value) => new StructuredIndexingTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(StructuredIndexingTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingTool(global::G.StructuredIndexingToolVariant2 value) => new StructuredIndexingTool((global::G.StructuredIndexingToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredIndexingToolVariant2?(StructuredIndexingTool @this) => @this.StructuredIndexingToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(global::G.StructuredIndexingToolVariant2? value)
        {
            StructuredIndexingToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(
            global::G.ToolBase? @base,
            global::G.StructuredIndexingToolVariant2? structuredIndexingToolVariant2
            )
        {
            Base = @base;
            StructuredIndexingToolVariant2 = structuredIndexingToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StructuredIndexingToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            StructuredIndexingToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStructuredIndexingToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.StructuredIndexingToolVariant2?, TResult>? structuredIndexingToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsStructuredIndexingToolVariant2 && structuredIndexingToolVariant2 != null)
            {
                return structuredIndexingToolVariant2(StructuredIndexingToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.StructuredIndexingToolVariant2?>? structuredIndexingToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsStructuredIndexingToolVariant2)
            {
                structuredIndexingToolVariant2?.Invoke(StructuredIndexingToolVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.ToolBase),
                StructuredIndexingToolVariant2,
                typeof(global::G.StructuredIndexingToolVariant2),
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
        public bool Equals(StructuredIndexingTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredIndexingToolVariant2?>.Default.Equals(StructuredIndexingToolVariant2, other.StructuredIndexingToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StructuredIndexingTool obj1, StructuredIndexingTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StructuredIndexingTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StructuredIndexingTool obj1, StructuredIndexingTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StructuredIndexingTool o && Equals(o);
        }
    }
}
