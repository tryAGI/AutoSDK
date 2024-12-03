//HintName: G.Models.AddDescriptorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddDescriptorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldValues", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldValueDTO> FieldValues { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDescriptorRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldValues"></param>
        public AddDescriptorRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> fieldValues)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.SetId = setId;
            this.FieldValues = fieldValues ?? throw new global::System.ArgumentNullException(nameof(fieldValues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDescriptorRequest" /> class.
        /// </summary>
        public AddDescriptorRequest()
        {
        }
    }
}