﻿//HintName: G.Models.Permission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a pipeline can be used.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Defines whether the pipeline can be modified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Defines whether the pipeline can be executed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canTrigger")]
        public bool? CanTrigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="canEdit">
        /// Defines whether the pipeline can be modified.
        /// </param>
        /// <param name="canTrigger">
        /// Defines whether the pipeline can be executed.
        /// </param>
        public Permission(
            bool? canEdit,
            bool? canTrigger)
        {
            this.CanEdit = canEdit;
            this.CanTrigger = canTrigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }
    }
}