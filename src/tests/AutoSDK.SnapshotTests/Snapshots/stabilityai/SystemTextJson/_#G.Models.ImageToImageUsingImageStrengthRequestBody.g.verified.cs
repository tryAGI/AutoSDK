//HintName: G.Models.ImageToImageUsingImageStrengthRequestBody.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageToImageUsingImageStrengthRequestBody : global::System.IEquatable<ImageToImageUsingImageStrengthRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageToImageUsingImageStrengthRequestBodyVariant1? ImageToImageUsingImageStrengthRequestBodyVariant1 { get; init; }
#else
        public global::G.ImageToImageUsingImageStrengthRequestBodyVariant1? ImageToImageUsingImageStrengthRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToImageUsingImageStrengthRequestBodyVariant1))]
#endif
        public bool IsImageToImageUsingImageStrengthRequestBodyVariant1 => ImageToImageUsingImageStrengthRequestBodyVariant1 != null;

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
        public static implicit operator ImageToImageUsingImageStrengthRequestBody(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1 value) => new ImageToImageUsingImageStrengthRequestBody((global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?(ImageToImageUsingImageStrengthRequestBody @this) => @this.ImageToImageUsingImageStrengthRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingImageStrengthRequestBody(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1? value)
        {
            ImageToImageUsingImageStrengthRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageUsingImageStrengthRequestBody(global::G.GenerationRequestOptionalParams value) => new ImageToImageUsingImageStrengthRequestBody((global::G.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequestOptionalParams?(ImageToImageUsingImageStrengthRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingImageStrengthRequestBody(global::G.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingImageStrengthRequestBody(
            global::G.ImageToImageUsingImageStrengthRequestBodyVariant1? imageToImageUsingImageStrengthRequestBodyVariant1,
            global::G.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            ImageToImageUsingImageStrengthRequestBodyVariant1 = imageToImageUsingImageStrengthRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            ImageToImageUsingImageStrengthRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageToImageUsingImageStrengthRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageToImageUsingImageStrengthRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?, TResult>? imageToImageUsingImageStrengthRequestBodyVariant1 = null,
            global::System.Func<global::G.GenerationRequestOptionalParams?, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToImageUsingImageStrengthRequestBodyVariant1 && imageToImageUsingImageStrengthRequestBodyVariant1 != null)
            {
                return imageToImageUsingImageStrengthRequestBodyVariant1(ImageToImageUsingImageStrengthRequestBodyVariant1!);
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
            global::System.Action<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?>? imageToImageUsingImageStrengthRequestBodyVariant1 = null,
            global::System.Action<global::G.GenerationRequestOptionalParams?>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToImageUsingImageStrengthRequestBodyVariant1)
            {
                imageToImageUsingImageStrengthRequestBodyVariant1?.Invoke(ImageToImageUsingImageStrengthRequestBodyVariant1!);
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
                ImageToImageUsingImageStrengthRequestBodyVariant1,
                typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1),
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
        public bool Equals(ImageToImageUsingImageStrengthRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?>.Default.Equals(ImageToImageUsingImageStrengthRequestBodyVariant1, other.ImageToImageUsingImageStrengthRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageToImageUsingImageStrengthRequestBody obj1, ImageToImageUsingImageStrengthRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageToImageUsingImageStrengthRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageToImageUsingImageStrengthRequestBody obj1, ImageToImageUsingImageStrengthRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageToImageUsingImageStrengthRequestBody o && Equals(o);
        }
    }
}
