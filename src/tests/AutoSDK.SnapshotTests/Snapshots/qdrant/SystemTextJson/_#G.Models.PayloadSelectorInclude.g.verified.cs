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
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadSelectorInclude" /> class.
        /// </summary>
        /// <param name="include">
        /// Only include this payload keys
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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