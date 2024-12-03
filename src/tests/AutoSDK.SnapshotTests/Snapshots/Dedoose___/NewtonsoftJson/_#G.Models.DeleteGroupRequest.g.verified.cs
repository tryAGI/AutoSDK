//HintName: G.Models.DeleteGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserGroup Group { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGroupRequest" /> class.
        /// </summary>
        /// <param name="group"></param>
        public DeleteGroupRequest(
            global::G.UserGroup group)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGroupRequest" /> class.
        /// </summary>
        public DeleteGroupRequest()
        {
        }
    }
}