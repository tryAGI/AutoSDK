//HintName: G.Models.ReposRemoveStatusCheckContextsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"contexts":["contexts"]}
    /// </summary>
    public sealed partial class ReposRemoveStatusCheckContextsRequest2
    {
        /// <summary>
        /// The name of the status checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contexts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Contexts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveStatusCheckContextsRequest2" /> class.
        /// </summary>
        /// <param name="contexts">
        /// The name of the status checks
        /// </param>
        public ReposRemoveStatusCheckContextsRequest2(
            global::System.Collections.Generic.IList<string> contexts)
        {
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveStatusCheckContextsRequest2" /> class.
        /// </summary>
        public ReposRemoveStatusCheckContextsRequest2()
        {
        }
    }
}