//HintName: G.Models.MaskingUsingMaskImageRequestBody.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MaskingUsingMaskImageRequestBody : global::System.IEquatable<MaskingUsingMaskImageRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MaskingUsingMaskImageRequestBodyVariant1? MaskingUsingMaskImageRequestBodyVariant1 { get; init; }
#else
        public global::G.MaskingUsingMaskImageRequestBodyVariant1? MaskingUsingMaskImageRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaskingUsingMaskImageRequestBodyVariant1))]
#endif
        public bool IsMaskingUsingMaskImageRequestBodyVariant1 => MaskingUsingMaskImageRequestBodyVariant1 != null;

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
        public static implicit operator MaskingUsingMaskImageRequestBody(global::G.MaskingUsingMaskImageRequestBodyVariant1 value) => new MaskingUsingMaskImageRequestBody((global::G.MaskingUsingMaskImageRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MaskingUsingMaskImageRequestBodyVariant1?(MaskingUsingMaskImageRequestBody @this) => @this.MaskingUsingMaskImageRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingMaskImageRequestBody(global::G.MaskingUsingMaskImageRequestBodyVariant1? value)
        {
            MaskingUsingMaskImageRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaskingUsingMaskImageRequestBody(global::G.GenerationRequestOptionalParams value) => new MaskingUsingMaskImageRequestBody((global::G.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequestOptionalParams?(MaskingUsingMaskImageRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingMaskImageRequestBody(global::G.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingMaskImageRequestBody(
            global::G.MaskingUsingMaskImageRequestBodyVariant1? maskingUsingMaskImageRequestBodyVariant1,
            global::G.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            MaskingUsingMaskImageRequestBodyVariant1 = maskingUsingMaskImageRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            MaskingUsingMaskImageRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MaskingUsingMaskImageRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMaskingUsingMaskImageRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MaskingUsingMaskImageRequestBodyVariant1?, TResult>? maskingUsingMaskImageRequestBodyVariant1 = null,
            global::System.Func<global::G.GenerationRequestOptionalParams?, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingMaskImageRequestBodyVariant1 && maskingUsingMaskImageRequestBodyVariant1 != null)
            {
                return maskingUsingMaskImageRequestBodyVariant1(MaskingUsingMaskImageRequestBodyVariant1!);
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
            global::System.Action<global::G.MaskingUsingMaskImageRequestBodyVariant1?>? maskingUsingMaskImageRequestBodyVariant1 = null,
            global::System.Action<global::G.GenerationRequestOptionalParams?>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingMaskImageRequestBodyVariant1)
            {
                maskingUsingMaskImageRequestBodyVariant1?.Invoke(MaskingUsingMaskImageRequestBodyVariant1!);
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
                MaskingUsingMaskImageRequestBodyVariant1,
                typeof(global::G.MaskingUsingMaskImageRequestBodyVariant1),
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
        public bool Equals(MaskingUsingMaskImageRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MaskingUsingMaskImageRequestBodyVariant1?>.Default.Equals(MaskingUsingMaskImageRequestBodyVariant1, other.MaskingUsingMaskImageRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MaskingUsingMaskImageRequestBody obj1, MaskingUsingMaskImageRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MaskingUsingMaskImageRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MaskingUsingMaskImageRequestBody obj1, MaskingUsingMaskImageRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MaskingUsingMaskImageRequestBody o && Equals(o);
        }
    }
}
