//HintName: G.Models.OrgsListAppInstallationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsListAppInstallationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Installation> Installations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAppInstallationsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="installations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgsListAppInstallationsResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Installation> installations)
        {
            this.TotalCount = totalCount;
            this.Installations = installations ?? throw new global::System.ArgumentNullException(nameof(installations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAppInstallationsResponse" /> class.
        /// </summary>
        public OrgsListAppInstallationsResponse()
        {
        }
    }
}