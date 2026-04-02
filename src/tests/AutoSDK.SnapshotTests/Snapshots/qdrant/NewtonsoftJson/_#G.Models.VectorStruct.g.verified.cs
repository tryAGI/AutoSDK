//HintName: G.Models.VectorStruct.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Full vector data per point separator with single and multiple vector modes
    /// </summary>
    public readonly partial struct VectorStruct : global::System.IEquatable<VectorStruct>
    {
        /// <summary>
        /// Example: [0.875F, 0.140625F, 0.8976F]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? VectorStructVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorStructVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructVariant1))]
#endif
        public bool IsVectorStructVariant1 => VectorStructVariant1 != null;

        /// <summary>
        /// Example: [[0.875F, 0.140625F, 0.1102F], [0.758F, 0.28126F, 0.96871F], [0.621F, 0.421878F, 0.9375F]]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorStructVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorStructVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructVariant2))]
#endif
        public bool IsVectorStructVariant2 => VectorStructVariant2 != null;

        /// <summary>
        /// Example: {"image-embeddings":[0.8730000257492065,0.140625,0.897599995136261]}
        /// </summary>
#if NET6_0_OR_GREATER
        public object? VectorStructVariant3 { get; init; }
#else
        public object? VectorStructVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructVariant3))]
#endif
        public bool IsVectorStructVariant3 => VectorStructVariant3 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Text document for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Document? Document { get; init; }
#else
        public global::G.Document? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Image object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Image? Image { get; init; }
#else
        public global::G.Image? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Custom object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InferenceObject? InferenceObject { get; init; }
#else
        public global::G.InferenceObject? InferenceObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InferenceObject))]
#endif
        public bool IsInferenceObject => InferenceObject != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.Document value) => new VectorStruct((global::G.Document?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Document?(VectorStruct @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.Document? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.Image value) => new VectorStruct((global::G.Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Image?(VectorStruct @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.Image? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.InferenceObject value) => new VectorStruct((global::G.InferenceObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InferenceObject?(VectorStruct @this) => @this.InferenceObject;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.InferenceObject? value)
        {
            InferenceObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(
            global::System.Collections.Generic.IList<float>? vectorStructVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorStructVariant2,
            object? vectorStructVariant3,
            global::G.Document? document,
            global::G.Image? image,
            global::G.InferenceObject? inferenceObject
            )
        {
            VectorStructVariant1 = vectorStructVariant1;
            VectorStructVariant2 = vectorStructVariant2;
            VectorStructVariant3 = vectorStructVariant3;
            Document = document;
            Image = image;
            InferenceObject = inferenceObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InferenceObject as object ??
            Image as object ??
            Document as object ??
            VectorStructVariant3 as object ??
            VectorStructVariant2 as object ??
            VectorStructVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorStructVariant1?.ToString() ??
            VectorStructVariant2?.ToString() ??
            VectorStructVariant3?.ToString() ??
            Document?.ToString() ??
            Image?.ToString() ??
            InferenceObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorStructVariant1 || IsVectorStructVariant2 || IsVectorStructVariant3 || IsDocument || IsImage || IsInferenceObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? vectorStructVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? vectorStructVariant2 = null,
            global::System.Func<object?, TResult>? vectorStructVariant3 = null,
            global::System.Func<global::G.Document?, TResult>? document = null,
            global::System.Func<global::G.Image?, TResult>? image = null,
            global::System.Func<global::G.InferenceObject?, TResult>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStructVariant1 && vectorStructVariant1 != null)
            {
                return vectorStructVariant1(VectorStructVariant1!);
            }
            else if (IsVectorStructVariant2 && vectorStructVariant2 != null)
            {
                return vectorStructVariant2(VectorStructVariant2!);
            }
            else if (IsVectorStructVariant3 && vectorStructVariant3 != null)
            {
                return vectorStructVariant3(VectorStructVariant3!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsInferenceObject && inferenceObject != null)
            {
                return inferenceObject(InferenceObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? vectorStructVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? vectorStructVariant2 = null,
            global::System.Action<object?>? vectorStructVariant3 = null,
            global::System.Action<global::G.Document?>? document = null,
            global::System.Action<global::G.Image?>? image = null,
            global::System.Action<global::G.InferenceObject?>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStructVariant1)
            {
                vectorStructVariant1?.Invoke(VectorStructVariant1!);
            }
            else if (IsVectorStructVariant2)
            {
                vectorStructVariant2?.Invoke(VectorStructVariant2!);
            }
            else if (IsVectorStructVariant3)
            {
                vectorStructVariant3?.Invoke(VectorStructVariant3!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsInferenceObject)
            {
                inferenceObject?.Invoke(InferenceObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorStructVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                VectorStructVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                VectorStructVariant3,
                typeof(object),
                Document,
                typeof(global::G.Document),
                Image,
                typeof(global::G.Image),
                InferenceObject,
                typeof(global::G.InferenceObject),
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
        public bool Equals(VectorStruct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorStructVariant1, other.VectorStructVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorStructVariant2, other.VectorStructVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(VectorStructVariant3, other.VectorStructVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Document?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Image?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InferenceObject?>.Default.Equals(InferenceObject, other.InferenceObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStruct obj1, VectorStruct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStruct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStruct obj1, VectorStruct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStruct o && Equals(o);
        }
    }
}
