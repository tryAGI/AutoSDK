//HintName: G.Models.McpServerToolRequireApproval.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct McpServerToolRequireApproval : global::System.IEquatable<McpServerToolRequireApproval>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpServerToolRequireApproval0? McpServerToolRequireApproval0 { get; init; }
#else
        public global::G.McpServerToolRequireApproval0? McpServerToolRequireApproval0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolRequireApproval0))]
#endif
        public bool IsMcpServerToolRequireApproval0 => McpServerToolRequireApproval0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpServerToolRequireApproval1? McpServerToolRequireApproval1 { get; init; }
#else
        public global::G.McpServerToolRequireApproval1? McpServerToolRequireApproval1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolRequireApproval1))]
#endif
        public bool IsMcpServerToolRequireApproval1 => McpServerToolRequireApproval1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpServerToolRequireApproval2? McpServerToolRequireApproval2 { get; init; }
#else
        public global::G.McpServerToolRequireApproval2? McpServerToolRequireApproval2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolRequireApproval2))]
#endif
        public bool IsMcpServerToolRequireApproval2 => McpServerToolRequireApproval2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value4 { get; init; }
#else
        public object? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value5 { get; init; }
#else
        public object? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServerToolRequireApproval(global::G.McpServerToolRequireApproval0 value) => new McpServerToolRequireApproval((global::G.McpServerToolRequireApproval0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpServerToolRequireApproval0?(McpServerToolRequireApproval @this) => @this.McpServerToolRequireApproval0;

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolRequireApproval(global::G.McpServerToolRequireApproval0? value)
        {
            McpServerToolRequireApproval0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServerToolRequireApproval(global::G.McpServerToolRequireApproval1 value) => new McpServerToolRequireApproval((global::G.McpServerToolRequireApproval1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpServerToolRequireApproval1?(McpServerToolRequireApproval @this) => @this.McpServerToolRequireApproval1;

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolRequireApproval(global::G.McpServerToolRequireApproval1? value)
        {
            McpServerToolRequireApproval1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServerToolRequireApproval(global::G.McpServerToolRequireApproval2 value) => new McpServerToolRequireApproval((global::G.McpServerToolRequireApproval2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpServerToolRequireApproval2?(McpServerToolRequireApproval @this) => @this.McpServerToolRequireApproval2;

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolRequireApproval(global::G.McpServerToolRequireApproval2? value)
        {
            McpServerToolRequireApproval2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolRequireApproval(
            global::G.McpServerToolRequireApproval0? mcpServerToolRequireApproval0,
            global::G.McpServerToolRequireApproval1? mcpServerToolRequireApproval1,
            global::G.McpServerToolRequireApproval2? mcpServerToolRequireApproval2,
            object? value4,
            object? value5
            )
        {
            McpServerToolRequireApproval0 = mcpServerToolRequireApproval0;
            McpServerToolRequireApproval1 = mcpServerToolRequireApproval1;
            McpServerToolRequireApproval2 = mcpServerToolRequireApproval2;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            McpServerToolRequireApproval2 as object ??
            McpServerToolRequireApproval1 as object ??
            McpServerToolRequireApproval0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            McpServerToolRequireApproval0?.ToString() ??
            McpServerToolRequireApproval1?.ToValueString() ??
            McpServerToolRequireApproval2?.ToValueString() ??
            Value4?.ToString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcpServerToolRequireApproval0 && !IsMcpServerToolRequireApproval1 && !IsMcpServerToolRequireApproval2 && !IsValue4 && !IsValue5 || !IsMcpServerToolRequireApproval0 && IsMcpServerToolRequireApproval1 && !IsMcpServerToolRequireApproval2 && !IsValue4 && !IsValue5 || !IsMcpServerToolRequireApproval0 && !IsMcpServerToolRequireApproval1 && IsMcpServerToolRequireApproval2 && !IsValue4 && !IsValue5 || !IsMcpServerToolRequireApproval0 && !IsMcpServerToolRequireApproval1 && !IsMcpServerToolRequireApproval2 && IsValue4 && !IsValue5 || !IsMcpServerToolRequireApproval0 && !IsMcpServerToolRequireApproval1 && !IsMcpServerToolRequireApproval2 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.McpServerToolRequireApproval0?, TResult>? mcpServerToolRequireApproval0 = null,
            global::System.Func<global::G.McpServerToolRequireApproval1?, TResult>? mcpServerToolRequireApproval1 = null,
            global::System.Func<global::G.McpServerToolRequireApproval2?, TResult>? mcpServerToolRequireApproval2 = null,
            global::System.Func<object?, TResult>? value4 = null,
            global::System.Func<object?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolRequireApproval0 && mcpServerToolRequireApproval0 != null)
            {
                return mcpServerToolRequireApproval0(McpServerToolRequireApproval0!);
            }
            else if (IsMcpServerToolRequireApproval1 && mcpServerToolRequireApproval1 != null)
            {
                return mcpServerToolRequireApproval1(McpServerToolRequireApproval1!);
            }
            else if (IsMcpServerToolRequireApproval2 && mcpServerToolRequireApproval2 != null)
            {
                return mcpServerToolRequireApproval2(McpServerToolRequireApproval2!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.McpServerToolRequireApproval0?>? mcpServerToolRequireApproval0 = null,
            global::System.Action<global::G.McpServerToolRequireApproval1?>? mcpServerToolRequireApproval1 = null,
            global::System.Action<global::G.McpServerToolRequireApproval2?>? mcpServerToolRequireApproval2 = null,
            global::System.Action<object?>? value4 = null,
            global::System.Action<object?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolRequireApproval0)
            {
                mcpServerToolRequireApproval0?.Invoke(McpServerToolRequireApproval0!);
            }
            else if (IsMcpServerToolRequireApproval1)
            {
                mcpServerToolRequireApproval1?.Invoke(McpServerToolRequireApproval1!);
            }
            else if (IsMcpServerToolRequireApproval2)
            {
                mcpServerToolRequireApproval2?.Invoke(McpServerToolRequireApproval2!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpServerToolRequireApproval0,
                typeof(global::G.McpServerToolRequireApproval0),
                McpServerToolRequireApproval1,
                typeof(global::G.McpServerToolRequireApproval1),
                McpServerToolRequireApproval2,
                typeof(global::G.McpServerToolRequireApproval2),
                Value4,
                typeof(object),
                Value5,
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
        public bool Equals(McpServerToolRequireApproval other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerToolRequireApproval0?>.Default.Equals(McpServerToolRequireApproval0, other.McpServerToolRequireApproval0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerToolRequireApproval1?>.Default.Equals(McpServerToolRequireApproval1, other.McpServerToolRequireApproval1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerToolRequireApproval2?>.Default.Equals(McpServerToolRequireApproval2, other.McpServerToolRequireApproval2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpServerToolRequireApproval obj1, McpServerToolRequireApproval obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpServerToolRequireApproval>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpServerToolRequireApproval obj1, McpServerToolRequireApproval obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServerToolRequireApproval o && Equals(o);
        }
    }
}
