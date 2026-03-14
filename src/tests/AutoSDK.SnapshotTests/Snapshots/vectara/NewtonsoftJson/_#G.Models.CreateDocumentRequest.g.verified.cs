//HintName: G.Models.CreateDocumentRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Creating a document using this endpoint can take multiple forms depending on how much control of the resulting document parts you desire. You can create a document with natural structure, and Vectara will use its proprietary strategy to create document parts. Otherwise, you can create a document with all the document parts explicitly specified. A document part is the search result item in search and Retrieval Augmented Generation endpoints.<br/>
    /// Example: {"type":"structured","id":"esg_report_2024","title":"2024 ESG Annual Report \u2013 EuroBank","description":"Comprehensive report on EuroBank\u2019s environmental, social, and governance initiatives for 2024, outlining sustainability goals and compliance with EU regulations.","metadata":{"doc_type":"esg_report","region":"EU","industry":"banking","year":2024,"status":"published","owner":"sustainability_team"},"sections":[{"id":1,"title":"Environmental Initiatives","text":"In 2024, EuroBank reduced carbon emissions by 22% through investments in renewable energy and energy-efficient infrastructure.","metadata":{"section_type":"environmental","priority":"high"}},{"id":2,"title":"Social Responsibility","text":"EuroBank expanded its community outreach programs, supporting over 500 local initiatives and increasing employee volunteer hours by 30%.","metadata":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","section_type":"social","priority":"medium"}]}
    /// </summary>
    public readonly partial struct CreateDocumentRequest : global::System.IEquatable<CreateDocumentRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDocumentRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// The document structure that most closely corresponds to Vectara's internal document data model.<br/>
        /// Example: {"id":"invoice-001","type":"core","metadata":{"doc_type":"invoice","industry":"manufacturing"},"tables":[{"id":"billing_table_1","title":"Customer Billing Info","description":"Monthly billing for top manufacturing clients","data":{"headers":[[{"text_value":"Customer Name"},{"text_value":"Balance"},{"text_value":"Account Created"}]],"rows":[[{"text_value":"Acme Corp"},{"float_value":10230.25},{"text_value":"2023-01-15"}],[{"text_value":"Beta Industries"},{"float_value":8750},{"text_value":"2022-11-03"}],[{"text_value":"Zeta Manufacturing"},{"float_value":13499.99},{"text_value":"2023-06-30"}]]}}],"images":[{"id":"image_1","title":"Quarterly Sales Performance","caption":"Sales growth trends for Q1 to Q4 of 2024","description":"A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%","image_data":{"data":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX\u002BAv4N70a4AAAAAElFTkSuQmCC","mime_type":"image/jpeg"}}],"document_parts":[{"text":"This invoice includes customer billing history for Q1.","metadata":{"quarter":1,"year":2023}}],"storage_usage":{"bytes_used":1024,"metadata_bytes_used":256},"extraction_usage":{"table_extraction_used":1}}
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
        public static implicit operator CreateDocumentRequest(global::G.CoreDocument value) => new CreateDocumentRequest((global::G.CoreDocument?)value);

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
        /// 
        /// </summary>
        public static implicit operator CreateDocumentRequest(global::G.StructuredDocument value) => new CreateDocumentRequest((global::G.StructuredDocument?)value);

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
        public override string? ToString() =>
            Core?.ToString() ??
            Structured?.ToString() 
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
