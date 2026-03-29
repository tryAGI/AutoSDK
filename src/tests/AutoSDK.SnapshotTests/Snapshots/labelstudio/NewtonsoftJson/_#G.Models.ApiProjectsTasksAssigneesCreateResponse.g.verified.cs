//HintName: G.Models.ApiProjectsTasksAssigneesCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsTasksAssigneesCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignments")]
        public int? Assignments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreateResponse" /> class.
        /// </summary>
        /// <param name="assignments"></param>
        /// <param name="async"></param>
        public ApiProjectsTasksAssigneesCreateResponse(
            int? assignments,
            bool? async)
        {
            this.Assignments = assignments;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreateResponse" /> class.
        /// </summary>
        public ApiProjectsTasksAssigneesCreateResponse()
        {
        }
    }
}