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
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOrderRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// A list of view IDs in the desired order.
        /// </param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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