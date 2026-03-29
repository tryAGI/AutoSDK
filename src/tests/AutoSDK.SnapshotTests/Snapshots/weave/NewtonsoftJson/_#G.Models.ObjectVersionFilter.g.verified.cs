//HintName: G.Models.ObjectVersionFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectVersionFilter
    {
        /// <summary>
        /// Filter objects by their base classes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_object_classes")]
        public global::System.Collections.Generic.IList<string>? BaseObjectClasses { get; set; }

        /// <summary>
        /// Exclude objects by their base classes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_base_object_classes")]
        public global::System.Collections.Generic.IList<string>? ExcludeBaseObjectClasses { get; set; }

        /// <summary>
        /// Filter objects by their leaf classes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaf_object_classes")]
        public global::System.Collections.Generic.IList<string>? LeafObjectClasses { get; set; }

        /// <summary>
        /// Filter objects by their IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_ids")]
        public global::System.Collections.Generic.IList<string>? ObjectIds { get; set; }

        /// <summary>
        /// Filter objects based on whether they are weave.ops or not. `True` will only return ops, `False` will return non-ops, and `None` will return all objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_op")]
        public bool? IsOp { get; set; }

        /// <summary>
        /// If True, return only the latest version of each object. `False` and `None` will return all versions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_only")]
        public bool? LatestOnly { get; set; }

        /// <summary>
        /// Filter object versions that have any of the specified tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Filter objects that have any of the specified aliases
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectVersionFilter" /> class.
        /// </summary>
        /// <param name="baseObjectClasses">
        /// Filter objects by their base classes
        /// </param>
        /// <param name="excludeBaseObjectClasses">
        /// Exclude objects by their base classes
        /// </param>
        /// <param name="leafObjectClasses">
        /// Filter objects by their leaf classes
        /// </param>
        /// <param name="objectIds">
        /// Filter objects by their IDs
        /// </param>
        /// <param name="isOp">
        /// Filter objects based on whether they are weave.ops or not. `True` will only return ops, `False` will return non-ops, and `None` will return all objects
        /// </param>
        /// <param name="latestOnly">
        /// If True, return only the latest version of each object. `False` and `None` will return all versions
        /// </param>
        /// <param name="tags">
        /// Filter object versions that have any of the specified tags
        /// </param>
        /// <param name="aliases">
        /// Filter objects that have any of the specified aliases
        /// </param>
        public ObjectVersionFilter(
            global::System.Collections.Generic.IList<string>? baseObjectClasses,
            global::System.Collections.Generic.IList<string>? excludeBaseObjectClasses,
            global::System.Collections.Generic.IList<string>? leafObjectClasses,
            global::System.Collections.Generic.IList<string>? objectIds,
            bool? isOp,
            bool? latestOnly,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.BaseObjectClasses = baseObjectClasses;
            this.ExcludeBaseObjectClasses = excludeBaseObjectClasses;
            this.LeafObjectClasses = leafObjectClasses;
            this.ObjectIds = objectIds;
            this.IsOp = isOp;
            this.LatestOnly = latestOnly;
            this.Tags = tags;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectVersionFilter" /> class.
        /// </summary>
        public ObjectVersionFilter()
        {
        }
    }
}