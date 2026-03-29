//HintName: G.Models.TemplatesCreateTemplateNoProjectRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of template to create, currently only agent templates are supported
    /// </summary>
    public readonly partial struct TemplatesCreateTemplateNoProjectRequest : global::System.IEquatable<TemplatesCreateTemplateNoProjectRequest>
    {
        /// <summary>
        /// Create a template from an existing agent
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TemplatesCreateTemplateNoProjectRequestVariant1? Agent { get; init; }
#else
        public global::G.TemplatesCreateTemplateNoProjectRequestVariant1? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        /// Create a template from an uploaded agent file
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TemplatesCreateTemplateNoProjectRequestVariant2? AgentFile { get; init; }
#else
        public global::G.TemplatesCreateTemplateNoProjectRequestVariant2? AgentFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentFile))]
#endif
        public bool IsAgentFile => AgentFile != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatesCreateTemplateNoProjectRequest(global::G.TemplatesCreateTemplateNoProjectRequestVariant1 value) => new TemplatesCreateTemplateNoProjectRequest((global::G.TemplatesCreateTemplateNoProjectRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TemplatesCreateTemplateNoProjectRequestVariant1?(TemplatesCreateTemplateNoProjectRequest @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateNoProjectRequest(global::G.TemplatesCreateTemplateNoProjectRequestVariant1? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatesCreateTemplateNoProjectRequest(global::G.TemplatesCreateTemplateNoProjectRequestVariant2 value) => new TemplatesCreateTemplateNoProjectRequest((global::G.TemplatesCreateTemplateNoProjectRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TemplatesCreateTemplateNoProjectRequestVariant2?(TemplatesCreateTemplateNoProjectRequest @this) => @this.AgentFile;

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateNoProjectRequest(global::G.TemplatesCreateTemplateNoProjectRequestVariant2? value)
        {
            AgentFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateNoProjectRequest(
            global::G.TemplatesCreateTemplateNoProjectRequestVariant1? agent,
            global::G.TemplatesCreateTemplateNoProjectRequestVariant2? agentFile
            )
        {
            Agent = agent;
            AgentFile = agentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentFile as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            AgentFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsAgentFile || !IsAgent && IsAgentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TemplatesCreateTemplateNoProjectRequestVariant1?, TResult>? agent = null,
            global::System.Func<global::G.TemplatesCreateTemplateNoProjectRequestVariant2?, TResult>? agentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsAgentFile && agentFile != null)
            {
                return agentFile(AgentFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TemplatesCreateTemplateNoProjectRequestVariant1?>? agent = null,
            global::System.Action<global::G.TemplatesCreateTemplateNoProjectRequestVariant2?>? agentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsAgentFile)
            {
                agentFile?.Invoke(AgentFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Agent,
                typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant1),
                AgentFile,
                typeof(global::G.TemplatesCreateTemplateNoProjectRequestVariant2),
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
        public bool Equals(TemplatesCreateTemplateNoProjectRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TemplatesCreateTemplateNoProjectRequestVariant1?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TemplatesCreateTemplateNoProjectRequestVariant2?>.Default.Equals(AgentFile, other.AgentFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TemplatesCreateTemplateNoProjectRequest obj1, TemplatesCreateTemplateNoProjectRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplatesCreateTemplateNoProjectRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TemplatesCreateTemplateNoProjectRequest obj1, TemplatesCreateTemplateNoProjectRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplatesCreateTemplateNoProjectRequest o && Equals(o);
        }
    }
}
