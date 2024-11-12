//HintName: G.Models.CreateDocumentRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Creating a document using this endpoint can take multiple forms depending on how much<br/>
    /// control of the resulting document parts you desire. You can create a document<br/>
    /// with natural structure, and Vectara will use it's proprietary strategy to create document parts.<br/>
    /// Otherwise, you can create a document with all the document parts explicitly specified.<br/>
    /// A document part is the a search result item in search and retrieval augmented generation endpoints.
    /// </summary>
    public readonly partial struct CreateDocumentRequest : global::System.IEquatable<CreateDocumentRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDocumentRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// The document structure that most closely corresponds to Vectara's internal document data model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CoreDocument? Core { get; init; }
#else
        public global::G.CoreDocument? Core { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Core))]
#endif
        public bool IsCore => Core != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentRequest(global::G.CoreDocument value) => new CreateDocumentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CoreDocument?(CreateDocumentRequest @this) => @this.Core;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(global::G.CoreDocument? value)
        {
            Core = value;
        }

        /// <summary>
        /// A document with layout features.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StructuredDocument? Structured { get; init; }
#else
        public global::G.StructuredDocument? Structured { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Structured))]
#endif
        public bool IsStructured => Structured != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentRequest(global::G.StructuredDocument value) => new CreateDocumentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredDocument?(CreateDocumentRequest @this) => @this.Structured;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(global::G.StructuredDocument? value)
        {
            Structured = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(
            global::G.CreateDocumentRequestDiscriminatorType? type,
            global::G.CoreDocument? core,
            global::G.StructuredDocument? structured
            )
        {
            Type = type;

            Core = core;
            Structured = structured;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Structured as object ??
            Core as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCore && !IsStructured || !IsCore && IsStructured;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CoreDocument?, TResult>? core = null,
            global::System.Func<global::G.StructuredDocument?, TResult>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCore && core != null)
            {
                return core(Core!);
            }
            else if (IsStructured && structured != null)
            {
                return structured(Structured!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CoreDocument?>? core = null,
            global::System.Action<global::G.StructuredDocument?>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCore)
            {
                core?.Invoke(Core!);
            }
            else if (IsStructured)
            {
                structured?.Invoke(Structured!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Core,
                typeof(global::G.CoreDocument),
                Structured,
                typeof(global::G.StructuredDocument),
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
        public bool Equals(CreateDocumentRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CoreDocument?>.Default.Equals(Core, other.Core) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredDocument?>.Default.Equals(Structured, other.Structured) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateDocumentRequest obj1, CreateDocumentRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateDocumentRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateDocumentRequest obj1, CreateDocumentRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateDocumentRequest o && Equals(o);
        }
    }
}
