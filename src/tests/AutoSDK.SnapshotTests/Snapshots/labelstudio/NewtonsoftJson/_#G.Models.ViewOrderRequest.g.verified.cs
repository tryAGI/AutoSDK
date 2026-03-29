//HintName: G.Models.ViewOrderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOrderRequest
    {
        /// <summary>
        /// A list of view IDs in the desired order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOrderRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// A list of view IDs in the desired order.
        /// </param>
        /// <param name="project"></param>
        public ViewOrderRequest(
            global::System.Collections.Generic.IList<int> ids,
            int project)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOrderRequest" /> class.
        /// </summary>
        public ViewOrderRequest()
        {
        }
    }
}