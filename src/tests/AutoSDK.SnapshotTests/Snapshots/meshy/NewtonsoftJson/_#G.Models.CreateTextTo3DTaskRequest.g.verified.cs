//HintName: G.Models.CreateTextTo3DTaskRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTextTo3DTaskRequest : global::System.IEquatable<CreateTextTo3DTaskRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTextTo3DTaskRequestDiscriminatorMode? Mode { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextTo3DPreviewRequest? Preview { get; init; }
#else
        public global::G.TextTo3DPreviewRequest? Preview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preview))]
#endif
        public bool IsPreview => Preview != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextTo3DRefineRequest? Refine { get; init; }
#else
        public global::G.TextTo3DRefineRequest? Refine { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refine))]
#endif
        public bool IsRefine => Refine != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextTo3DTaskRequest(global::G.TextTo3DPreviewRequest value) => new CreateTextTo3DTaskRequest((global::G.TextTo3DPreviewRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextTo3DPreviewRequest?(CreateTextTo3DTaskRequest @this) => @this.Preview;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextTo3DTaskRequest(global::G.TextTo3DPreviewRequest? value)
        {
            Preview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextTo3DTaskRequest(global::G.TextTo3DRefineRequest value) => new CreateTextTo3DTaskRequest((global::G.TextTo3DRefineRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextTo3DRefineRequest?(CreateTextTo3DTaskRequest @this) => @this.Refine;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextTo3DTaskRequest(global::G.TextTo3DRefineRequest? value)
        {
            Refine = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTextTo3DTaskRequest(
            global::G.CreateTextTo3DTaskRequestDiscriminatorMode? mode,
            global::G.TextTo3DPreviewRequest? preview,
            global::G.TextTo3DRefineRequest? refine
            )
        {
            Mode = mode;

            Preview = preview;
            Refine = refine;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refine as object ??
            Preview as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Preview?.ToString() ??
            Refine?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreview && !IsRefine || !IsPreview && IsRefine;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextTo3DPreviewRequest?, TResult>? preview = null,
            global::System.Func<global::G.TextTo3DRefineRequest?, TResult>? refine = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreview && preview != null)
            {
                return preview(Preview!);
            }
            else if (IsRefine && refine != null)
            {
                return refine(Refine!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextTo3DPreviewRequest?>? preview = null,
            global::System.Action<global::G.TextTo3DRefineRequest?>? refine = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreview)
            {
                preview?.Invoke(Preview!);
            }
            else if (IsRefine)
            {
                refine?.Invoke(Refine!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Preview,
                typeof(global::G.TextTo3DPreviewRequest),
                Refine,
                typeof(global::G.TextTo3DRefineRequest),
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
        public bool Equals(CreateTextTo3DTaskRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextTo3DPreviewRequest?>.Default.Equals(Preview, other.Preview) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextTo3DRefineRequest?>.Default.Equals(Refine, other.Refine) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTextTo3DTaskRequest obj1, CreateTextTo3DTaskRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextTo3DTaskRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTextTo3DTaskRequest obj1, CreateTextTo3DTaskRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextTo3DTaskRequest o && Equals(o);
        }
    }
}
