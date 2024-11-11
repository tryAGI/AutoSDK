//HintName: G.Models.AddBlockedTermResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBlockedTermResponse
    {
        /// <summary>
        /// A list that contains the single blocked term that the broadcaster added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BlockedTerm> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBlockedTermResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single blocked term that the broadcaster added.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddBlockedTermResponse(
            global::System.Collections.Generic.IList<global::G.BlockedTerm> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBlockedTermResponse" /> class.
        /// </summary>
        public AddBlockedTermResponse()
        {
        }
    }
}