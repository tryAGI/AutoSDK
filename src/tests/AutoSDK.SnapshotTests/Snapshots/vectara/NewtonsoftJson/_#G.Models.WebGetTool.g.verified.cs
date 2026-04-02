//HintName: G.Models.WebGetTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A web get tool that fetches content from URLs using HTTP requests.
    /// </summary>
    public readonly partial struct WebGetTool : global::System.IEquatable<WebGetTool>
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
        public global::G.WebGetToolVariant2? WebGetToolVariant2 { get; init; }
#else
        public global::G.WebGetToolVariant2? WebGetToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGetToolVariant2))]
#endif
        public bool IsWebGetToolVariant2 => WebGetToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetTool(global::G.ToolBase value) => new WebGetTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(WebGetTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WebGetTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetTool(global::G.WebGetToolVariant2 value) => new WebGetTool((global::G.WebGetToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebGetToolVariant2?(WebGetTool @this) => @this.WebGetToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebGetTool(global::G.WebGetToolVariant2? value)
        {
            WebGetToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebGetTool(
            global::G.ToolBase? @base,
            global::G.WebGetToolVariant2? webGetToolVariant2
            )
        {
            Base = @base;
            WebGetToolVariant2 = webGetToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebGetToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WebGetToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWebGetToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.WebGetToolVariant2?, TResult>? webGetToolVariant2 = null,
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
            else if (IsWebGetToolVariant2 && webGetToolVariant2 != null)
            {
                return webGetToolVariant2(WebGetToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.WebGetToolVariant2?>? webGetToolVariant2 = null,
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
            else if (IsWebGetToolVariant2)
            {
                webGetToolVariant2?.Invoke(WebGetToolVariant2!);
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
                WebGetToolVariant2,
                typeof(global::G.WebGetToolVariant2),
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
        public bool Equals(WebGetTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebGetToolVariant2?>.Default.Equals(WebGetToolVariant2, other.WebGetToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebGetTool obj1, WebGetTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebGetTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebGetTool obj1, WebGetTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebGetTool o && Equals(o);
        }
    }
}
