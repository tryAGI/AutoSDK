//HintName: G.Models.McpTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An MCP (Model Context Protocol) tool that connects to external MCP servers for extended functionality.
    /// </summary>
    public readonly partial struct McpTool : global::System.IEquatable<McpTool>
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
        public global::G.McpToolVariant2? McpToolVariant2 { get; init; }
#else
        public global::G.McpToolVariant2? McpToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolVariant2))]
#endif
        public bool IsMcpToolVariant2 => McpToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpTool(global::G.ToolBase value) => new McpTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(McpTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public McpTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpTool(global::G.McpToolVariant2 value) => new McpTool((global::G.McpToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpToolVariant2?(McpTool @this) => @this.McpToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public McpTool(global::G.McpToolVariant2? value)
        {
            McpToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public McpTool(
            global::G.ToolBase? @base,
            global::G.McpToolVariant2? mcpToolVariant2
            )
        {
            Base = @base;
            McpToolVariant2 = mcpToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            McpToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMcpToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.McpToolVariant2?, TResult>? mcpToolVariant2 = null,
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
            else if (IsMcpToolVariant2 && mcpToolVariant2 != null)
            {
                return mcpToolVariant2(McpToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.McpToolVariant2?>? mcpToolVariant2 = null,
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
            else if (IsMcpToolVariant2)
            {
                mcpToolVariant2?.Invoke(McpToolVariant2!);
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
                McpToolVariant2,
                typeof(global::G.McpToolVariant2),
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
        public bool Equals(McpTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpToolVariant2?>.Default.Equals(McpToolVariant2, other.McpToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpTool obj1, McpTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpTool obj1, McpTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpTool o && Equals(o);
        }
    }
}
