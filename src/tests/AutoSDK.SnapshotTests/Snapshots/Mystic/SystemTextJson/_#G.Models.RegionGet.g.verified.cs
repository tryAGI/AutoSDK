//HintName: G.Models.RegionGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RegionGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SelfLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zones")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        /// <param name="selfLink"></param>
        /// <param name="status"></param>
        /// <param name="zones"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RegionGet(
            int id,
            string kind,
            string name,
            string selfLink,
            string status,
            global::System.Collections.Generic.IList<string> zones)
        {
            this.Id = id;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SelfLink = selfLink ?? throw new global::System.ArgumentNullException(nameof(selfLink));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Zones = zones ?? throw new global::System.ArgumentNullException(nameof(zones));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionGet" /> class.
        /// </summary>
        public RegionGet()
        {
        }
    }
}