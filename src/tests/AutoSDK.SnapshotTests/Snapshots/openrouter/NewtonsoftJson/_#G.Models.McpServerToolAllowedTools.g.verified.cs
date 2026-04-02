//HintName: G.Models.McpServerToolAllowedTools.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct McpServerToolAllowedTools : global::System.IEquatable<McpServerToolAllowedTools>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? McpServerToolAllowedToolsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? McpServerToolAllowedToolsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedToolsVariant1))]
#endif
        public bool IsMcpServerToolAllowedToolsVariant1 => McpServerToolAllowedToolsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpServerToolAllowedTools1? McpServerToolAllowedTools1 { get; init; }
#else
        public global::G.McpServerToolAllowedTools1? McpServerToolAllowedTools1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedTools1))]
#endif
        public bool IsMcpServerToolAllowedTools1 => McpServerToolAllowedTools1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? McpServerToolAllowedToolsVariant3 { get; init; }
#else
        public object? McpServerToolAllowedToolsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedToolsVariant3))]
#endif
        public bool IsMcpServerToolAllowedToolsVariant3 => McpServerToolAllowedToolsVariant3 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? McpServerToolAllowedToolsVariant4 { get; init; }
#else
        public object? McpServerToolAllowedToolsVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedToolsVariant4))]
#endif
        public bool IsMcpServerToolAllowedToolsVariant4 => McpServerToolAllowedToolsVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServerToolAllowedTools(global::G.McpServerToolAllowedTools1 value) => new McpServerToolAllowedTools((global::G.McpServerToolAllowedTools1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpServerToolAllowedTools1?(McpServerToolAllowedTools @this) => @this.McpServerToolAllowedTools1;

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolAllowedTools(global::G.McpServerToolAllowedTools1? value)
        {
            McpServerToolAllowedTools1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolAllowedTools(
            global::System.Collections.Generic.IList<string>? mcpServerToolAllowedToolsVariant1,
            global::G.McpServerToolAllowedTools1? mcpServerToolAllowedTools1,
            object? mcpServerToolAllowedToolsVariant3,
            object? mcpServerToolAllowedToolsVariant4
            )
        {
            McpServerToolAllowedToolsVariant1 = mcpServerToolAllowedToolsVariant1;
            McpServerToolAllowedTools1 = mcpServerToolAllowedTools1;
            McpServerToolAllowedToolsVariant3 = mcpServerToolAllowedToolsVariant3;
            McpServerToolAllowedToolsVariant4 = mcpServerToolAllowedToolsVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpServerToolAllowedToolsVariant4 as object ??
            McpServerToolAllowedToolsVariant3 as object ??
            McpServerToolAllowedTools1 as object ??
            McpServerToolAllowedToolsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            McpServerToolAllowedToolsVariant1?.ToString() ??
            McpServerToolAllowedTools1?.ToString() ??
            McpServerToolAllowedToolsVariant3?.ToString() ??
            McpServerToolAllowedToolsVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcpServerToolAllowedToolsVariant1 && !IsMcpServerToolAllowedTools1 && !IsMcpServerToolAllowedToolsVariant3 && !IsMcpServerToolAllowedToolsVariant4 || !IsMcpServerToolAllowedToolsVariant1 && IsMcpServerToolAllowedTools1 && !IsMcpServerToolAllowedToolsVariant3 && !IsMcpServerToolAllowedToolsVariant4 || !IsMcpServerToolAllowedToolsVariant1 && !IsMcpServerToolAllowedTools1 && IsMcpServerToolAllowedToolsVariant3 && !IsMcpServerToolAllowedToolsVariant4 || !IsMcpServerToolAllowedToolsVariant1 && !IsMcpServerToolAllowedTools1 && !IsMcpServerToolAllowedToolsVariant3 && IsMcpServerToolAllowedToolsVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? mcpServerToolAllowedToolsVariant1 = null,
            global::System.Func<global::G.McpServerToolAllowedTools1?, TResult>? mcpServerToolAllowedTools1 = null,
            global::System.Func<object?, TResult>? mcpServerToolAllowedToolsVariant3 = null,
            global::System.Func<object?, TResult>? mcpServerToolAllowedToolsVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolAllowedToolsVariant1 && mcpServerToolAllowedToolsVariant1 != null)
            {
                return mcpServerToolAllowedToolsVariant1(McpServerToolAllowedToolsVariant1!);
            }
            else if (IsMcpServerToolAllowedTools1 && mcpServerToolAllowedTools1 != null)
            {
                return mcpServerToolAllowedTools1(McpServerToolAllowedTools1!);
            }
            else if (IsMcpServerToolAllowedToolsVariant3 && mcpServerToolAllowedToolsVariant3 != null)
            {
                return mcpServerToolAllowedToolsVariant3(McpServerToolAllowedToolsVariant3!);
            }
            else if (IsMcpServerToolAllowedToolsVariant4 && mcpServerToolAllowedToolsVariant4 != null)
            {
                return mcpServerToolAllowedToolsVariant4(McpServerToolAllowedToolsVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<string>?>? mcpServerToolAllowedToolsVariant1 = null,
            global::System.Action<global::G.McpServerToolAllowedTools1?>? mcpServerToolAllowedTools1 = null,
            global::System.Action<object?>? mcpServerToolAllowedToolsVariant3 = null,
            global::System.Action<object?>? mcpServerToolAllowedToolsVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolAllowedToolsVariant1)
            {
                mcpServerToolAllowedToolsVariant1?.Invoke(McpServerToolAllowedToolsVariant1!);
            }
            else if (IsMcpServerToolAllowedTools1)
            {
                mcpServerToolAllowedTools1?.Invoke(McpServerToolAllowedTools1!);
            }
            else if (IsMcpServerToolAllowedToolsVariant3)
            {
                mcpServerToolAllowedToolsVariant3?.Invoke(McpServerToolAllowedToolsVariant3!);
            }
            else if (IsMcpServerToolAllowedToolsVariant4)
            {
                mcpServerToolAllowedToolsVariant4?.Invoke(McpServerToolAllowedToolsVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpServerToolAllowedToolsVariant1,
                typeof(global::System.Collections.Generic.IList<string>),
                McpServerToolAllowedTools1,
                typeof(global::G.McpServerToolAllowedTools1),
                McpServerToolAllowedToolsVariant3,
                typeof(object),
                McpServerToolAllowedToolsVariant4,
                typeof(object),
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
        public bool Equals(McpServerToolAllowedTools other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(McpServerToolAllowedToolsVariant1, other.McpServerToolAllowedToolsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerToolAllowedTools1?>.Default.Equals(McpServerToolAllowedTools1, other.McpServerToolAllowedTools1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(McpServerToolAllowedToolsVariant3, other.McpServerToolAllowedToolsVariant3) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(McpServerToolAllowedToolsVariant4, other.McpServerToolAllowedToolsVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpServerToolAllowedTools obj1, McpServerToolAllowedTools obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpServerToolAllowedTools>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpServerToolAllowedTools obj1, McpServerToolAllowedTools obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServerToolAllowedTools o && Equals(o);
        }
    }
}
