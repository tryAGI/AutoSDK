//HintName: G.Models.ProjectsMoveColumnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsMoveColumnRequest
    {
        /// <summary>
        /// The position of the column in a project. Can be one of: `first`, `last`, or `after:&lt;column_id&gt;` to place after the specified column.<br/>
        /// Example: last
        /// </summary>
        /// <example>last</example>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public string Position { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveColumnRequest" /> class.
        /// </summary>
        /// <param name="position">
        /// The position of the column in a project. Can be one of: `first`, `last`, or `after:&lt;column_id&gt;` to place after the specified column.<br/>
        /// Example: last
        /// </param>
        public ProjectsMoveColumnRequest(
            string position)
        {
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveColumnRequest" /> class.
        /// </summary>
        public ProjectsMoveColumnRequest()
        {
        }
    }
}