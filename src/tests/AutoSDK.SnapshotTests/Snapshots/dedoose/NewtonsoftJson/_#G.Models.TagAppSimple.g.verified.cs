﻿//HintName: G.Models.TagAppSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagAppSimple
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagId")]
        public global::System.Guid? TagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagWeight")]
        public double? TagWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagAppSimple" /> class.
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="tagWeight"></param>
        public TagAppSimple(
            global::System.Guid? tagId,
            double? tagWeight)
        {
            this.TagId = tagId;
            this.TagWeight = tagWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagAppSimple" /> class.
        /// </summary>
        public TagAppSimple()
        {
        }
    }
}