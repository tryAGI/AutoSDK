﻿//HintName: G.Models.ChecksCreateRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ChecksCreateRequestVariant2Status? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestVariant2" /> class.
        /// </summary>
        /// <param name="status"></param>
        public ChecksCreateRequestVariant2(
            global::G.ChecksCreateRequestVariant2Status? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestVariant2" /> class.
        /// </summary>
        public ChecksCreateRequestVariant2()
        {
        }
    }
}