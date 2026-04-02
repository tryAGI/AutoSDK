//HintName: G.Models.VectorInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorInput : global::System.IEquatable<VectorInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? VectorInputVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorInputVariant1))]
#endif
        public bool IsVectorInputVariant1 => VectorInputVariant1 != null;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseVector? Sparse { get; init; }
#else
        public global::G.SparseVector? Sparse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sparse))]
#endif
        public bool IsSparse => Sparse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorInputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorInputVariant3))]
#endif
        public bool IsVectorInputVariant3 => VectorInputVariant3 != null;

        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtendedPointId? ExtendedPointId { get; init; }
#else
        public global::G.ExtendedPointId? ExtendedPointId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtendedPointId))]
#endif
        public bool IsExtendedPointId => ExtendedPointId != null;

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
        public static implicit operator VectorInput(global::G.SparseVector value) => new VectorInput((global::G.SparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseVector?(VectorInput @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::G.SparseVector? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::G.ExtendedPointId value) => new VectorInput((global::G.ExtendedPointId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtendedPointId?(VectorInput @this) => @this.ExtendedPointId;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::G.ExtendedPointId? value)
        {
            ExtendedPointId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::G.Document value) => new VectorInput((global::G.Document?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Document?(VectorInput @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::G.Document? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::G.Image value) => new VectorInput((global::G.Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Image?(VectorInput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::G.Image? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::G.InferenceObject value) => new VectorInput((global::G.InferenceObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InferenceObject?(VectorInput @this) => @this.InferenceObject;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::G.InferenceObject? value)
        {
            InferenceObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(
            global::System.Collections.Generic.IList<float>? vectorInputVariant1,
            global::G.SparseVector? sparse,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorInputVariant3,
            global::G.ExtendedPointId? extendedPointId,
            global::G.Document? document,
            global::G.Image? image,
            global::G.InferenceObject? inferenceObject
            )
        {
            VectorInputVariant1 = vectorInputVariant1;
            Sparse = sparse;
            VectorInputVariant3 = vectorInputVariant3;
            ExtendedPointId = extendedPointId;
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
            ExtendedPointId as object ??
            VectorInputVariant3 as object ??
            Sparse as object ??
            VectorInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorInputVariant1?.ToString() ??
            Sparse?.ToString() ??
            VectorInputVariant3?.ToString() ??
            ExtendedPointId?.ToString() ??
            Document?.ToString() ??
            Image?.ToString() ??
            InferenceObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorInputVariant1 || IsSparse || IsVectorInputVariant3 || IsExtendedPointId || IsDocument || IsImage || IsInferenceObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? vectorInputVariant1 = null,
            global::System.Func<global::G.SparseVector?, TResult>? sparse = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? vectorInputVariant3 = null,
            global::System.Func<global::G.ExtendedPointId?, TResult>? extendedPointId = null,
            global::System.Func<global::G.Document?, TResult>? document = null,
            global::System.Func<global::G.Image?, TResult>? image = null,
            global::System.Func<global::G.InferenceObject?, TResult>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorInputVariant1 && vectorInputVariant1 != null)
            {
                return vectorInputVariant1(VectorInputVariant1!);
            }
            else if (IsSparse && sparse != null)
            {
                return sparse(Sparse!);
            }
            else if (IsVectorInputVariant3 && vectorInputVariant3 != null)
            {
                return vectorInputVariant3(VectorInputVariant3!);
            }
            else if (IsExtendedPointId && extendedPointId != null)
            {
                return extendedPointId(ExtendedPointId!);
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
            global::System.Action<global::System.Collections.Generic.IList<float>?>? vectorInputVariant1 = null,
            global::System.Action<global::G.SparseVector?>? sparse = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? vectorInputVariant3 = null,
            global::System.Action<global::G.ExtendedPointId?>? extendedPointId = null,
            global::System.Action<global::G.Document?>? document = null,
            global::System.Action<global::G.Image?>? image = null,
            global::System.Action<global::G.InferenceObject?>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorInputVariant1)
            {
                vectorInputVariant1?.Invoke(VectorInputVariant1!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
            else if (IsVectorInputVariant3)
            {
                vectorInputVariant3?.Invoke(VectorInputVariant3!);
            }
            else if (IsExtendedPointId)
            {
                extendedPointId?.Invoke(ExtendedPointId!);
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
                VectorInputVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                Sparse,
                typeof(global::G.SparseVector),
                VectorInputVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                ExtendedPointId,
                typeof(global::G.ExtendedPointId),
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
        public bool Equals(VectorInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorInputVariant1, other.VectorInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseVector?>.Default.Equals(Sparse, other.Sparse) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorInputVariant3, other.VectorInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExtendedPointId?>.Default.Equals(ExtendedPointId, other.ExtendedPointId) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Document?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Image?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InferenceObject?>.Default.Equals(InferenceObject, other.InferenceObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorInput obj1, VectorInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorInput obj1, VectorInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorInput o && Equals(o);
        }
    }
}
