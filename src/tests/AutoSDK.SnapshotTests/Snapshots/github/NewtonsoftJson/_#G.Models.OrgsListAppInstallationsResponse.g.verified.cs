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
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Installation> Installations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAppInstallationsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="installations"></param>
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