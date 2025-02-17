﻿//HintName: G.Models.NullableCommunityHealthFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NullableCommunityHealthFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableCommunityHealthFile" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        public NullableCommunityHealthFile(
            string url,
            string htmlUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableCommunityHealthFile" /> class.
        /// </summary>
        public NullableCommunityHealthFile()
        {
        }
    }
}