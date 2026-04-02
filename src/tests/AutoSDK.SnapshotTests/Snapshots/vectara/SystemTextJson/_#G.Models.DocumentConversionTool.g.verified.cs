//HintName: G.Models.DocumentConversionTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that converts document artifacts (PDF, Word, PowerPoint, etc.) to various formats.
    /// </summary>
    public readonly partial struct DocumentConversionTool : global::System.IEquatable<DocumentConversionTool>
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
        public global::G.DocumentConversionToolVariant2? DocumentConversionToolVariant2 { get; init; }
#else
        public global::G.DocumentConversionToolVariant2? DocumentConversionToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversionToolVariant2))]
#endif
        public bool IsDocumentConversionToolVariant2 => DocumentConversionToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionTool(global::G.ToolBase value) => new DocumentConversionTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(DocumentConversionTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionTool(global::G.DocumentConversionToolVariant2 value) => new DocumentConversionTool((global::G.DocumentConversionToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DocumentConversionToolVariant2?(DocumentConversionTool @this) => @this.DocumentConversionToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(global::G.DocumentConversionToolVariant2? value)
        {
            DocumentConversionToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(
            global::G.ToolBase? @base,
            global::G.DocumentConversionToolVariant2? documentConversionToolVariant2
            )
        {
            Base = @base;
            DocumentConversionToolVariant2 = documentConversionToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentConversionToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DocumentConversionToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDocumentConversionToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.DocumentConversionToolVariant2?, TResult>? documentConversionToolVariant2 = null,
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
            else if (IsDocumentConversionToolVariant2 && documentConversionToolVariant2 != null)
            {
                return documentConversionToolVariant2(DocumentConversionToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.DocumentConversionToolVariant2?>? documentConversionToolVariant2 = null,
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
            else if (IsDocumentConversionToolVariant2)
            {
                documentConversionToolVariant2?.Invoke(DocumentConversionToolVariant2!);
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
                DocumentConversionToolVariant2,
                typeof(global::G.DocumentConversionToolVariant2),
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
        public bool Equals(DocumentConversionTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DocumentConversionToolVariant2?>.Default.Equals(DocumentConversionToolVariant2, other.DocumentConversionToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentConversionTool obj1, DocumentConversionTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentConversionTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentConversionTool obj1, DocumentConversionTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentConversionTool o && Equals(o);
        }
    }
}
