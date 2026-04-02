//HintName: G.Models.MaskingUsingInitImageAlphaRequestBody.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MaskingUsingInitImageAlphaRequestBody : global::System.IEquatable<MaskingUsingInitImageAlphaRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MaskingUsingInitImageAlphaRequestBodyVariant1? MaskingUsingInitImageAlphaRequestBodyVariant1 { get; init; }
#else
        public global::G.MaskingUsingInitImageAlphaRequestBodyVariant1? MaskingUsingInitImageAlphaRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaskingUsingInitImageAlphaRequestBodyVariant1))]
#endif
        public bool IsMaskingUsingInitImageAlphaRequestBodyVariant1 => MaskingUsingInitImageAlphaRequestBodyVariant1 != null;

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
        public static implicit operator MaskingUsingInitImageAlphaRequestBody(global::G.MaskingUsingInitImageAlphaRequestBodyVariant1 value) => new MaskingUsingInitImageAlphaRequestBody((global::G.MaskingUsingInitImageAlphaRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MaskingUsingInitImageAlphaRequestBodyVariant1?(MaskingUsingInitImageAlphaRequestBody @this) => @this.MaskingUsingInitImageAlphaRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(global::G.MaskingUsingInitImageAlphaRequestBodyVariant1? value)
        {
            MaskingUsingInitImageAlphaRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaskingUsingInitImageAlphaRequestBody(global::G.GenerationRequestOptionalParams value) => new MaskingUsingInitImageAlphaRequestBody((global::G.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequestOptionalParams?(MaskingUsingInitImageAlphaRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(global::G.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MaskingUsingInitImageAlphaRequestBody(
            global::G.MaskingUsingInitImageAlphaRequestBodyVariant1? maskingUsingInitImageAlphaRequestBodyVariant1,
            global::G.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            MaskingUsingInitImageAlphaRequestBodyVariant1 = maskingUsingInitImageAlphaRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            MaskingUsingInitImageAlphaRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MaskingUsingInitImageAlphaRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMaskingUsingInitImageAlphaRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MaskingUsingInitImageAlphaRequestBodyVariant1?, TResult>? maskingUsingInitImageAlphaRequestBodyVariant1 = null,
            global::System.Func<global::G.GenerationRequestOptionalParams?, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingInitImageAlphaRequestBodyVariant1 && maskingUsingInitImageAlphaRequestBodyVariant1 != null)
            {
                return maskingUsingInitImageAlphaRequestBodyVariant1(MaskingUsingInitImageAlphaRequestBodyVariant1!);
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
            global::System.Action<global::G.MaskingUsingInitImageAlphaRequestBodyVariant1?>? maskingUsingInitImageAlphaRequestBodyVariant1 = null,
            global::System.Action<global::G.GenerationRequestOptionalParams?>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaskingUsingInitImageAlphaRequestBodyVariant1)
            {
                maskingUsingInitImageAlphaRequestBodyVariant1?.Invoke(MaskingUsingInitImageAlphaRequestBodyVariant1!);
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
                MaskingUsingInitImageAlphaRequestBodyVariant1,
                typeof(global::G.MaskingUsingInitImageAlphaRequestBodyVariant1),
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
        public bool Equals(MaskingUsingInitImageAlphaRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MaskingUsingInitImageAlphaRequestBodyVariant1?>.Default.Equals(MaskingUsingInitImageAlphaRequestBodyVariant1, other.MaskingUsingInitImageAlphaRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MaskingUsingInitImageAlphaRequestBody obj1, MaskingUsingInitImageAlphaRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MaskingUsingInitImageAlphaRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MaskingUsingInitImageAlphaRequestBody obj1, MaskingUsingInitImageAlphaRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MaskingUsingInitImageAlphaRequestBody o && Equals(o);
        }
    }
}
