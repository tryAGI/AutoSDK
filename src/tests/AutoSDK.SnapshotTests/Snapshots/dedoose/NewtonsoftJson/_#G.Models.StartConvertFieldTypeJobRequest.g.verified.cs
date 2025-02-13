﻿//HintName: G.Models.StartConvertFieldTypeJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConvertFieldTypeJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FieldId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newFieldType", Required = global::Newtonsoft.Json.Required.Always)]
        public int NewFieldType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertFieldTypeJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldId"></param>
        /// <param name="newFieldType"></param>
        public StartConvertFieldTypeJobRequest(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Guid fieldId,
            int newFieldType)
        {
            this.ProjectId = projectId;
            this.SetId = setId;
            this.FieldId = fieldId;
            this.NewFieldType = newFieldType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertFieldTypeJobRequest" /> class.
        /// </summary>
        public StartConvertFieldTypeJobRequest()
        {
        }
    }
}