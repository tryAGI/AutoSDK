//HintName: G.Models.TextToImageRequestBody.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"cfg_scale":7,"clip_guidance_preset":"FAST_BLUE","height":512,"sampler":"K_DPM_2_ANCESTRAL","samples":1,"seed":0,"steps":75,"text_prompts":[{"text":"A lighthouse on a cliff","weight":1}],"width":512}
    /// </summary>
    public readonly partial struct TextToImageRequestBody : global::System.IEquatable<TextToImageRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToImageRequestBodyVariant1? TextToImageRequestBodyVariant1 { get; init; }
#else
        public global::G.TextToImageRequestBodyVariant1? TextToImageRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImageRequestBodyVariant1))]
#endif
        public bool IsTextToImageRequestBodyVariant1 => TextToImageRequestBodyVariant1 != null;

        /// <summary>
        /// Represents the optional parameters that can be passed to any generation request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationRequestOptionalParams? GenerationOptionalParams { get; init; }
#else
        public global::G.GenerationRequestOptionalParams? GenerationOptionalParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationOptionalParams))]
#endif
        public bool IsGenerationOptionalParams => GenerationOptionalParams != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToImageRequestBody(global::G.TextToImageRequestBodyVariant1 value) => new TextToImageRequestBody((global::G.TextToImageRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToImageRequestBodyVariant1?(TextToImageRequestBody @this) => @this.TextToImageRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(global::G.TextToImageRequestBodyVariant1? value)
        {
            TextToImageRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToImageRequestBody(global::G.GenerationRequestOptionalParams value) => new TextToImageRequestBody((global::G.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequestOptionalParams?(TextToImageRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(global::G.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToImageRequestBody(
            global::G.TextToImageRequestBodyVariant1? textToImageRequestBodyVariant1,
            global::G.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            TextToImageRequestBodyVariant1 = textToImageRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            TextToImageRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToImageRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToImageRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextToImageRequestBodyVariant1?, TResult>? textToImageRequestBodyVariant1 = null,
            global::System.Func<global::G.GenerationRequestOptionalParams?, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToImageRequestBodyVariant1 && textToImageRequestBodyVariant1 != null)
            {
                return textToImageRequestBodyVariant1(TextToImageRequestBodyVariant1!);
            }
            else if (IsGenerationOptionalParams && generationOptionalParams != null)
            {
                return generationOptionalParams(GenerationOptionalParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextToImageRequestBodyVariant1?>? textToImageRequestBodyVariant1 = null,
            global::System.Action<global::G.GenerationRequestOptionalParams?>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToImageRequestBodyVariant1)
            {
                textToImageRequestBodyVariant1?.Invoke(TextToImageRequestBodyVariant1!);
            }
            else if (IsGenerationOptionalParams)
            {
                generationOptionalParams?.Invoke(GenerationOptionalParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToImageRequestBodyVariant1,
                typeof(global::G.TextToImageRequestBodyVariant1),
                GenerationOptionalParams,
                typeof(global::G.GenerationRequestOptionalParams),
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
        public bool Equals(TextToImageRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextToImageRequestBodyVariant1?>.Default.Equals(TextToImageRequestBodyVariant1, other.TextToImageRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToImageRequestBody obj1, TextToImageRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToImageRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToImageRequestBody obj1, TextToImageRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToImageRequestBody o && Equals(o);
        }
    }
}
