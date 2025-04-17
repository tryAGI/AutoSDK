//HintName: G.Models.DataItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobsOutDataItemDiscriminatorJobType? JobType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompletionJobOut? Completion { get; init; }
#else
        public global::G.CompletionJobOut? Completion { get; }
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
        public static implicit operator DataItem(global::G.CompletionJobOut value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompletionJobOut?(DataItem @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.CompletionJobOut? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClassifierJobOut? Classifier { get; init; }
#else
        public global::G.ClassifierJobOut? Classifier { get; }
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
        public static implicit operator DataItem(global::G.ClassifierJobOut value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClassifierJobOut?(DataItem @this) => @this.Classifier;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.ClassifierJobOut? value)
        {
            Classifier = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::G.JobsOutDataItemDiscriminatorJobType? jobType,
            global::G.CompletionJobOut? completion,
            global::G.ClassifierJobOut? classifier
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
            global::System.Func<global::G.CompletionJobOut?, TResult>? completion = null,
            global::System.Func<global::G.ClassifierJobOut?, TResult>? classifier = null,
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
            global::System.Action<global::G.CompletionJobOut?>? completion = null,
            global::System.Action<global::G.ClassifierJobOut?>? classifier = null,
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
                typeof(global::G.CompletionJobOut),
                Classifier,
                typeof(global::G.ClassifierJobOut),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompletionJobOut?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClassifierJobOut?>.Default.Equals(Classifier, other.Classifier) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
