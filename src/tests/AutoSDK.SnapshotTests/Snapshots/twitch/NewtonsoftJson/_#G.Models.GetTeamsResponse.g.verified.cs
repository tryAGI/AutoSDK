﻿//HintName: G.Models.GetTeamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTeamsResponse
    {
        /// <summary>
        /// A list that contains the single team that you requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Team> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single team that you requested.
        /// </param>
        public GetTeamsResponse(
            global::System.Collections.Generic.IList<global::G.Team> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamsResponse" /> class.
        /// </summary>
        public GetTeamsResponse()
        {
        }
    }
}