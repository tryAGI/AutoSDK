//HintName: G.Models.UpdateProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom instructions for memory processing in this project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_instructions")]
        public global::System.Collections.Generic.IList<string>? CustomInstructions { get; set; }

        /// <summary>
        /// List of custom categories to be used for memory categorization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_categories")]
        public global::System.Collections.Generic.IList<object>? CustomCategories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="customInstructions">
        /// Custom instructions for memory processing in this project
        /// </param>
        /// <param name="customCategories">
        /// List of custom categories to be used for memory categorization.
        /// </param>
        public UpdateProjectRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? customInstructions,
            global::System.Collections.Generic.IList<object>? customCategories)
        {
            this.Name = name;
            this.Description = description;
            this.CustomInstructions = customInstructions;
            this.CustomCategories = customCategories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }
    }
}