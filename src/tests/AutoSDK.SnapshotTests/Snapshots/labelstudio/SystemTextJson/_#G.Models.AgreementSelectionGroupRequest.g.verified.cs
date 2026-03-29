//HintName: G.Models.AgreementSelectionGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgreementSelectionGroupRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementSelectionGroupRequest" /> class.
        /// </summary>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="ids">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgreementSelectionGroupRequest(
            bool? all,
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.All = all;
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementSelectionGroupRequest" /> class.
        /// </summary>
        public AgreementSelectionGroupRequest()
        {
        }
    }
}