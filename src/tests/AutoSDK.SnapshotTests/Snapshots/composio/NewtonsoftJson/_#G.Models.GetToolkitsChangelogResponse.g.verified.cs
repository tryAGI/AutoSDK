//HintName: G.Models.GetToolkitsChangelogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsChangelogResponse
    {
        /// <summary>
        /// List of toolkits with their changelogs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsChangelogResponseItem> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of toolkits with their changelogs
        /// </param>
        public GetToolkitsChangelogResponse(
            global::System.Collections.Generic.IList<global::G.GetToolkitsChangelogResponseItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponse" /> class.
        /// </summary>
        public GetToolkitsChangelogResponse()
        {
        }
    }
}