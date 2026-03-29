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
        public global::System.Collections.Generic.IList<string>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

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
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

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
            global::System.Collections.Generic.IList<string>? value1,
            global::G.McpServerToolAllowedTools1? mcpServerToolAllowedTools1,
            object? value3,
            object? value4
            )
        {
            Value1 = value1;
            McpServerToolAllowedTools1 = mcpServerToolAllowedTools1;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            McpServerToolAllowedTools1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            McpServerToolAllowedTools1?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsMcpServerToolAllowedTools1 && !IsValue3 && !IsValue4 || !IsValue1 && IsMcpServerToolAllowedTools1 && !IsValue3 && !IsValue4 || !IsValue1 && !IsMcpServerToolAllowedTools1 && IsValue3 && !IsValue4 || !IsValue1 && !IsMcpServerToolAllowedTools1 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value1 = null,
            global::System.Func<global::G.McpServerToolAllowedTools1?, TResult>? mcpServerToolAllowedTools1 = null,
            global::System.Func<object?, TResult>? value3 = null,
            global::System.Func<object?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsMcpServerToolAllowedTools1 && mcpServerToolAllowedTools1 != null)
            {
                return mcpServerToolAllowedTools1(McpServerToolAllowedTools1!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value1 = null,
            global::System.Action<global::G.McpServerToolAllowedTools1?>? mcpServerToolAllowedTools1 = null,
            global::System.Action<object?>? value3 = null,
            global::System.Action<object?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsMcpServerToolAllowedTools1)
            {
                mcpServerToolAllowedTools1?.Invoke(McpServerToolAllowedTools1!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.Collections.Generic.IList<string>),
                McpServerToolAllowedTools1,
                typeof(global::G.McpServerToolAllowedTools1),
                Value3,
                typeof(object),
                Value4,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerToolAllowedTools1?>.Default.Equals(McpServerToolAllowedTools1, other.McpServerToolAllowedTools1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value4, other.Value4) 
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
