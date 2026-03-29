//HintName: G.Models.OrganizationMemberTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMemberTagRequest
    {
        /// <summary>
        /// Label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// Label
        /// </param>
        public OrganizationMemberTagRequest(
            string label)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagRequest" /> class.
        /// </summary>
        public OrganizationMemberTagRequest()
        {
        }
    }
}