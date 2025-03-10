﻿//HintName: G.Models.CreateTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateTokenResponse contains the created token.
    /// </summary>
    public sealed partial class CreateTokenResponse
    {
        /// <summary>
        /// The created API token resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public global::G.ApiToken? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The created API token resource.<br/>
        /// Included only in responses
        /// </param>
        public CreateTokenResponse(
            global::G.ApiToken? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenResponse" /> class.
        /// </summary>
        public CreateTokenResponse()
        {
        }
    }
}