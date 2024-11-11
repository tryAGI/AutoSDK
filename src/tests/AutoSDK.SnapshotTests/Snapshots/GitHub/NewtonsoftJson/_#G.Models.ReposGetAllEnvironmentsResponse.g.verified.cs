//HintName: G.Models.ReposGetAllEnvironmentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposGetAllEnvironmentsResponse
    {
        /// <summary>
        /// The number of environments in this repository<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<global::G.Environment>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposGetAllEnvironmentsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of environments in this repository<br/>
        /// Example: 5
        /// </param>
        /// <param name="environments"></param>
        public ReposGetAllEnvironmentsResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::G.Environment>? environments)
        {
            this.TotalCount = totalCount;
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposGetAllEnvironmentsResponse" /> class.
        /// </summary>
        public ReposGetAllEnvironmentsResponse()
        {
        }
    }
}