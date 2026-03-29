//HintName: G.Models.CreateResponseResponseIncompleteDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about why the response is incomplete.
    /// </summary>
    public sealed partial class CreateResponseResponseIncompleteDetails
    {
        /// <summary>
        /// The reason why the response is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseIncompleteDetails" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason why the response is incomplete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseResponseIncompleteDetails(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseIncompleteDetails" /> class.
        /// </summary>
        public CreateResponseResponseIncompleteDetails()
        {
        }
    }
}