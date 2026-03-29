//HintName: G.Models.PostToolRouterSessionResponseConfigToolkitsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfigToolkitsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolkitsVariant1" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        public PostToolRouterSessionResponseConfigToolkitsVariant1(
            global::System.Collections.Generic.IList<string> enabled)
        {
            this.Enabled = enabled ?? throw new global::System.ArgumentNullException(nameof(enabled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolkitsVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfigToolkitsVariant1()
        {
        }
    }
}