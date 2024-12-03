//HintName: G.Models.UpdateValuesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateValuesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DescriptorField> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateValuesRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="values"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateValuesRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.DescriptorField> values)
        {
            this.ProjectId = projectId;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateValuesRequest" /> class.
        /// </summary>
        public UpdateValuesRequest()
        {
        }
    }
}