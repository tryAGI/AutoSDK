//HintName: G.Models.Source.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A source object containing information about the source of the data cited.
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolSource? ToolOutput { get; init; }
#else
        public global::G.ToolSource? ToolOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolOutput))]
#endif
        public bool IsToolOutput => ToolOutput != null;

        /// <summary>
        /// A document source object containing the unique identifier of the document and the document itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DocumentSource? Document { get; init; }
#else
        public global::G.DocumentSource? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.ToolSource value) => new Source((global::G.ToolSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolSource?(Source @this) => @this.ToolOutput;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.ToolSource? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.DocumentSource value) => new Source((global::G.DocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DocumentSource?(Source @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.DocumentSource? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::G.ToolSource? toolOutput,
            global::G.DocumentSource? document
            )
        {
            ToolOutput = toolOutput;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            ToolOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolOutput?.ToString() ??
            Document?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolOutput && !IsDocument || !IsToolOutput && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolSource?, TResult>? toolOutput = null,
            global::System.Func<global::G.DocumentSource?, TResult>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolOutput && toolOutput != null)
            {
                return toolOutput(ToolOutput!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolSource?>? toolOutput = null,
            global::System.Action<global::G.DocumentSource?>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolOutput,
                typeof(global::G.ToolSource),
                Document,
                typeof(global::G.DocumentSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolSource?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DocumentSource?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
