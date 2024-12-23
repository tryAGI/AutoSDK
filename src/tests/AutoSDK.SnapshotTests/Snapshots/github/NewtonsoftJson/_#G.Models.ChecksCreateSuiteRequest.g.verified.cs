﻿//HintName: G.Models.ChecksCreateSuiteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateSuiteRequest
    {
        /// <summary>
        /// The sha of the head commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateSuiteRequest" /> class.
        /// </summary>
        /// <param name="headSha">
        /// The sha of the head commit.
        /// </param>
        public ChecksCreateSuiteRequest(
            string headSha)
        {
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateSuiteRequest" /> class.
        /// </summary>
        public ChecksCreateSuiteRequest()
        {
        }
    }
}