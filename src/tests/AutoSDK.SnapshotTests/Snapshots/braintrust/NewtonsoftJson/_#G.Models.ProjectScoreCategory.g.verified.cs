//HintName: G.Models.ProjectScoreCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For categorical-type project scores, defines a single category
    /// </summary>
    public sealed partial class ProjectScoreCategory
    {
        /// <summary>
        /// Name of the category
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Numerical value of the category. Must be between 0 and 1, inclusive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCategory" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the category
        /// </param>
        /// <param name="value">
        /// Numerical value of the category. Must be between 0 and 1, inclusive
        /// </param>
        public ProjectScoreCategory(
            string name,
            double value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCategory" /> class.
        /// </summary>
        public ProjectScoreCategory()
        {
        }
    }
}