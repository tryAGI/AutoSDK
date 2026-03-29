//HintName: G.Models.AddProjectMemberResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectMemberResponse2
    {
        /// <summary>
        /// Example: Unauthorized to modify project members.
        /// </summary>
        /// <example>Unauthorized to modify project members.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectMemberResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized to modify project members.
        /// </param>
        public AddProjectMemberResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectMemberResponse2" /> class.
        /// </summary>
        public AddProjectMemberResponse2()
        {
        }
    }
}