//HintName: G.Models.ApiProjectsStatsIaaRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsIaaRetrieveResponse
    {
        /// <summary>
        /// Inter-Annotator Agreement matrix - 2D array when per_label=false, object with label keys when per_label=true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IAA")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>))]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Iaa { get; set; }

        /// <summary>
        /// Common tasks matrix - 2D array when per_label=false, object with label keys when per_label=true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_tasks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>))]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? CommonTasks { get; set; }

        /// <summary>
        /// Standard deviation - number when per_label=false, object with label keys when per_label=true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("std")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Std { get; set; }

        /// <summary>
        /// List of users in the matrix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<object>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsIaaRetrieveResponse" /> class.
        /// </summary>
        /// <param name="iaa">
        /// Inter-Annotator Agreement matrix - 2D array when per_label=false, object with label keys when per_label=true
        /// </param>
        /// <param name="commonTasks">
        /// Common tasks matrix - 2D array when per_label=false, object with label keys when per_label=true
        /// </param>
        /// <param name="std">
        /// Standard deviation - number when per_label=false, object with label keys when per_label=true
        /// </param>
        /// <param name="users">
        /// List of users in the matrix
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsIaaRetrieveResponse(
            global::G.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? iaa,
            global::G.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? commonTasks,
            global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? std,
            global::System.Collections.Generic.IList<object>? users)
        {
            this.Iaa = iaa;
            this.CommonTasks = commonTasks;
            this.Std = std;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsIaaRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsIaaRetrieveResponse()
        {
        }
    }
}