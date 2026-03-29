//HintName: G.Models.PayloadSelectorInclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadSelectorInclude
    {
        /// <summary>
        /// Only include this payload keys
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Include { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadSelectorInclude" /> class.
        /// </summary>
        /// <param name="include">
        /// Only include this payload keys
        /// </param>
        public PayloadSelectorInclude(
            global::System.Collections.Generic.IList<string> include)
        {
            this.Include = include ?? throw new global::System.ArgumentNullException(nameof(include));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadSelectorInclude" /> class.
        /// </summary>
        public PayloadSelectorInclude()
        {
        }
    }
}