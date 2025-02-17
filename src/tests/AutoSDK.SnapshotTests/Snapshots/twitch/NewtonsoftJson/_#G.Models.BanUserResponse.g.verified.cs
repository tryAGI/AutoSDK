﻿//HintName: G.Models.BanUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BanUserResponse
    {
        /// <summary>
        /// A list that contains the user you successfully banned or put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BanUserResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the user you successfully banned or put in a timeout.
        /// </param>
        public BanUserResponse(
            global::System.Collections.Generic.IList<global::G.BanUserResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserResponse" /> class.
        /// </summary>
        public BanUserResponse()
        {
        }
    }
}