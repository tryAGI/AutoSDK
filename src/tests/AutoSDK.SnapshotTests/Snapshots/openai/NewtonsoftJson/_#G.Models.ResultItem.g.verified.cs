//HintName: G.Models.ResultItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultItem : global::System.IEquatable<ResultItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageTimeBucketResultItemDiscriminatorObject? Object { get; }

        /// <summary>
        /// The aggregated completions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageCompletionsResult? OrganizationUsageCompletionsResult { get; init; }
#else
        public global::G.UsageCompletionsResult? OrganizationUsageCompletionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageCompletionsResult))]
#endif
        public bool IsOrganizationUsageCompletionsResult => OrganizationUsageCompletionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageCompletionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageCompletionsResult?(ResultItem @this) => @this.OrganizationUsageCompletionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageCompletionsResult? value)
        {
            OrganizationUsageCompletionsResult = value;
        }

        /// <summary>
        /// The aggregated embeddings usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageEmbeddingsResult? OrganizationUsageEmbeddingsResult { get; init; }
#else
        public global::G.UsageEmbeddingsResult? OrganizationUsageEmbeddingsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageEmbeddingsResult))]
#endif
        public bool IsOrganizationUsageEmbeddingsResult => OrganizationUsageEmbeddingsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageEmbeddingsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageEmbeddingsResult?(ResultItem @this) => @this.OrganizationUsageEmbeddingsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageEmbeddingsResult? value)
        {
            OrganizationUsageEmbeddingsResult = value;
        }

        /// <summary>
        /// The aggregated moderations usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageModerationsResult? OrganizationUsageModerationsResult { get; init; }
#else
        public global::G.UsageModerationsResult? OrganizationUsageModerationsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageModerationsResult))]
#endif
        public bool IsOrganizationUsageModerationsResult => OrganizationUsageModerationsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageModerationsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageModerationsResult?(ResultItem @this) => @this.OrganizationUsageModerationsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageModerationsResult? value)
        {
            OrganizationUsageModerationsResult = value;
        }

        /// <summary>
        /// The aggregated images usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageImagesResult? OrganizationUsageImagesResult { get; init; }
#else
        public global::G.UsageImagesResult? OrganizationUsageImagesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageImagesResult))]
#endif
        public bool IsOrganizationUsageImagesResult => OrganizationUsageImagesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageImagesResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageImagesResult?(ResultItem @this) => @this.OrganizationUsageImagesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageImagesResult? value)
        {
            OrganizationUsageImagesResult = value;
        }

        /// <summary>
        /// The aggregated audio speeches usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageAudioSpeechesResult? OrganizationUsageAudioSpeechesResult { get; init; }
#else
        public global::G.UsageAudioSpeechesResult? OrganizationUsageAudioSpeechesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageAudioSpeechesResult))]
#endif
        public bool IsOrganizationUsageAudioSpeechesResult => OrganizationUsageAudioSpeechesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageAudioSpeechesResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageAudioSpeechesResult?(ResultItem @this) => @this.OrganizationUsageAudioSpeechesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageAudioSpeechesResult? value)
        {
            OrganizationUsageAudioSpeechesResult = value;
        }

        /// <summary>
        /// The aggregated audio transcriptions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageAudioTranscriptionsResult? OrganizationUsageAudioTranscriptionsResult { get; init; }
#else
        public global::G.UsageAudioTranscriptionsResult? OrganizationUsageAudioTranscriptionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageAudioTranscriptionsResult))]
#endif
        public bool IsOrganizationUsageAudioTranscriptionsResult => OrganizationUsageAudioTranscriptionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageAudioTranscriptionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageAudioTranscriptionsResult?(ResultItem @this) => @this.OrganizationUsageAudioTranscriptionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageAudioTranscriptionsResult? value)
        {
            OrganizationUsageAudioTranscriptionsResult = value;
        }

        /// <summary>
        /// The aggregated vector stores usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageVectorStoresResult? OrganizationUsageVectorStoresResult { get; init; }
#else
        public global::G.UsageVectorStoresResult? OrganizationUsageVectorStoresResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageVectorStoresResult))]
#endif
        public bool IsOrganizationUsageVectorStoresResult => OrganizationUsageVectorStoresResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageVectorStoresResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageVectorStoresResult?(ResultItem @this) => @this.OrganizationUsageVectorStoresResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageVectorStoresResult? value)
        {
            OrganizationUsageVectorStoresResult = value;
        }

        /// <summary>
        /// The aggregated code interpreter sessions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageCodeInterpreterSessionsResult? OrganizationUsageCodeInterpreterSessionsResult { get; init; }
#else
        public global::G.UsageCodeInterpreterSessionsResult? OrganizationUsageCodeInterpreterSessionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageCodeInterpreterSessionsResult))]
#endif
        public bool IsOrganizationUsageCodeInterpreterSessionsResult => OrganizationUsageCodeInterpreterSessionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.UsageCodeInterpreterSessionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageCodeInterpreterSessionsResult?(ResultItem @this) => @this.OrganizationUsageCodeInterpreterSessionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.UsageCodeInterpreterSessionsResult? value)
        {
            OrganizationUsageCodeInterpreterSessionsResult = value;
        }

        /// <summary>
        /// The aggregated costs details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CostsResult? OrganizationCostsResult { get; init; }
#else
        public global::G.CostsResult? OrganizationCostsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationCostsResult))]
#endif
        public bool IsOrganizationCostsResult => OrganizationCostsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::G.CostsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CostsResult?(ResultItem @this) => @this.OrganizationCostsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::G.CostsResult? value)
        {
            OrganizationCostsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(
            global::G.UsageTimeBucketResultItemDiscriminatorObject? @object,
            global::G.UsageCompletionsResult? organizationUsageCompletionsResult,
            global::G.UsageEmbeddingsResult? organizationUsageEmbeddingsResult,
            global::G.UsageModerationsResult? organizationUsageModerationsResult,
            global::G.UsageImagesResult? organizationUsageImagesResult,
            global::G.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult,
            global::G.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult,
            global::G.UsageVectorStoresResult? organizationUsageVectorStoresResult,
            global::G.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult,
            global::G.CostsResult? organizationCostsResult
            )
        {
            Object = @object;

            OrganizationUsageCompletionsResult = organizationUsageCompletionsResult;
            OrganizationUsageEmbeddingsResult = organizationUsageEmbeddingsResult;
            OrganizationUsageModerationsResult = organizationUsageModerationsResult;
            OrganizationUsageImagesResult = organizationUsageImagesResult;
            OrganizationUsageAudioSpeechesResult = organizationUsageAudioSpeechesResult;
            OrganizationUsageAudioTranscriptionsResult = organizationUsageAudioTranscriptionsResult;
            OrganizationUsageVectorStoresResult = organizationUsageVectorStoresResult;
            OrganizationUsageCodeInterpreterSessionsResult = organizationUsageCodeInterpreterSessionsResult;
            OrganizationCostsResult = organizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object1 =>
            OrganizationCostsResult as object ??
            OrganizationUsageCodeInterpreterSessionsResult as object ??
            OrganizationUsageVectorStoresResult as object ??
            OrganizationUsageAudioTranscriptionsResult as object ??
            OrganizationUsageAudioSpeechesResult as object ??
            OrganizationUsageImagesResult as object ??
            OrganizationUsageModerationsResult as object ??
            OrganizationUsageEmbeddingsResult as object ??
            OrganizationUsageCompletionsResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && IsOrganizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UsageCompletionsResult?, TResult>? organizationUsageCompletionsResult = null,
            global::System.Func<global::G.UsageEmbeddingsResult?, TResult>? organizationUsageEmbeddingsResult = null,
            global::System.Func<global::G.UsageModerationsResult?, TResult>? organizationUsageModerationsResult = null,
            global::System.Func<global::G.UsageImagesResult?, TResult>? organizationUsageImagesResult = null,
            global::System.Func<global::G.UsageAudioSpeechesResult?, TResult>? organizationUsageAudioSpeechesResult = null,
            global::System.Func<global::G.UsageAudioTranscriptionsResult?, TResult>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Func<global::G.UsageVectorStoresResult?, TResult>? organizationUsageVectorStoresResult = null,
            global::System.Func<global::G.UsageCodeInterpreterSessionsResult?, TResult>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Func<global::G.CostsResult?, TResult>? organizationCostsResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganizationUsageCompletionsResult && organizationUsageCompletionsResult != null)
            {
                return organizationUsageCompletionsResult(OrganizationUsageCompletionsResult!);
            }
            else if (IsOrganizationUsageEmbeddingsResult && organizationUsageEmbeddingsResult != null)
            {
                return organizationUsageEmbeddingsResult(OrganizationUsageEmbeddingsResult!);
            }
            else if (IsOrganizationUsageModerationsResult && organizationUsageModerationsResult != null)
            {
                return organizationUsageModerationsResult(OrganizationUsageModerationsResult!);
            }
            else if (IsOrganizationUsageImagesResult && organizationUsageImagesResult != null)
            {
                return organizationUsageImagesResult(OrganizationUsageImagesResult!);
            }
            else if (IsOrganizationUsageAudioSpeechesResult && organizationUsageAudioSpeechesResult != null)
            {
                return organizationUsageAudioSpeechesResult(OrganizationUsageAudioSpeechesResult!);
            }
            else if (IsOrganizationUsageAudioTranscriptionsResult && organizationUsageAudioTranscriptionsResult != null)
            {
                return organizationUsageAudioTranscriptionsResult(OrganizationUsageAudioTranscriptionsResult!);
            }
            else if (IsOrganizationUsageVectorStoresResult && organizationUsageVectorStoresResult != null)
            {
                return organizationUsageVectorStoresResult(OrganizationUsageVectorStoresResult!);
            }
            else if (IsOrganizationUsageCodeInterpreterSessionsResult && organizationUsageCodeInterpreterSessionsResult != null)
            {
                return organizationUsageCodeInterpreterSessionsResult(OrganizationUsageCodeInterpreterSessionsResult!);
            }
            else if (IsOrganizationCostsResult && organizationCostsResult != null)
            {
                return organizationCostsResult(OrganizationCostsResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UsageCompletionsResult?>? organizationUsageCompletionsResult = null,
            global::System.Action<global::G.UsageEmbeddingsResult?>? organizationUsageEmbeddingsResult = null,
            global::System.Action<global::G.UsageModerationsResult?>? organizationUsageModerationsResult = null,
            global::System.Action<global::G.UsageImagesResult?>? organizationUsageImagesResult = null,
            global::System.Action<global::G.UsageAudioSpeechesResult?>? organizationUsageAudioSpeechesResult = null,
            global::System.Action<global::G.UsageAudioTranscriptionsResult?>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Action<global::G.UsageVectorStoresResult?>? organizationUsageVectorStoresResult = null,
            global::System.Action<global::G.UsageCodeInterpreterSessionsResult?>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Action<global::G.CostsResult?>? organizationCostsResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganizationUsageCompletionsResult)
            {
                organizationUsageCompletionsResult?.Invoke(OrganizationUsageCompletionsResult!);
            }
            else if (IsOrganizationUsageEmbeddingsResult)
            {
                organizationUsageEmbeddingsResult?.Invoke(OrganizationUsageEmbeddingsResult!);
            }
            else if (IsOrganizationUsageModerationsResult)
            {
                organizationUsageModerationsResult?.Invoke(OrganizationUsageModerationsResult!);
            }
            else if (IsOrganizationUsageImagesResult)
            {
                organizationUsageImagesResult?.Invoke(OrganizationUsageImagesResult!);
            }
            else if (IsOrganizationUsageAudioSpeechesResult)
            {
                organizationUsageAudioSpeechesResult?.Invoke(OrganizationUsageAudioSpeechesResult!);
            }
            else if (IsOrganizationUsageAudioTranscriptionsResult)
            {
                organizationUsageAudioTranscriptionsResult?.Invoke(OrganizationUsageAudioTranscriptionsResult!);
            }
            else if (IsOrganizationUsageVectorStoresResult)
            {
                organizationUsageVectorStoresResult?.Invoke(OrganizationUsageVectorStoresResult!);
            }
            else if (IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                organizationUsageCodeInterpreterSessionsResult?.Invoke(OrganizationUsageCodeInterpreterSessionsResult!);
            }
            else if (IsOrganizationCostsResult)
            {
                organizationCostsResult?.Invoke(OrganizationCostsResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrganizationUsageCompletionsResult,
                typeof(global::G.UsageCompletionsResult),
                OrganizationUsageEmbeddingsResult,
                typeof(global::G.UsageEmbeddingsResult),
                OrganizationUsageModerationsResult,
                typeof(global::G.UsageModerationsResult),
                OrganizationUsageImagesResult,
                typeof(global::G.UsageImagesResult),
                OrganizationUsageAudioSpeechesResult,
                typeof(global::G.UsageAudioSpeechesResult),
                OrganizationUsageAudioTranscriptionsResult,
                typeof(global::G.UsageAudioTranscriptionsResult),
                OrganizationUsageVectorStoresResult,
                typeof(global::G.UsageVectorStoresResult),
                OrganizationUsageCodeInterpreterSessionsResult,
                typeof(global::G.UsageCodeInterpreterSessionsResult),
                OrganizationCostsResult,
                typeof(global::G.CostsResult),
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
        public bool Equals(ResultItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UsageCompletionsResult?>.Default.Equals(OrganizationUsageCompletionsResult, other.OrganizationUsageCompletionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageEmbeddingsResult?>.Default.Equals(OrganizationUsageEmbeddingsResult, other.OrganizationUsageEmbeddingsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageModerationsResult?>.Default.Equals(OrganizationUsageModerationsResult, other.OrganizationUsageModerationsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageImagesResult?>.Default.Equals(OrganizationUsageImagesResult, other.OrganizationUsageImagesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageAudioSpeechesResult?>.Default.Equals(OrganizationUsageAudioSpeechesResult, other.OrganizationUsageAudioSpeechesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageAudioTranscriptionsResult?>.Default.Equals(OrganizationUsageAudioTranscriptionsResult, other.OrganizationUsageAudioTranscriptionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageVectorStoresResult?>.Default.Equals(OrganizationUsageVectorStoresResult, other.OrganizationUsageVectorStoresResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageCodeInterpreterSessionsResult?>.Default.Equals(OrganizationUsageCodeInterpreterSessionsResult, other.OrganizationUsageCodeInterpreterSessionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CostsResult?>.Default.Equals(OrganizationCostsResult, other.OrganizationCostsResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultItem obj1, ResultItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultItem obj1, ResultItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultItem o && Equals(o);
        }
    }
}
