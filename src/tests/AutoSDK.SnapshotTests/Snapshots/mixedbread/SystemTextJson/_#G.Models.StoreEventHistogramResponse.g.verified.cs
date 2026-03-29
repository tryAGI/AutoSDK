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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The histogram of store events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StoreEventHistogramBucket> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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