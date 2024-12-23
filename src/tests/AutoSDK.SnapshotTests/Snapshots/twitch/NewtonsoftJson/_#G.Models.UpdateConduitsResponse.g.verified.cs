﻿//HintName: G.Models.UpdateConduitsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitsResponse
    {
        /// <summary>
        /// List of information about the client’s conduits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UpdateConduitsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of information about the client’s conduits.
        /// </param>
        public UpdateConduitsResponse(
            global::System.Collections.Generic.IList<global::G.UpdateConduitsResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitsResponse" /> class.
        /// </summary>
        public UpdateConduitsResponse()
        {
        }
    }
}