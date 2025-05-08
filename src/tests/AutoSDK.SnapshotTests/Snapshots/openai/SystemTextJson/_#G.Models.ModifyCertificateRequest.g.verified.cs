//HintName: G.Models.ModifyCertificateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyCertificateRequest
    {
        /// <summary>
        /// The updated name for the certificate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyCertificateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The updated name for the certificate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyCertificateRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyCertificateRequest" /> class.
        /// </summary>
        public ModifyCertificateRequest()
        {
        }
    }
}