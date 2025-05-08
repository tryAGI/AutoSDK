//HintName: G.Models.JobsApiRoutesFineTuningUpdateFineTunedModelResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JobsApiRoutesFineTuningUpdateFineTunedModelResponse : global::System.IEquatable<JobsApiRoutesFineTuningUpdateFineTunedModelResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? ModelType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompletionFTModelOut? Completion { get; init; }
#else
        public global::G.CompletionFTModelOut? Completion { get; }
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
        public static implicit operator JobsApiRoutesFineTuningUpdateFineTunedModelResponse(global::G.CompletionFTModelOut value) => new JobsApiRoutesFineTuningUpdateFineTunedModelResponse((global::G.CompletionFTModelOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompletionFTModelOut?(JobsApiRoutesFineTuningUpdateFineTunedModelResponse @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningUpdateFineTunedModelResponse(global::G.CompletionFTModelOut? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClassifierFTModelOut? Classifier { get; init; }
#else
        public global::G.ClassifierFTModelOut? Classifier { get; }
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
        public static implicit operator JobsApiRoutesFineTuningUpdateFineTunedModelResponse(global::G.ClassifierFTModelOut value) => new JobsApiRoutesFineTuningUpdateFineTunedModelResponse((global::G.ClassifierFTModelOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClassifierFTModelOut?(JobsApiRoutesFineTuningUpdateFineTunedModelResponse @this) => @this.Classifier;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningUpdateFineTunedModelResponse(global::G.ClassifierFTModelOut? value)
        {
            Classifier = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningUpdateFineTunedModelResponse(
            global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? modelType,
            global::G.CompletionFTModelOut? completion,
            global::G.ClassifierFTModelOut? classifier
            )
        {
            ModelType = modelType;

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
            global::System.Func<global::G.CompletionFTModelOut?, TResult>? completion = null,
            global::System.Func<global::G.ClassifierFTModelOut?, TResult>? classifier = null,
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
            global::System.Action<global::G.CompletionFTModelOut?>? completion = null,
            global::System.Action<global::G.ClassifierFTModelOut?>? classifier = null,
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
                typeof(global::G.CompletionFTModelOut),
                Classifier,
                typeof(global::G.ClassifierFTModelOut),
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
        public bool Equals(JobsApiRoutesFineTuningUpdateFineTunedModelResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompletionFTModelOut?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClassifierFTModelOut?>.Default.Equals(Classifier, other.Classifier) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JobsApiRoutesFineTuningUpdateFineTunedModelResponse obj1, JobsApiRoutesFineTuningUpdateFineTunedModelResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobsApiRoutesFineTuningUpdateFineTunedModelResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JobsApiRoutesFineTuningUpdateFineTunedModelResponse obj1, JobsApiRoutesFineTuningUpdateFineTunedModelResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobsApiRoutesFineTuningUpdateFineTunedModelResponse o && Equals(o);
        }
    }
}
