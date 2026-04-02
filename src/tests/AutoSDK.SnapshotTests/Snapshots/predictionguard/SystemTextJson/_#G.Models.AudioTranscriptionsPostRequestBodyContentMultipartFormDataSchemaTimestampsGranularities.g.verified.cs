//HintName: G.Models.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Sets whether timestamps are returned and at what granularity.
    /// </summary>
    public readonly partial struct AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities : global::System.IEquatable<AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 { get; init; }
#else
        public string? AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1))]
#endif
        public bool IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 => AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2))]
#endif
        public bool IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 => AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities(string value) => new AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities @this) => @this.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities(string? value)
        {
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities(
            string? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1,
            global::System.Collections.Generic.IList<object>? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2
            )
        {
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 = audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1;
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 = audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 as object ??
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1?.ToString() ??
            AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 && !IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 || !IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 && IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 && audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 != null)
            {
                return audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1!);
            }
            else if (IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 && audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 != null)
            {
                return audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1)
            {
                audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1?.Invoke(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1!);
            }
            else if (IsAudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2)
            {
                audioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2?.Invoke(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1,
                typeof(string),
                AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
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
        public bool Equals(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1, other.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2, other.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities obj1, AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities obj1, AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities o && Equals(o);
        }
    }
}
