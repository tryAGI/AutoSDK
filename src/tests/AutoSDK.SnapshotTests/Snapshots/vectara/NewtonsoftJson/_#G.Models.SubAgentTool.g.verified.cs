//HintName: G.Models.SubAgentTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that spawns a specialized sub-agent to handle complex, multi-step tasks autonomously.<br/>
    /// Sub-agents maintain separate context from the main agent and can be specialized for specific types of tasks like code review, general research, or output styling.
    /// </summary>
    public readonly partial struct SubAgentTool : global::System.IEquatable<SubAgentTool>
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
        public global::G.SubAgentToolVariant2? SubAgentToolVariant2 { get; init; }
#else
        public global::G.SubAgentToolVariant2? SubAgentToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgentToolVariant2))]
#endif
        public bool IsSubAgentToolVariant2 => SubAgentToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentTool(global::G.ToolBase value) => new SubAgentTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(SubAgentTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentTool(global::G.SubAgentToolVariant2 value) => new SubAgentTool((global::G.SubAgentToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SubAgentToolVariant2?(SubAgentTool @this) => @this.SubAgentToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(global::G.SubAgentToolVariant2? value)
        {
            SubAgentToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(
            global::G.ToolBase? @base,
            global::G.SubAgentToolVariant2? subAgentToolVariant2
            )
        {
            Base = @base;
            SubAgentToolVariant2 = subAgentToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubAgentToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SubAgentToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSubAgentToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.SubAgentToolVariant2?, TResult>? subAgentToolVariant2 = null,
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
            else if (IsSubAgentToolVariant2 && subAgentToolVariant2 != null)
            {
                return subAgentToolVariant2(SubAgentToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.SubAgentToolVariant2?>? subAgentToolVariant2 = null,
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
            else if (IsSubAgentToolVariant2)
            {
                subAgentToolVariant2?.Invoke(SubAgentToolVariant2!);
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
                SubAgentToolVariant2,
                typeof(global::G.SubAgentToolVariant2),
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
        public bool Equals(SubAgentTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SubAgentToolVariant2?>.Default.Equals(SubAgentToolVariant2, other.SubAgentToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubAgentTool obj1, SubAgentTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubAgentTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubAgentTool obj1, SubAgentTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubAgentTool o && Equals(o);
        }
    }
}
