//HintName: G.Models.TeamOrganizationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamOrganizationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space", Required = global::Newtonsoft.Json.Required.Always)]
        public int Space { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrivateRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filled_seats")]
        public int? FilledSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats")]
        public int? Seats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganizationPlan" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="space"></param>
        /// <param name="privateRepos"></param>
        /// <param name="filledSeats"></param>
        /// <param name="seats"></param>
        public TeamOrganizationPlan(
            string name,
            int space,
            int privateRepos,
            int? filledSeats,
            int? seats)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Space = space;
            this.PrivateRepos = privateRepos;
            this.FilledSeats = filledSeats;
            this.Seats = seats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganizationPlan" /> class.
        /// </summary>
        public TeamOrganizationPlan()
        {
        }
    }
}