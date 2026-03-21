//HintName: G.Models.CreateSpeechToSpeechRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSpeechToSpeechRequest : global::System.IEquatable<CreateSpeechToSpeechRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2? ElevenMultilingualStsV2 { get; init; }
#else
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2? ElevenMultilingualStsV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenMultilingualStsV2))]
#endif
        public bool IsElevenMultilingualStsV2 => ElevenMultilingualStsV2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechToSpeechRequest(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2 value) => new CreateSpeechToSpeechRequest((global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2?(CreateSpeechToSpeechRequest @this) => @this.ElevenMultilingualStsV2;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechToSpeechRequest(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2? value)
        {
            ElevenMultilingualStsV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenMultilingualStsV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenMultilingualStsV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenMultilingualStsV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2?, TResult>? elevenMultilingualStsV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenMultilingualStsV2 && elevenMultilingualStsV2 != null)
            {
                return elevenMultilingualStsV2(ElevenMultilingualStsV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2?>? elevenMultilingualStsV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenMultilingualStsV2)
            {
                elevenMultilingualStsV2?.Invoke(ElevenMultilingualStsV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenMultilingualStsV2,
                typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2),
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
        public bool Equals(CreateSpeechToSpeechRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2?>.Default.Equals(ElevenMultilingualStsV2, other.ElevenMultilingualStsV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSpeechToSpeechRequest obj1, CreateSpeechToSpeechRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSpeechToSpeechRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSpeechToSpeechRequest obj1, CreateSpeechToSpeechRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSpeechToSpeechRequest o && Equals(o);
        }
    }
}
