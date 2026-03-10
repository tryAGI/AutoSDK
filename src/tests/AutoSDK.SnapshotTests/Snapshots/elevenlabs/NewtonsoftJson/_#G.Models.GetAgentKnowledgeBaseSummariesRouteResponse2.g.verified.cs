//HintName: G.Models.GetAgentKnowledgeBaseSummariesRouteResponse2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetAgentKnowledgeBaseSummariesRouteResponse2 : global::System.IEquatable<GetAgentKnowledgeBaseSummariesRouteResponse2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Success { get; init; }
#else
        public global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BatchFailureResponseModel? Failure { get; init; }
#else
        public global::G.BatchFailureResponseModel? Failure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failure))]
#endif
        public bool IsFailure => Failure != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAgentKnowledgeBaseSummariesRouteResponse2(global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel value) => new GetAgentKnowledgeBaseSummariesRouteResponse2((global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel?(GetAgentKnowledgeBaseSummariesRouteResponse2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAgentKnowledgeBaseSummariesRouteResponse2(global::G.BatchFailureResponseModel value) => new GetAgentKnowledgeBaseSummariesRouteResponse2((global::G.BatchFailureResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BatchFailureResponseModel?(GetAgentKnowledgeBaseSummariesRouteResponse2 @this) => @this.Failure;

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(global::G.BatchFailureResponseModel? value)
        {
            Failure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(
            global::G.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? status,
            global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel? success,
            global::G.BatchFailureResponseModel? failure
            )
        {
            Status = status;

            Success = success;
            Failure = failure;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failure as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Failure?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsFailure || !IsSuccess && IsFailure;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel?, TResult>? success = null,
            global::System.Func<global::G.BatchFailureResponseModel?, TResult>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsFailure && failure != null)
            {
                return failure(Failure!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel?>? success = null,
            global::System.Action<global::G.BatchFailureResponseModel?>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsFailure)
            {
                failure?.Invoke(Failure!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel),
                Failure,
                typeof(global::G.BatchFailureResponseModel),
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
        public bool Equals(GetAgentKnowledgeBaseSummariesRouteResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModel?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BatchFailureResponseModel?>.Default.Equals(Failure, other.Failure) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetAgentKnowledgeBaseSummariesRouteResponse2 obj1, GetAgentKnowledgeBaseSummariesRouteResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetAgentKnowledgeBaseSummariesRouteResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetAgentKnowledgeBaseSummariesRouteResponse2 obj1, GetAgentKnowledgeBaseSummariesRouteResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAgentKnowledgeBaseSummariesRouteResponse2 o && Equals(o);
        }
    }
}
