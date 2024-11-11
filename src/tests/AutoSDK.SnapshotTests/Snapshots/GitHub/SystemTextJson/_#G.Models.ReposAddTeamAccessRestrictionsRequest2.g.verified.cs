//HintName: G.Models.ReposAddTeamAccessRestrictionsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposAddTeamAccessRestrictionsRequest2
    {
        /// <summary>
        /// The slug values for teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        /// <param name="teams">
        /// The slug values for teams
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposAddTeamAccessRestrictionsRequest2(
            global::System.Collections.Generic.IList<string> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        public ReposAddTeamAccessRestrictionsRequest2()
        {
        }
    }
}