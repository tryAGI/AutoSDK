//HintName: G.Models.Locations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for local/location results.
    /// </summary>
    public sealed partial class Locations
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of location results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.LocationResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Locations" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of location results.
        /// </param>
        public Locations(
            string? type,
            global::System.Collections.Generic.IList<global::G.LocationResult>? results)
        {
            this.Type = type;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Locations" /> class.
        /// </summary>
        public Locations()
        {
        }
    }
}