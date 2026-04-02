//HintName: G.Models.ConversationNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationNode : global::System.IEquatable<ConversationNode>
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
        public global::G.AgentOverrideConfig? AgentOverrideConfig { get; init; }
#else
        public global::G.AgentOverrideConfig? AgentOverrideConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOverrideConfig))]
#endif
        public bool IsAgentOverrideConfig => AgentOverrideConfig != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationNodeVariant3? ConversationNodeVariant3 { get; init; }
#else
        public global::G.ConversationNodeVariant3? ConversationNodeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationNodeVariant3))]
#endif
        public bool IsConversationNodeVariant3 => ConversationNodeVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationNode(global::G.NodeBase value) => new ConversationNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(ConversationNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ConversationNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationNode(global::G.AgentOverrideConfig value) => new ConversationNode((global::G.AgentOverrideConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentOverrideConfig?(ConversationNode @this) => @this.AgentOverrideConfig;

        /// <summary>
        /// 
        /// </summary>
        public ConversationNode(global::G.AgentOverrideConfig? value)
        {
            AgentOverrideConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationNode(global::G.ConversationNodeVariant3 value) => new ConversationNode((global::G.ConversationNodeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationNodeVariant3?(ConversationNode @this) => @this.ConversationNodeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ConversationNode(global::G.ConversationNodeVariant3? value)
        {
            ConversationNodeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationNode(
            global::G.NodeBase? @base,
            global::G.AgentOverrideConfig? agentOverrideConfig,
            global::G.ConversationNodeVariant3? conversationNodeVariant3
            )
        {
            Base = @base;
            AgentOverrideConfig = agentOverrideConfig;
            ConversationNodeVariant3 = conversationNodeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationNodeVariant3 as object ??
            AgentOverrideConfig as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AgentOverrideConfig?.ToString() ??
            ConversationNodeVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAgentOverrideConfig && IsConversationNodeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.AgentOverrideConfig?, TResult>? agentOverrideConfig = null,
            global::System.Func<global::G.ConversationNodeVariant3?, TResult>? conversationNodeVariant3 = null,
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
            else if (IsAgentOverrideConfig && agentOverrideConfig != null)
            {
                return agentOverrideConfig(AgentOverrideConfig!);
            }
            else if (IsConversationNodeVariant3 && conversationNodeVariant3 != null)
            {
                return conversationNodeVariant3(ConversationNodeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.AgentOverrideConfig?>? agentOverrideConfig = null,
            global::System.Action<global::G.ConversationNodeVariant3?>? conversationNodeVariant3 = null,
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
            else if (IsAgentOverrideConfig)
            {
                agentOverrideConfig?.Invoke(AgentOverrideConfig!);
            }
            else if (IsConversationNodeVariant3)
            {
                conversationNodeVariant3?.Invoke(ConversationNodeVariant3!);
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
                AgentOverrideConfig,
                typeof(global::G.AgentOverrideConfig),
                ConversationNodeVariant3,
                typeof(global::G.ConversationNodeVariant3),
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
        public bool Equals(ConversationNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentOverrideConfig?>.Default.Equals(AgentOverrideConfig, other.AgentOverrideConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationNodeVariant3?>.Default.Equals(ConversationNodeVariant3, other.ConversationNodeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationNode obj1, ConversationNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationNode obj1, ConversationNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationNode o && Equals(o);
        }
    }
}
