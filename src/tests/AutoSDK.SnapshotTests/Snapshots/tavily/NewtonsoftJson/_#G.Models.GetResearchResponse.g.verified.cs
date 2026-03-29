//HintName: G.Models.GetResearchResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetResearchResponse : global::System.IEquatable<GetResearchResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetResearchResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Example: {"request_id":"123e4567-e89b-12d3-a456-426614174111","created_at":"2025-01-15T10:30:00Z","status":"completed","content":"Research Report: Latest Developments in AI\n\n## Executive Summary\n\nArtificial Intelligence has seen significant advancements in recent months, with major breakthroughs in large language models, multimodal AI systems, and real-world applications...","sources":[{"title":"Latest AI Developments","url":"https://example.com/ai-news","favicon":"https://example.com/favicon.ico"},{"title":"AI Research Breakthroughs","url":"https://example.com/ai-research","favicon":"https://example.com/favicon.ico"}],"response_time":1.23}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchTaskCompleted? Completed { get; init; }
#else
        public global::G.ResearchTaskCompleted? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// Example: {"request_id":"123e4567-e89b-12d3-a456-426614174111","status":"failed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchTaskFailed? Failed { get; init; }
#else
        public global::G.ResearchTaskFailed? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetResearchResponse(global::G.ResearchTaskCompleted value) => new GetResearchResponse((global::G.ResearchTaskCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchTaskCompleted?(GetResearchResponse @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public GetResearchResponse(global::G.ResearchTaskCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetResearchResponse(global::G.ResearchTaskFailed value) => new GetResearchResponse((global::G.ResearchTaskFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchTaskFailed?(GetResearchResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetResearchResponse(global::G.ResearchTaskFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetResearchResponse(
            global::G.GetResearchResponseDiscriminatorStatus? status,
            global::G.ResearchTaskCompleted? completed,
            global::G.ResearchTaskFailed? failed
            )
        {
            Status = status;

            Completed = completed;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Completed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsFailed || !IsCompleted && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchTaskCompleted?, TResult>? completed = null,
            global::System.Func<global::G.ResearchTaskFailed?, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchTaskCompleted?>? completed = null,
            global::System.Action<global::G.ResearchTaskFailed?>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completed,
                typeof(global::G.ResearchTaskCompleted),
                Failed,
                typeof(global::G.ResearchTaskFailed),
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
        public bool Equals(GetResearchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchTaskCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchTaskFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetResearchResponse obj1, GetResearchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetResearchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetResearchResponse obj1, GetResearchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetResearchResponse o && Equals(o);
        }
    }
}
