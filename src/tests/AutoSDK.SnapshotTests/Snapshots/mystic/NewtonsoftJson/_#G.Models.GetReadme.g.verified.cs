﻿//HintName: G.Models.GetReadme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class GetReadme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReadme" /> class.
        /// </summary>
        /// <param name="readme"></param>
        public GetReadme(
            string? readme)
        {
            this.Readme = readme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReadme" /> class.
        /// </summary>
        public GetReadme()
        {
        }
    }
}