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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsChangelogResponseItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of toolkits with their changelogs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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