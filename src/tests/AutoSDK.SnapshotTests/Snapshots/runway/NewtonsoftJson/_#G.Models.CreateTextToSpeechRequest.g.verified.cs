//HintName: G.Models.CreateTextToSpeechRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTextToSpeechRequest : global::System.IEquatable<CreateTextToSpeechRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToSpeechRequestElevenMultilingualV2? ElevenMultilingualV2 { get; init; }
#else
        public global::G.CreateTextToSpeechRequestElevenMultilingualV2? ElevenMultilingualV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenMultilingualV2))]
#endif
        public bool IsElevenMultilingualV2 => ElevenMultilingualV2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::G.CreateTextToSpeechRequestElevenMultilingualV2 value) => new CreateTextToSpeechRequest((global::G.CreateTextToSpeechRequestElevenMultilingualV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToSpeechRequestElevenMultilingualV2?(CreateTextToSpeechRequest @this) => @this.ElevenMultilingualV2;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToSpeechRequest(global::G.CreateTextToSpeechRequestElevenMultilingualV2? value)
        {
            ElevenMultilingualV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenMultilingualV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenMultilingualV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenMultilingualV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateTextToSpeechRequestElevenMultilingualV2?, TResult>? elevenMultilingualV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenMultilingualV2 && elevenMultilingualV2 != null)
            {
                return elevenMultilingualV2(ElevenMultilingualV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateTextToSpeechRequestElevenMultilingualV2?>? elevenMultilingualV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenMultilingualV2)
            {
                elevenMultilingualV2?.Invoke(ElevenMultilingualV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenMultilingualV2,
                typeof(global::G.CreateTextToSpeechRequestElevenMultilingualV2),
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
        public bool Equals(CreateTextToSpeechRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToSpeechRequestElevenMultilingualV2?>.Default.Equals(ElevenMultilingualV2, other.ElevenMultilingualV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTextToSpeechRequest obj1, CreateTextToSpeechRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToSpeechRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTextToSpeechRequest obj1, CreateTextToSpeechRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToSpeechRequest o && Equals(o);
        }
    }
}
