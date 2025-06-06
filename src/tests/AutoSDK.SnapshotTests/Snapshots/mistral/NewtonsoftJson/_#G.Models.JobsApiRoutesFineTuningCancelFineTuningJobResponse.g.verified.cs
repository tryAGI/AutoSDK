﻿//HintName: G.Models.JobsApiRoutesFineTuningCancelFineTuningJobResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JobsApiRoutesFineTuningCancelFineTuningJobResponse : global::System.IEquatable<JobsApiRoutesFineTuningCancelFineTuningJobResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? JobType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompletionDetailedJobOut? Completion { get; init; }
#else
        public global::G.CompletionDetailedJobOut? Completion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobsApiRoutesFineTuningCancelFineTuningJobResponse(global::G.CompletionDetailedJobOut value) => new JobsApiRoutesFineTuningCancelFineTuningJobResponse((global::G.CompletionDetailedJobOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompletionDetailedJobOut?(JobsApiRoutesFineTuningCancelFineTuningJobResponse @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningCancelFineTuningJobResponse(global::G.CompletionDetailedJobOut? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClassifierDetailedJobOut? Classifier { get; init; }
#else
        public global::G.ClassifierDetailedJobOut? Classifier { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Classifier))]
#endif
        public bool IsClassifier => Classifier != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobsApiRoutesFineTuningCancelFineTuningJobResponse(global::G.ClassifierDetailedJobOut value) => new JobsApiRoutesFineTuningCancelFineTuningJobResponse((global::G.ClassifierDetailedJobOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClassifierDetailedJobOut?(JobsApiRoutesFineTuningCancelFineTuningJobResponse @this) => @this.Classifier;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningCancelFineTuningJobResponse(global::G.ClassifierDetailedJobOut? value)
        {
            Classifier = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningCancelFineTuningJobResponse(
            global::G.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? jobType,
            global::G.CompletionDetailedJobOut? completion,
            global::G.ClassifierDetailedJobOut? classifier
            )
        {
            JobType = jobType;

            Completion = completion;
            Classifier = classifier;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Classifier as object ??
            Completion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completion?.ToString() ??
            Classifier?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletion && !IsClassifier || !IsCompletion && IsClassifier;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CompletionDetailedJobOut?, TResult>? completion = null,
            global::System.Func<global::G.ClassifierDetailedJobOut?, TResult>? classifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }
            else if (IsClassifier && classifier != null)
            {
                return classifier(Classifier!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CompletionDetailedJobOut?>? completion = null,
            global::System.Action<global::G.ClassifierDetailedJobOut?>? classifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsClassifier)
            {
                classifier?.Invoke(Classifier!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completion,
                typeof(global::G.CompletionDetailedJobOut),
                Classifier,
                typeof(global::G.ClassifierDetailedJobOut),
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
        public bool Equals(JobsApiRoutesFineTuningCancelFineTuningJobResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompletionDetailedJobOut?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClassifierDetailedJobOut?>.Default.Equals(Classifier, other.Classifier) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JobsApiRoutesFineTuningCancelFineTuningJobResponse obj1, JobsApiRoutesFineTuningCancelFineTuningJobResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobsApiRoutesFineTuningCancelFineTuningJobResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JobsApiRoutesFineTuningCancelFineTuningJobResponse obj1, JobsApiRoutesFineTuningCancelFineTuningJobResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobsApiRoutesFineTuningCancelFineTuningJobResponse o && Equals(o);
        }
    }
}
