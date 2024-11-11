//HintName: G.Models.SingleRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either set beacon (direct reference) or set class and schema (concept reference)
    /// </summary>
    public sealed partial class SingleRef
    {
        /// <summary>
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("beacon")]
        public string? Beacon { get; set; }

        /// <summary>
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href")]
        public string? Href { get; set; }

        /// <summary>
        /// This meta field contains additional info about the classified reference property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification")]
        public global::G.ReferenceMetaClassification? Classification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRef" /> class.
        /// </summary>
        /// <param name="class">
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </param>
        /// <param name="schema">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="beacon">
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </param>
        /// <param name="href">
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </param>
        /// <param name="classification">
        /// This meta field contains additional info about the classified reference property
        /// </param>
        public SingleRef(
            string? @class,
            object? schema,
            string? beacon,
            string? href,
            global::G.ReferenceMetaClassification? classification)
        {
            this.Class = @class;
            this.Schema = schema;
            this.Beacon = beacon;
            this.Href = href;
            this.Classification = classification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRef" /> class.
        /// </summary>
        public SingleRef()
        {
        }
    }
}