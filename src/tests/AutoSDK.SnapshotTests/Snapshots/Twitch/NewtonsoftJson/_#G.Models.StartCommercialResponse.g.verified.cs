//HintName: G.Models.StartCommercialResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCommercialResponse
    {
        /// <summary>
        /// An array that contains a single object with the status of your start commercial request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StartCommercialResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains a single object with the status of your start commercial request.
        /// </param>
        public StartCommercialResponse(
            global::System.Collections.Generic.IList<global::G.StartCommercialResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialResponse" /> class.
        /// </summary>
        public StartCommercialResponse()
        {
        }
    }
}