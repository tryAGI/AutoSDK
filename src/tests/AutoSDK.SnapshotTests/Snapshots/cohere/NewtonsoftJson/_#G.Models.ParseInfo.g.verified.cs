﻿//HintName: G.Models.ParseInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    public sealed partial class ParseInfo
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseInfo" /> class.
        /// </summary>
        /// <param name="delimiter">
        /// Included only in requests
        /// </param>
        /// <param name="separator">
        /// Included only in requests
        /// </param>
        public ParseInfo(
            string? delimiter,
            string? separator)
        {
            this.Delimiter = delimiter;
            this.Separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseInfo" /> class.
        /// </summary>
        public ParseInfo()
        {
        }
    }
}