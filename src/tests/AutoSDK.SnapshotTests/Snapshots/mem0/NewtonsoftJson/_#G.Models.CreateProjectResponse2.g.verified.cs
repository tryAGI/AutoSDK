//HintName: G.Models.CreateProjectResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponse2
    {
        /// <summary>
        /// Example: Unauthorized to create projects in this organization.
        /// </summary>
        /// <example>Unauthorized to create projects in this organization.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized to create projects in this organization.
        /// </param>
        public CreateProjectResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse2" /> class.
        /// </summary>
        public CreateProjectResponse2()
        {
        }
    }
}