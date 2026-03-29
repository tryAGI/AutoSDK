//HintName: G.Models.GeneratedAsset.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A generated asset is a media asset created by the Create API. You can use native or third party providers to generate video, audio and image files using Generative AI services like text-to-speech and text-to-avatar.
    /// </summary>
    public readonly partial struct GeneratedAsset : global::System.IEquatable<GeneratedAsset>
    {
        /// <summary>
        /// Generate assets using the native Shotstack provider. Shotstack provides a text-to-speech and a text-to-image service. The Shotstack provider works natively with your existing API key, no additional credentials are required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShotstackGeneratedAsset? Shotstack { get; init; }
#else
        public global::G.ShotstackGeneratedAsset? Shotstack { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shotstack))]
#endif
        public bool IsShotstack => Shotstack != null;

        /// <summary>
        /// Generate assets using D-ID. D-ID provide a text-to-avatar service. The D-ID provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/d-id), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DIDGeneratedAsset? DId { get; init; }
#else
        public global::G.DIDGeneratedAsset? DId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DId))]
#endif
        public bool IsDId => DId != null;

        /// <summary>
        /// Generate assets using ElevenLabs. ElevenLabs provide a text-to-speech service. The ElevenLabs provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/elevenlabs), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ElevenLabsGeneratedAsset? Elevenlabs { get; init; }
#else
        public global::G.ElevenLabsGeneratedAsset? Elevenlabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Elevenlabs))]
#endif
        public bool IsElevenlabs => Elevenlabs != null;

        /// <summary>
        /// Generate assets using HeyGen. HeyGen provide a text-to-avatar service.  The HeyGen provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/heygen), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HeyGenGeneratedAsset? Heygen { get; init; }
#else
        public global::G.HeyGenGeneratedAsset? Heygen { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Heygen))]
#endif
        public bool IsHeygen => Heygen != null;

        /// <summary>
        /// Generate assets using OpenAI. OpenAI provide a text generation service using ChatGPT 3.5 and 4. The OpenAI provider works on a bring-your-own-key basis, credentials are required and must be added via the [dashboard](https://dashboard.shotstack.io/integrations/openai), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiGeneratedAsset? Openai { get; init; }
#else
        public global::G.OpenAiGeneratedAsset? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// Generate assets using Stability AI. Stability AI provide a text-to-image service using Stable Diffusion. The Stability AI provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/stability-ai), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StabilityAiGeneratedAsset? StabilityAi { get; init; }
#else
        public global::G.StabilityAiGeneratedAsset? StabilityAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StabilityAi))]
#endif
        public bool IsStabilityAi => StabilityAi != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.ShotstackGeneratedAsset value) => new GeneratedAsset((global::G.ShotstackGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShotstackGeneratedAsset?(GeneratedAsset @this) => @this.Shotstack;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.ShotstackGeneratedAsset? value)
        {
            Shotstack = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.DIDGeneratedAsset value) => new GeneratedAsset((global::G.DIDGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DIDGeneratedAsset?(GeneratedAsset @this) => @this.DId;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.DIDGeneratedAsset? value)
        {
            DId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.ElevenLabsGeneratedAsset value) => new GeneratedAsset((global::G.ElevenLabsGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ElevenLabsGeneratedAsset?(GeneratedAsset @this) => @this.Elevenlabs;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.ElevenLabsGeneratedAsset? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.HeyGenGeneratedAsset value) => new GeneratedAsset((global::G.HeyGenGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeyGenGeneratedAsset?(GeneratedAsset @this) => @this.Heygen;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.HeyGenGeneratedAsset? value)
        {
            Heygen = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.OpenAiGeneratedAsset value) => new GeneratedAsset((global::G.OpenAiGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiGeneratedAsset?(GeneratedAsset @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.OpenAiGeneratedAsset? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedAsset(global::G.StabilityAiGeneratedAsset value) => new GeneratedAsset((global::G.StabilityAiGeneratedAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StabilityAiGeneratedAsset?(GeneratedAsset @this) => @this.StabilityAi;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(global::G.StabilityAiGeneratedAsset? value)
        {
            StabilityAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GeneratedAsset(
            global::G.ShotstackGeneratedAsset? shotstack,
            global::G.DIDGeneratedAsset? dId,
            global::G.ElevenLabsGeneratedAsset? elevenlabs,
            global::G.HeyGenGeneratedAsset? heygen,
            global::G.OpenAiGeneratedAsset? openai,
            global::G.StabilityAiGeneratedAsset? stabilityAi
            )
        {
            Shotstack = shotstack;
            DId = dId;
            Elevenlabs = elevenlabs;
            Heygen = heygen;
            Openai = openai;
            StabilityAi = stabilityAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StabilityAi as object ??
            Openai as object ??
            Heygen as object ??
            Elevenlabs as object ??
            DId as object ??
            Shotstack as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shotstack?.ToString() ??
            DId?.ToString() ??
            Elevenlabs?.ToString() ??
            Heygen?.ToString() ??
            Openai?.ToString() ??
            StabilityAi?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShotstack && !IsDId && !IsElevenlabs && !IsHeygen && !IsOpenai && !IsStabilityAi || !IsShotstack && IsDId && !IsElevenlabs && !IsHeygen && !IsOpenai && !IsStabilityAi || !IsShotstack && !IsDId && IsElevenlabs && !IsHeygen && !IsOpenai && !IsStabilityAi || !IsShotstack && !IsDId && !IsElevenlabs && IsHeygen && !IsOpenai && !IsStabilityAi || !IsShotstack && !IsDId && !IsElevenlabs && !IsHeygen && IsOpenai && !IsStabilityAi || !IsShotstack && !IsDId && !IsElevenlabs && !IsHeygen && !IsOpenai && IsStabilityAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ShotstackGeneratedAsset?, TResult>? shotstack = null,
            global::System.Func<global::G.DIDGeneratedAsset?, TResult>? dId = null,
            global::System.Func<global::G.ElevenLabsGeneratedAsset?, TResult>? elevenlabs = null,
            global::System.Func<global::G.HeyGenGeneratedAsset?, TResult>? heygen = null,
            global::System.Func<global::G.OpenAiGeneratedAsset?, TResult>? openai = null,
            global::System.Func<global::G.StabilityAiGeneratedAsset?, TResult>? stabilityAi = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShotstack && shotstack != null)
            {
                return shotstack(Shotstack!);
            }
            else if (IsDId && dId != null)
            {
                return dId(DId!);
            }
            else if (IsElevenlabs && elevenlabs != null)
            {
                return elevenlabs(Elevenlabs!);
            }
            else if (IsHeygen && heygen != null)
            {
                return heygen(Heygen!);
            }
            else if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsStabilityAi && stabilityAi != null)
            {
                return stabilityAi(StabilityAi!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ShotstackGeneratedAsset?>? shotstack = null,
            global::System.Action<global::G.DIDGeneratedAsset?>? dId = null,
            global::System.Action<global::G.ElevenLabsGeneratedAsset?>? elevenlabs = null,
            global::System.Action<global::G.HeyGenGeneratedAsset?>? heygen = null,
            global::System.Action<global::G.OpenAiGeneratedAsset?>? openai = null,
            global::System.Action<global::G.StabilityAiGeneratedAsset?>? stabilityAi = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShotstack)
            {
                shotstack?.Invoke(Shotstack!);
            }
            else if (IsDId)
            {
                dId?.Invoke(DId!);
            }
            else if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsHeygen)
            {
                heygen?.Invoke(Heygen!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsStabilityAi)
            {
                stabilityAi?.Invoke(StabilityAi!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shotstack,
                typeof(global::G.ShotstackGeneratedAsset),
                DId,
                typeof(global::G.DIDGeneratedAsset),
                Elevenlabs,
                typeof(global::G.ElevenLabsGeneratedAsset),
                Heygen,
                typeof(global::G.HeyGenGeneratedAsset),
                Openai,
                typeof(global::G.OpenAiGeneratedAsset),
                StabilityAi,
                typeof(global::G.StabilityAiGeneratedAsset),
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
        public bool Equals(GeneratedAsset other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ShotstackGeneratedAsset?>.Default.Equals(Shotstack, other.Shotstack) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DIDGeneratedAsset?>.Default.Equals(DId, other.DId) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ElevenLabsGeneratedAsset?>.Default.Equals(Elevenlabs, other.Elevenlabs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeyGenGeneratedAsset?>.Default.Equals(Heygen, other.Heygen) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiGeneratedAsset?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StabilityAiGeneratedAsset?>.Default.Equals(StabilityAi, other.StabilityAi) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GeneratedAsset obj1, GeneratedAsset obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GeneratedAsset>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GeneratedAsset obj1, GeneratedAsset obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GeneratedAsset o && Equals(o);
        }
    }
}
