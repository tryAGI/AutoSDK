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
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceCategory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceCategory { get; set; }

        /// <summary>
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </summary>
        /// <example>pkg:gem/rails@6.0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceLocator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceLocator { get; set; }

        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </summary>
        /// <example>purl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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