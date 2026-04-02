//HintName: G.Models.WebSearchTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A web search tool that searches the internet for relevant information.
    /// </summary>
    public readonly partial struct WebSearchTool : global::System.IEquatable<WebSearchTool>
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
        public global::G.WebSearchToolVariant2? WebSearchToolVariant2 { get; init; }
#else
        public global::G.WebSearchToolVariant2? WebSearchToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolVariant2))]
#endif
        public bool IsWebSearchToolVariant2 => WebSearchToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchTool(global::G.ToolBase value) => new WebSearchTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(WebSearchTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchTool(global::G.WebSearchToolVariant2 value) => new WebSearchTool((global::G.WebSearchToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolVariant2?(WebSearchTool @this) => @this.WebSearchToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchTool(global::G.WebSearchToolVariant2? value)
        {
            WebSearchToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSearchTool(
            global::G.ToolBase? @base,
            global::G.WebSearchToolVariant2? webSearchToolVariant2
            )
        {
            Base = @base;
            WebSearchToolVariant2 = webSearchToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WebSearchToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWebSearchToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.WebSearchToolVariant2?, TResult>? webSearchToolVariant2 = null,
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
            else if (IsWebSearchToolVariant2 && webSearchToolVariant2 != null)
            {
                return webSearchToolVariant2(WebSearchToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.WebSearchToolVariant2?>? webSearchToolVariant2 = null,
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
            else if (IsWebSearchToolVariant2)
            {
                webSearchToolVariant2?.Invoke(WebSearchToolVariant2!);
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
                WebSearchToolVariant2,
                typeof(global::G.WebSearchToolVariant2),
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
        public bool Equals(WebSearchTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolVariant2?>.Default.Equals(WebSearchToolVariant2, other.WebSearchToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSearchTool obj1, WebSearchTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSearchTool obj1, WebSearchTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchTool o && Equals(o);
        }
    }
}
