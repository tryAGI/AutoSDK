//HintName: G.Models.DependencyGraphSpdxSbomSbomPackageExternalRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomPackageExternalRef
    {
        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: PACKAGE-MANAGER
        /// </summary>
        /// <example>PACKAGE-MANAGER</example>
        [global::Newtonsoft.Json.JsonProperty("referenceCategory", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceCategory { get; set; } = default!;

        /// <summary>
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </summary>
        /// <example>pkg:gem/rails@6.0.1</example>
        [global::Newtonsoft.Json.JsonProperty("referenceLocator", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceLocator { get; set; } = default!;

        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </summary>
        /// <example>purl</example>
        [global::Newtonsoft.Json.JsonProperty("referenceType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackageExternalRef" /> class.
        /// </summary>
        /// <param name="referenceCategory">
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: PACKAGE-MANAGER
        /// </param>
        /// <param name="referenceLocator">
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </param>
        /// <param name="referenceType">
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </param>
        public DependencyGraphSpdxSbomSbomPackageExternalRef(
            string referenceCategory,
            string referenceLocator,
            string referenceType)
        {
            this.ReferenceCategory = referenceCategory ?? throw new global::System.ArgumentNullException(nameof(referenceCategory));
            this.ReferenceLocator = referenceLocator ?? throw new global::System.ArgumentNullException(nameof(referenceLocator));
            this.ReferenceType = referenceType ?? throw new global::System.ArgumentNullException(nameof(referenceType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackageExternalRef" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbomPackageExternalRef()
        {
        }
    }
}