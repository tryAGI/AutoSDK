//HintName: G.Models.AgentSwapNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentSwapNode : global::System.IEquatable<AgentSwapNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeBase? Base { get; init; }
#else
        public global::G.NodeBase? Base { get; }
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
        public global::G.AgentSwapNodeVariant2? AgentSwapNodeVariant2 { get; init; }
#else
        public global::G.AgentSwapNodeVariant2? AgentSwapNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSwapNodeVariant2))]
#endif
        public bool IsAgentSwapNodeVariant2 => AgentSwapNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentSwapNode(global::G.NodeBase value) => new AgentSwapNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(AgentSwapNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public AgentSwapNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentSwapNode(global::G.AgentSwapNodeVariant2 value) => new AgentSwapNode((global::G.AgentSwapNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSwapNodeVariant2?(AgentSwapNode @this) => @this.AgentSwapNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AgentSwapNode(global::G.AgentSwapNodeVariant2? value)
        {
            AgentSwapNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentSwapNode(
            global::G.NodeBase? @base,
            global::G.AgentSwapNodeVariant2? agentSwapNodeVariant2
            )
        {
            Base = @base;
            AgentSwapNodeVariant2 = agentSwapNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentSwapNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AgentSwapNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAgentSwapNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.AgentSwapNodeVariant2?, TResult>? agentSwapNodeVariant2 = null,
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
            else if (IsAgentSwapNodeVariant2 && agentSwapNodeVariant2 != null)
            {
                return agentSwapNodeVariant2(AgentSwapNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.AgentSwapNodeVariant2?>? agentSwapNodeVariant2 = null,
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
            else if (IsAgentSwapNodeVariant2)
            {
                agentSwapNodeVariant2?.Invoke(AgentSwapNodeVariant2!);
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
                typeof(global::G.NodeBase),
                AgentSwapNodeVariant2,
                typeof(global::G.AgentSwapNodeVariant2),
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
        public bool Equals(AgentSwapNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSwapNodeVariant2?>.Default.Equals(AgentSwapNodeVariant2, other.AgentSwapNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentSwapNode obj1, AgentSwapNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentSwapNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentSwapNode obj1, AgentSwapNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentSwapNode o && Equals(o);
        }
    }
}
