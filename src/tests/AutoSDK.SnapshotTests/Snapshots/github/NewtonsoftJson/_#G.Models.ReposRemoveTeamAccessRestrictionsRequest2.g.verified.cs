//HintName: G.Models.ReposRemoveTeamAccessRestrictionsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposRemoveTeamAccessRestrictionsRequest2
    {
        /// <summary>
        /// The slug values for teams
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Teams { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        /// <param name="teams">
        /// The slug values for teams
        /// </param>
        public ReposRemoveTeamAccessRestrictionsRequest2(
            global::System.Collections.Generic.IList<string> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        public ReposRemoveTeamAccessRestrictionsRequest2()
        {
        }
    }
}