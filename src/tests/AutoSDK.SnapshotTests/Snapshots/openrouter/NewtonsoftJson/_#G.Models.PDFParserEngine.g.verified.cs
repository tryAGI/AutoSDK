//HintName: G.Models.PDFParserEngine.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The engine to use for parsing PDF files. "pdf-text" is deprecated and automatically redirected to "cloudflare-ai".
    /// </summary>
    public readonly partial struct PDFParserEngine : global::System.IEquatable<PDFParserEngine>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PdfParserEngine0? PdfParserEngine0 { get; init; }
#else
        public global::G.PdfParserEngine0? PdfParserEngine0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PdfParserEngine0))]
#endif
        public bool IsPdfParserEngine0 => PdfParserEngine0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PdfParserEngine1? PdfParserEngine1 { get; init; }
#else
        public global::G.PdfParserEngine1? PdfParserEngine1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PdfParserEngine1))]
#endif
        public bool IsPdfParserEngine1 => PdfParserEngine1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PDFParserEngine(global::G.PdfParserEngine0 value) => new PDFParserEngine((global::G.PdfParserEngine0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PdfParserEngine0?(PDFParserEngine @this) => @this.PdfParserEngine0;

        /// <summary>
        /// 
        /// </summary>
        public PDFParserEngine(global::G.PdfParserEngine0? value)
        {
            PdfParserEngine0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PDFParserEngine(global::G.PdfParserEngine1 value) => new PDFParserEngine((global::G.PdfParserEngine1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PdfParserEngine1?(PDFParserEngine @this) => @this.PdfParserEngine1;

        /// <summary>
        /// 
        /// </summary>
        public PDFParserEngine(global::G.PdfParserEngine1? value)
        {
            PdfParserEngine1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PDFParserEngine(
            global::G.PdfParserEngine0? pdfParserEngine0,
            global::G.PdfParserEngine1? pdfParserEngine1
            )
        {
            PdfParserEngine0 = pdfParserEngine0;
            PdfParserEngine1 = pdfParserEngine1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PdfParserEngine1 as object ??
            PdfParserEngine0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PdfParserEngine0?.ToValueString() ??
            PdfParserEngine1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPdfParserEngine0 && !IsPdfParserEngine1 || !IsPdfParserEngine0 && IsPdfParserEngine1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PdfParserEngine0?, TResult>? pdfParserEngine0 = null,
            global::System.Func<global::G.PdfParserEngine1?, TResult>? pdfParserEngine1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfParserEngine0 && pdfParserEngine0 != null)
            {
                return pdfParserEngine0(PdfParserEngine0!);
            }
            else if (IsPdfParserEngine1 && pdfParserEngine1 != null)
            {
                return pdfParserEngine1(PdfParserEngine1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PdfParserEngine0?>? pdfParserEngine0 = null,
            global::System.Action<global::G.PdfParserEngine1?>? pdfParserEngine1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfParserEngine0)
            {
                pdfParserEngine0?.Invoke(PdfParserEngine0!);
            }
            else if (IsPdfParserEngine1)
            {
                pdfParserEngine1?.Invoke(PdfParserEngine1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PdfParserEngine0,
                typeof(global::G.PdfParserEngine0),
                PdfParserEngine1,
                typeof(global::G.PdfParserEngine1),
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
        public bool Equals(PDFParserEngine other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PdfParserEngine0?>.Default.Equals(PdfParserEngine0, other.PdfParserEngine0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PdfParserEngine1?>.Default.Equals(PdfParserEngine1, other.PdfParserEngine1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PDFParserEngine obj1, PDFParserEngine obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PDFParserEngine>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PDFParserEngine obj1, PDFParserEngine obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PDFParserEngine o && Equals(o);
        }
    }
}
