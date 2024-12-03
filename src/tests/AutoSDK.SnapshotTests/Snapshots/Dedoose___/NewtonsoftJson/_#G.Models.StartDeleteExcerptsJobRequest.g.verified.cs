//HintName: G.Models.StartDeleteExcerptsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDeleteExcerptsJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentProjectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteExcerptsJobRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        public StartDeleteExcerptsJobRequest(
            global::System.Guid currentProjectId,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds)
        {
            this.CurrentProjectId = currentProjectId;
            this.ExcerptIds = excerptIds ?? throw new global::System.ArgumentNullException(nameof(excerptIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteExcerptsJobRequest" /> class.
        /// </summary>
        public StartDeleteExcerptsJobRequest()
        {
        }
    }
}