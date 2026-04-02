//HintName: G.Models.ImageToImageUsingStepScheduleRequestBody.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageToImageUsingStepScheduleRequestBody : global::System.IEquatable<ImageToImageUsingStepScheduleRequestBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageToImageUsingStepScheduleRequestBodyVariant1? ImageToImageUsingStepScheduleRequestBodyVariant1 { get; init; }
#else
        public global::G.ImageToImageUsingStepScheduleRequestBodyVariant1? ImageToImageUsingStepScheduleRequestBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToImageUsingStepScheduleRequestBodyVariant1))]
#endif
        public bool IsImageToImageUsingStepScheduleRequestBodyVariant1 => ImageToImageUsingStepScheduleRequestBodyVariant1 != null;

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
        public static implicit operator ImageToImageUsingStepScheduleRequestBody(global::G.ImageToImageUsingStepScheduleRequestBodyVariant1 value) => new ImageToImageUsingStepScheduleRequestBody((global::G.ImageToImageUsingStepScheduleRequestBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageToImageUsingStepScheduleRequestBodyVariant1?(ImageToImageUsingStepScheduleRequestBody @this) => @this.ImageToImageUsingStepScheduleRequestBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingStepScheduleRequestBody(global::G.ImageToImageUsingStepScheduleRequestBodyVariant1? value)
        {
            ImageToImageUsingStepScheduleRequestBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageUsingStepScheduleRequestBody(global::G.GenerationRequestOptionalParams value) => new ImageToImageUsingStepScheduleRequestBody((global::G.GenerationRequestOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequestOptionalParams?(ImageToImageUsingStepScheduleRequestBody @this) => @this.GenerationOptionalParams;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingStepScheduleRequestBody(global::G.GenerationRequestOptionalParams? value)
        {
            GenerationOptionalParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageUsingStepScheduleRequestBody(
            global::G.ImageToImageUsingStepScheduleRequestBodyVariant1? imageToImageUsingStepScheduleRequestBodyVariant1,
            global::G.GenerationRequestOptionalParams? generationOptionalParams
            )
        {
            ImageToImageUsingStepScheduleRequestBodyVariant1 = imageToImageUsingStepScheduleRequestBodyVariant1;
            GenerationOptionalParams = generationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationOptionalParams as object ??
            ImageToImageUsingStepScheduleRequestBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageToImageUsingStepScheduleRequestBodyVariant1?.ToString() ??
            GenerationOptionalParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageToImageUsingStepScheduleRequestBodyVariant1 && IsGenerationOptionalParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ImageToImageUsingStepScheduleRequestBodyVariant1?, TResult>? imageToImageUsingStepScheduleRequestBodyVariant1 = null,
            global::System.Func<global::G.GenerationRequestOptionalParams?, TResult>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToImageUsingStepScheduleRequestBodyVariant1 && imageToImageUsingStepScheduleRequestBodyVariant1 != null)
            {
                return imageToImageUsingStepScheduleRequestBodyVariant1(ImageToImageUsingStepScheduleRequestBodyVariant1!);
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
            global::System.Action<global::G.ImageToImageUsingStepScheduleRequestBodyVariant1?>? imageToImageUsingStepScheduleRequestBodyVariant1 = null,
            global::System.Action<global::G.GenerationRequestOptionalParams?>? generationOptionalParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToImageUsingStepScheduleRequestBodyVariant1)
            {
                imageToImageUsingStepScheduleRequestBodyVariant1?.Invoke(ImageToImageUsingStepScheduleRequestBodyVariant1!);
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
                ImageToImageUsingStepScheduleRequestBodyVariant1,
                typeof(global::G.ImageToImageUsingStepScheduleRequestBodyVariant1),
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
        public bool Equals(ImageToImageUsingStepScheduleRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ImageToImageUsingStepScheduleRequestBodyVariant1?>.Default.Equals(ImageToImageUsingStepScheduleRequestBodyVariant1, other.ImageToImageUsingStepScheduleRequestBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequestOptionalParams?>.Default.Equals(GenerationOptionalParams, other.GenerationOptionalParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageToImageUsingStepScheduleRequestBody obj1, ImageToImageUsingStepScheduleRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageToImageUsingStepScheduleRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageToImageUsingStepScheduleRequestBody obj1, ImageToImageUsingStepScheduleRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageToImageUsingStepScheduleRequestBody o && Equals(o);
        }
    }
}
