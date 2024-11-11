//HintName: G.Models.GetContentClassificationLabelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContentClassificationLabelsResponse
    {
        /// <summary>
        /// A list that contains information about the available content classification labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentClassificationLabel> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentClassificationLabelsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the available content classification labels.
        /// </param>
        public GetContentClassificationLabelsResponse(
            global::System.Collections.Generic.IList<global::G.ContentClassificationLabel> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentClassificationLabelsResponse" /> class.
        /// </summary>
        public GetContentClassificationLabelsResponse()
        {
        }
    }
}