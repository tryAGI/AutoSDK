//HintName: G.Models.CreateSoundEffectRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSoundEffectRequest : global::System.IEquatable<CreateSoundEffectRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSoundEffectRequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; init; }
#else
        public global::G.CreateSoundEffectRequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenTextToSoundV2))]
#endif
        public bool IsElevenTextToSoundV2 => ElevenTextToSoundV2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSoundEffectRequest(global::G.CreateSoundEffectRequestElevenTextToSoundV2 value) => new CreateSoundEffectRequest((global::G.CreateSoundEffectRequestElevenTextToSoundV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSoundEffectRequestElevenTextToSoundV2?(CreateSoundEffectRequest @this) => @this.ElevenTextToSoundV2;

        /// <summary>
        /// 
        /// </summary>
        public CreateSoundEffectRequest(global::G.CreateSoundEffectRequestElevenTextToSoundV2? value)
        {
            ElevenTextToSoundV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenTextToSoundV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenTextToSoundV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenTextToSoundV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateSoundEffectRequestElevenTextToSoundV2?, TResult>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenTextToSoundV2 && elevenTextToSoundV2 != null)
            {
                return elevenTextToSoundV2(ElevenTextToSoundV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateSoundEffectRequestElevenTextToSoundV2?>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenTextToSoundV2)
            {
                elevenTextToSoundV2?.Invoke(ElevenTextToSoundV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenTextToSoundV2,
                typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2),
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
        public bool Equals(CreateSoundEffectRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSoundEffectRequestElevenTextToSoundV2?>.Default.Equals(ElevenTextToSoundV2, other.ElevenTextToSoundV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSoundEffectRequest obj1, CreateSoundEffectRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSoundEffectRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSoundEffectRequest obj1, CreateSoundEffectRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSoundEffectRequest o && Equals(o);
        }
    }
}
