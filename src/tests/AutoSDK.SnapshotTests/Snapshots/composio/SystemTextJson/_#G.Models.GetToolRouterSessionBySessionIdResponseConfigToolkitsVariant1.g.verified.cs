//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1" /> class.
        /// </summary>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1(
            global::System.Collections.Generic.IList<string> enabled)
        {
            this.Enabled = enabled ?? throw new global::System.ArgumentNullException(nameof(enabled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1()
        {
        }
    }
}