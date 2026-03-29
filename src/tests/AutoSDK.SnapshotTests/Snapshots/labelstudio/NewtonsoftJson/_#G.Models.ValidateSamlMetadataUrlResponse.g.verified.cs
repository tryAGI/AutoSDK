//HintName: G.Models.ValidateSamlMetadataUrlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateSamlMetadataUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Valid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlResponse" /> class.
        /// </summary>
        /// <param name="valid"></param>
        public ValidateSamlMetadataUrlResponse(
            bool valid)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlResponse" /> class.
        /// </summary>
        public ValidateSamlMetadataUrlResponse()
        {
        }
    }
}