//HintName: G.Models.NamespaceSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of a namespace.
    /// </summary>
    public sealed partial class NamespaceSummary
    {
        /// <summary>
        /// The namespace ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The namespace ID.
        /// </param>
        public NamespaceSummary(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceSummary" /> class.
        /// </summary>
        public NamespaceSummary()
        {
        }
    }
}