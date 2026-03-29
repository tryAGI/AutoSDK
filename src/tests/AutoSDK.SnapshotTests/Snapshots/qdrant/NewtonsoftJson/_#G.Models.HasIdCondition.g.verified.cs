//HintName: G.Models.HasIdCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ID-based filtering condition
    /// </summary>
    public sealed partial class HasIdCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId> HasId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasIdCondition" /> class.
        /// </summary>
        /// <param name="hasId"></param>
        public HasIdCondition(
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> hasId)
        {
            this.HasId = hasId ?? throw new global::System.ArgumentNullException(nameof(hasId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasIdCondition" /> class.
        /// </summary>
        public HasIdCondition()
        {
        }
    }
}