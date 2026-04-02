//HintName: G.Models.GetDocumentTextTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that fetches the full text content of a document from a corpus and stores it as an artifact.
    /// </summary>
    public readonly partial struct GetDocumentTextTool : global::System.IEquatable<GetDocumentTextTool>
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
        public global::G.GetDocumentTextToolVariant2? GetDocumentTextToolVariant2 { get; init; }
#else
        public global::G.GetDocumentTextToolVariant2? GetDocumentTextToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetDocumentTextToolVariant2))]
#endif
        public bool IsGetDocumentTextToolVariant2 => GetDocumentTextToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentTextTool(global::G.ToolBase value) => new GetDocumentTextTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(GetDocumentTextTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentTextTool(global::G.GetDocumentTextToolVariant2 value) => new GetDocumentTextTool((global::G.GetDocumentTextToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetDocumentTextToolVariant2?(GetDocumentTextTool @this) => @this.GetDocumentTextToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextTool(global::G.GetDocumentTextToolVariant2? value)
        {
            GetDocumentTextToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextTool(
            global::G.ToolBase? @base,
            global::G.GetDocumentTextToolVariant2? getDocumentTextToolVariant2
            )
        {
            Base = @base;
            GetDocumentTextToolVariant2 = getDocumentTextToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetDocumentTextToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GetDocumentTextToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGetDocumentTextToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.GetDocumentTextToolVariant2?, TResult>? getDocumentTextToolVariant2 = null,
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
            else if (IsGetDocumentTextToolVariant2 && getDocumentTextToolVariant2 != null)
            {
                return getDocumentTextToolVariant2(GetDocumentTextToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.GetDocumentTextToolVariant2?>? getDocumentTextToolVariant2 = null,
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
            else if (IsGetDocumentTextToolVariant2)
            {
                getDocumentTextToolVariant2?.Invoke(GetDocumentTextToolVariant2!);
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
                GetDocumentTextToolVariant2,
                typeof(global::G.GetDocumentTextToolVariant2),
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
        public bool Equals(GetDocumentTextTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetDocumentTextToolVariant2?>.Default.Equals(GetDocumentTextToolVariant2, other.GetDocumentTextToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetDocumentTextTool obj1, GetDocumentTextTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetDocumentTextTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetDocumentTextTool obj1, GetDocumentTextTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetDocumentTextTool o && Equals(o);
        }
    }
}
