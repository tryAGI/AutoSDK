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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// New description for the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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