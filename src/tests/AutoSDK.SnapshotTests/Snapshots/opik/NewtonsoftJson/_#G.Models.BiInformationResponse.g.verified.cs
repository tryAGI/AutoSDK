//HintName: G.Models.BiInformationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BiInformationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bi_information")]
        public global::System.Collections.Generic.IList<global::G.BiInformation>? BiInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformationResponse" /> class.
        /// </summary>
        /// <param name="biInformation"></param>
        public BiInformationResponse(
            global::System.Collections.Generic.IList<global::G.BiInformation>? biInformation)
        {
            this.BiInformation = biInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformationResponse" /> class.
        /// </summary>
        public BiInformationResponse()
        {
        }
    }
}