﻿//HintName: G.Models.GetStreamKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamKeyResponse
    {
        /// <summary>
        /// A list that contains the channel’s stream key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetStreamKeyResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the channel’s stream key.
        /// </param>
        public GetStreamKeyResponse(
            global::System.Collections.Generic.IList<global::G.GetStreamKeyResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponse" /> class.
        /// </summary>
        public GetStreamKeyResponse()
        {
        }
    }
}