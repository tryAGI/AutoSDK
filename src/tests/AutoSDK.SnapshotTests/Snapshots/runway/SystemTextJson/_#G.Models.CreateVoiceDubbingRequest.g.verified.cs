//HintName: G.Models.CreateVoiceDubbingRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateVoiceDubbingRequest : global::System.IEquatable<CreateVoiceDubbingRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVoiceDubbingRequestElevenVoiceDubbing? ElevenVoiceDubbing { get; init; }
#else
        public global::G.CreateVoiceDubbingRequestElevenVoiceDubbing? ElevenVoiceDubbing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenVoiceDubbing))]
#endif
        public bool IsElevenVoiceDubbing => ElevenVoiceDubbing != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVoiceDubbingRequest(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing value) => new CreateVoiceDubbingRequest((global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?(CreateVoiceDubbingRequest @this) => @this.ElevenVoiceDubbing;

        /// <summary>
        /// 
        /// </summary>
        public CreateVoiceDubbingRequest(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing? value)
        {
            ElevenVoiceDubbing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenVoiceDubbing as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenVoiceDubbing?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenVoiceDubbing;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?, TResult>? elevenVoiceDubbing = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceDubbing && elevenVoiceDubbing != null)
            {
                return elevenVoiceDubbing(ElevenVoiceDubbing!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?>? elevenVoiceDubbing = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceDubbing)
            {
                elevenVoiceDubbing?.Invoke(ElevenVoiceDubbing!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenVoiceDubbing,
                typeof(global::G.CreateVoiceDubbingRequestElevenVoiceDubbing),
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
        public bool Equals(CreateVoiceDubbingRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVoiceDubbingRequestElevenVoiceDubbing?>.Default.Equals(ElevenVoiceDubbing, other.ElevenVoiceDubbing) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateVoiceDubbingRequest obj1, CreateVoiceDubbingRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVoiceDubbingRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateVoiceDubbingRequest obj1, CreateVoiceDubbingRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVoiceDubbingRequest o && Equals(o);
        }
    }
}
