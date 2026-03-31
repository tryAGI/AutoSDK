//HintName: G.Models.UpdateDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing dataset
    /// </summary>
    public sealed partial class UpdateDatasetRequest
    {
        /// <summary>
        /// New name for the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// New description for the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the dataset
        /// </param>
        /// <param name="description">
        /// New description for the dataset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDatasetRequest(
            string name,
            string description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetRequest" /> class.
        /// </summary>
        public UpdateDatasetRequest()
        {
        }
    }
}