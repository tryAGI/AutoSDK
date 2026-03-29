//HintName: G.Models.StoreEventHistogramResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreEventHistogramResponse
    {
        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: store.histogram
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The histogram of store events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StoreEventHistogramBucket> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The histogram of store events
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: store.histogram
        /// </param>
        public StoreEventHistogramResponse(
            global::System.Collections.Generic.IList<global::G.StoreEventHistogramBucket> data,
            string? @object)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramResponse" /> class.
        /// </summary>
        public StoreEventHistogramResponse()
        {
        }
    }
}