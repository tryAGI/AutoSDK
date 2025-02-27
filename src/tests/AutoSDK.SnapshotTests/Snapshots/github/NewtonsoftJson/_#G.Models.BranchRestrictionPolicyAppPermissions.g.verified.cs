﻿//HintName: G.Models.BranchRestrictionPolicyAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public string? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues")]
        public string? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("single_file")]
        public string? SingleFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppPermissions" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="contents"></param>
        /// <param name="issues"></param>
        /// <param name="singleFile"></param>
        public BranchRestrictionPolicyAppPermissions(
            string? metadata,
            string? contents,
            string? issues,
            string? singleFile)
        {
            this.Metadata = metadata;
            this.Contents = contents;
            this.Issues = issues;
            this.SingleFile = singleFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppPermissions" /> class.
        /// </summary>
        public BranchRestrictionPolicyAppPermissions()
        {
        }
    }
}