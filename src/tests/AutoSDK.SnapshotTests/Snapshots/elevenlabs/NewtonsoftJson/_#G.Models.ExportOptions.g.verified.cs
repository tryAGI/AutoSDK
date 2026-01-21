//HintName: G.Models.ExportOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExportOptions : global::System.IEquatable<ExportOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportOptionsDiscriminatorFormat? Format { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SegmentedJsonExportOptions? SegmentedJson { get; init; }
#else
        public global::G.SegmentedJsonExportOptions? SegmentedJson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SegmentedJson))]
#endif
        public bool IsSegmentedJson => SegmentedJson != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DocxExportOptions? Docx { get; init; }
#else
        public global::G.DocxExportOptions? Docx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Docx))]
#endif
        public bool IsDocx => Docx != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PdfExportOptions? Pdf { get; init; }
#else
        public global::G.PdfExportOptions? Pdf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pdf))]
#endif
        public bool IsPdf => Pdf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TxtExportOptions? Txt { get; init; }
#else
        public global::G.TxtExportOptions? Txt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Txt))]
#endif
        public bool IsTxt => Txt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HtmlExportOptions? Html { get; init; }
#else
        public global::G.HtmlExportOptions? Html { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Html))]
#endif
        public bool IsHtml => Html != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SrtExportOptions? Srt { get; init; }
#else
        public global::G.SrtExportOptions? Srt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Srt))]
#endif
        public bool IsSrt => Srt != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.SegmentedJsonExportOptions value) => new ExportOptions((global::G.SegmentedJsonExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SegmentedJsonExportOptions?(ExportOptions @this) => @this.SegmentedJson;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.SegmentedJsonExportOptions? value)
        {
            SegmentedJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.DocxExportOptions value) => new ExportOptions((global::G.DocxExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DocxExportOptions?(ExportOptions @this) => @this.Docx;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.DocxExportOptions? value)
        {
            Docx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.PdfExportOptions value) => new ExportOptions((global::G.PdfExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PdfExportOptions?(ExportOptions @this) => @this.Pdf;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.PdfExportOptions? value)
        {
            Pdf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.TxtExportOptions value) => new ExportOptions((global::G.TxtExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TxtExportOptions?(ExportOptions @this) => @this.Txt;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.TxtExportOptions? value)
        {
            Txt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.HtmlExportOptions value) => new ExportOptions((global::G.HtmlExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HtmlExportOptions?(ExportOptions @this) => @this.Html;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.HtmlExportOptions? value)
        {
            Html = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::G.SrtExportOptions value) => new ExportOptions((global::G.SrtExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SrtExportOptions?(ExportOptions @this) => @this.Srt;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::G.SrtExportOptions? value)
        {
            Srt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(
            global::G.ExportOptionsDiscriminatorFormat? format,
            global::G.SegmentedJsonExportOptions? segmentedJson,
            global::G.DocxExportOptions? docx,
            global::G.PdfExportOptions? pdf,
            global::G.TxtExportOptions? txt,
            global::G.HtmlExportOptions? html,
            global::G.SrtExportOptions? srt
            )
        {
            Format = format;

            SegmentedJson = segmentedJson;
            Docx = docx;
            Pdf = pdf;
            Txt = txt;
            Html = html;
            Srt = srt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Srt as object ??
            Html as object ??
            Txt as object ??
            Pdf as object ??
            Docx as object ??
            SegmentedJson as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SegmentedJson?.ToString() ??
            Docx?.ToString() ??
            Pdf?.ToString() ??
            Txt?.ToString() ??
            Html?.ToString() ??
            Srt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && IsDocx && !IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && !IsHtml && IsSrt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SegmentedJsonExportOptions?, TResult>? segmentedJson = null,
            global::System.Func<global::G.DocxExportOptions?, TResult>? docx = null,
            global::System.Func<global::G.PdfExportOptions?, TResult>? pdf = null,
            global::System.Func<global::G.TxtExportOptions?, TResult>? txt = null,
            global::System.Func<global::G.HtmlExportOptions?, TResult>? html = null,
            global::System.Func<global::G.SrtExportOptions?, TResult>? srt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSegmentedJson && segmentedJson != null)
            {
                return segmentedJson(SegmentedJson!);
            }
            else if (IsDocx && docx != null)
            {
                return docx(Docx!);
            }
            else if (IsPdf && pdf != null)
            {
                return pdf(Pdf!);
            }
            else if (IsTxt && txt != null)
            {
                return txt(Txt!);
            }
            else if (IsHtml && html != null)
            {
                return html(Html!);
            }
            else if (IsSrt && srt != null)
            {
                return srt(Srt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SegmentedJsonExportOptions?>? segmentedJson = null,
            global::System.Action<global::G.DocxExportOptions?>? docx = null,
            global::System.Action<global::G.PdfExportOptions?>? pdf = null,
            global::System.Action<global::G.TxtExportOptions?>? txt = null,
            global::System.Action<global::G.HtmlExportOptions?>? html = null,
            global::System.Action<global::G.SrtExportOptions?>? srt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSegmentedJson)
            {
                segmentedJson?.Invoke(SegmentedJson!);
            }
            else if (IsDocx)
            {
                docx?.Invoke(Docx!);
            }
            else if (IsPdf)
            {
                pdf?.Invoke(Pdf!);
            }
            else if (IsTxt)
            {
                txt?.Invoke(Txt!);
            }
            else if (IsHtml)
            {
                html?.Invoke(Html!);
            }
            else if (IsSrt)
            {
                srt?.Invoke(Srt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SegmentedJson,
                typeof(global::G.SegmentedJsonExportOptions),
                Docx,
                typeof(global::G.DocxExportOptions),
                Pdf,
                typeof(global::G.PdfExportOptions),
                Txt,
                typeof(global::G.TxtExportOptions),
                Html,
                typeof(global::G.HtmlExportOptions),
                Srt,
                typeof(global::G.SrtExportOptions),
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
        public bool Equals(ExportOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SegmentedJsonExportOptions?>.Default.Equals(SegmentedJson, other.SegmentedJson) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DocxExportOptions?>.Default.Equals(Docx, other.Docx) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PdfExportOptions?>.Default.Equals(Pdf, other.Pdf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TxtExportOptions?>.Default.Equals(Txt, other.Txt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HtmlExportOptions?>.Default.Equals(Html, other.Html) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SrtExportOptions?>.Default.Equals(Srt, other.Srt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExportOptions obj1, ExportOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExportOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExportOptions obj1, ExportOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExportOptions o && Equals(o);
        }
    }
}
