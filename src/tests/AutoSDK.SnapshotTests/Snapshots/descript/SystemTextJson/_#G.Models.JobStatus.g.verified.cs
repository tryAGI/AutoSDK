//HintName: G.Models.JobStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Status of an async job. The response structure varies based on the job type.<br/>
    /// Use the `job_type` field to determine which fields will be present.
    /// </summary>
    public readonly partial struct JobStatus : global::System.IEquatable<JobStatus>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobStatusDiscriminatorJobType? JobType { get; }

        /// <summary>
        /// Status of an import job
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImportJobStatus? ImportProjectMedia { get; init; }
#else
        public global::G.ImportJobStatus? ImportProjectMedia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportProjectMedia))]
#endif
        public bool IsImportProjectMedia => ImportProjectMedia != null;

        /// <summary>
        /// Status of an Agent edit job
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentJobStatus? Agent { get; init; }
#else
        public global::G.AgentJobStatus? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobStatus(global::G.ImportJobStatus value) => new JobStatus((global::G.ImportJobStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImportJobStatus?(JobStatus @this) => @this.ImportProjectMedia;

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(global::G.ImportJobStatus? value)
        {
            ImportProjectMedia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobStatus(global::G.AgentJobStatus value) => new JobStatus((global::G.AgentJobStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentJobStatus?(JobStatus @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(global::G.AgentJobStatus? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(
            global::G.JobStatusDiscriminatorJobType? jobType,
            global::G.ImportJobStatus? importProjectMedia,
            global::G.AgentJobStatus? agent
            )
        {
            JobType = jobType;

            ImportProjectMedia = importProjectMedia;
            Agent = agent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Agent as object ??
            ImportProjectMedia as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImportProjectMedia?.ToString() ??
            Agent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImportProjectMedia && !IsAgent || !IsImportProjectMedia && IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ImportJobStatus?, TResult>? importProjectMedia = null,
            global::System.Func<global::G.AgentJobStatus?, TResult>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportProjectMedia && importProjectMedia != null)
            {
                return importProjectMedia(ImportProjectMedia!);
            }
            else if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ImportJobStatus?>? importProjectMedia = null,
            global::System.Action<global::G.AgentJobStatus?>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportProjectMedia)
            {
                importProjectMedia?.Invoke(ImportProjectMedia!);
            }
            else if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImportProjectMedia,
                typeof(global::G.ImportJobStatus),
                Agent,
                typeof(global::G.AgentJobStatus),
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
        public bool Equals(JobStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ImportJobStatus?>.Default.Equals(ImportProjectMedia, other.ImportProjectMedia) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentJobStatus?>.Default.Equals(Agent, other.Agent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JobStatus obj1, JobStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JobStatus obj1, JobStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobStatus o && Equals(o);
        }
    }
}
