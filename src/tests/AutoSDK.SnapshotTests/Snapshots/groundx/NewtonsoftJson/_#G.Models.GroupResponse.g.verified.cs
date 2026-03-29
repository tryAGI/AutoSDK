//HintName: G.Models.GroupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GroupDetail Group { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse" /> class.
        /// </summary>
        /// <param name="group"></param>
        public GroupResponse(
            global::G.GroupDetail group)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse" /> class.
        /// </summary>
        public GroupResponse()
        {
        }
    }
}