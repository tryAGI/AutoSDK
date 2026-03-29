//HintName: G.Models.CreateProjectResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponse3
    {
        /// <summary>
        /// Example: Project could not be created.
        /// </summary>
        /// <example>Project could not be created.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Project could not be created.
        /// </param>
        public CreateProjectResponse3(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse3" /> class.
        /// </summary>
        public CreateProjectResponse3()
        {
        }
    }
}