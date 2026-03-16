//HintName: G.Models.Request9.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request9 : global::System.IEquatable<Request9>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestElevenVoiceDubbing? ElevenVoiceDubbing { get; init; }
#else
        public global::G.RequestElevenVoiceDubbing? ElevenVoiceDubbing { get; }
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
        public static implicit operator Request9(global::G.RequestElevenVoiceDubbing value) => new Request9((global::G.RequestElevenVoiceDubbing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestElevenVoiceDubbing?(Request9 @this) => @this.ElevenVoiceDubbing;

        /// <summary>
        /// 
        /// </summary>
        public Request9(global::G.RequestElevenVoiceDubbing? value)
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
            global::System.Func<global::G.RequestElevenVoiceDubbing?, TResult>? elevenVoiceDubbing = null,
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
            global::System.Action<global::G.RequestElevenVoiceDubbing?>? elevenVoiceDubbing = null,
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
                typeof(global::G.RequestElevenVoiceDubbing),
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
        public bool Equals(Request9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestElevenVoiceDubbing?>.Default.Equals(ElevenVoiceDubbing, other.ElevenVoiceDubbing) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request9 obj1, Request9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request9 obj1, Request9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request9 o && Equals(o);
        }
    }
}
