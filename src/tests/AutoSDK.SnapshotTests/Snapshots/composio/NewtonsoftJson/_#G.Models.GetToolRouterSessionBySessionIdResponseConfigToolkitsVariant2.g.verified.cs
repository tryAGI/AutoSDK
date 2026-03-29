//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Disabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2" /> class.
        /// </summary>
        /// <param name="disabled"></param>
        public GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2(
            global::System.Collections.Generic.IList<string> disabled)
        {
            this.Disabled = disabled ?? throw new global::System.ArgumentNullException(nameof(disabled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2()
        {
        }
    }
}