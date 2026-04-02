//HintName: G.Models.ArtifactUploadEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Event representing files uploaded to the agent workspace as artifacts.<br/>
    /// This event is created when users upload one or more files to an agent session using multipart requests. The event becomes part of the session's conversation history and contains references to all artifacts that were uploaded in the request. Each uploaded file is assigned a unique artifact identifier and stored in the session's workspace.<br/>
    /// When an agent processes this event, it becomes aware that new files are available in the session and can use various tools to read, analyze, or transform these artifacts. For example, after receiving an artifact upload event with a PDF, the agent might use the document conversion tool to extract and analyze the document's contents.<br/>
    /// See the `ArtifactReference` schema for comprehensive details about what artifacts are, how they are stored, their lifecycle, and how agents interact with them.
    /// </summary>
    public readonly partial struct ArtifactUploadEvent : global::System.IEquatable<ArtifactUploadEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentEventBase? AgentBase { get; init; }
#else
        public global::G.AgentEventBase? AgentBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentBase))]
#endif
        public bool IsAgentBase => AgentBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ArtifactUploadEventVariant2? ArtifactUploadEventVariant2 { get; init; }
#else
        public global::G.ArtifactUploadEventVariant2? ArtifactUploadEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactUploadEventVariant2))]
#endif
        public bool IsArtifactUploadEventVariant2 => ArtifactUploadEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::G.AgentEventBase value) => new ArtifactUploadEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(ArtifactUploadEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::G.ArtifactUploadEventVariant2 value) => new ArtifactUploadEvent((global::G.ArtifactUploadEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ArtifactUploadEventVariant2?(ArtifactUploadEvent @this) => @this.ArtifactUploadEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(global::G.ArtifactUploadEventVariant2? value)
        {
            ArtifactUploadEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(
            global::G.AgentEventBase? agentBase,
            global::G.ArtifactUploadEventVariant2? artifactUploadEventVariant2
            )
        {
            AgentBase = agentBase;
            ArtifactUploadEventVariant2 = artifactUploadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactUploadEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ArtifactUploadEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsArtifactUploadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.ArtifactUploadEventVariant2?, TResult>? artifactUploadEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase && agentBase != null)
            {
                return agentBase(AgentBase!);
            }
            else if (IsArtifactUploadEventVariant2 && artifactUploadEventVariant2 != null)
            {
                return artifactUploadEventVariant2(ArtifactUploadEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.ArtifactUploadEventVariant2?>? artifactUploadEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase)
            {
                agentBase?.Invoke(AgentBase!);
            }
            else if (IsArtifactUploadEventVariant2)
            {
                artifactUploadEventVariant2?.Invoke(ArtifactUploadEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentBase,
                typeof(global::G.AgentEventBase),
                ArtifactUploadEventVariant2,
                typeof(global::G.ArtifactUploadEventVariant2),
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
        public bool Equals(ArtifactUploadEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ArtifactUploadEventVariant2?>.Default.Equals(ArtifactUploadEventVariant2, other.ArtifactUploadEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactUploadEvent obj1, ArtifactUploadEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactUploadEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactUploadEvent obj1, ArtifactUploadEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactUploadEvent o && Equals(o);
        }
    }
}
