﻿//HintName: G.Models.Deprecation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Deprecation
    {
        /// <summary>
        /// The id that uniquely identifies this particular deprecations (mostly used internally)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether the problematic API functionality is deprecated (planned to be removed) or already removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Describes which API is effected, usually one of: REST, GraphQL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiType")]
        public string? ApiType { get; set; }

        /// <summary>
        /// What this deprecation is about
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// User-required object to not be affected by the (planned) removal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigation")]
        public string? Mitigation { get; set; }

        /// <summary>
        /// The deprecation was introduced in this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sinceVersion")]
        public string? SinceVersion { get; set; }

        /// <summary>
        /// A best-effort guess of which upcoming version will remove the feature entirely
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plannedRemovalVersion")]
        public string? PlannedRemovalVersion { get; set; }

        /// <summary>
        /// If the feature has already been removed, it was removed in this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedIn")]
        public string? RemovedIn { get; set; }

        /// <summary>
        /// If the feature has already been removed, it was removed at this timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedTime")]
        public global::System.DateTime? RemovedTime { get; set; }

        /// <summary>
        /// The deprecation was introduced in this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sinceTime")]
        public global::System.DateTime? SinceTime { get; set; }

        /// <summary>
        /// The locations within the specified API affected by this deprecation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<string>? Locations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deprecation" /> class.
        /// </summary>
        /// <param name="id">
        /// The id that uniquely identifies this particular deprecations (mostly used internally)
        /// </param>
        /// <param name="status">
        /// Whether the problematic API functionality is deprecated (planned to be removed) or already removed
        /// </param>
        /// <param name="apiType">
        /// Describes which API is effected, usually one of: REST, GraphQL
        /// </param>
        /// <param name="msg">
        /// What this deprecation is about
        /// </param>
        /// <param name="mitigation">
        /// User-required object to not be affected by the (planned) removal
        /// </param>
        /// <param name="sinceVersion">
        /// The deprecation was introduced in this version
        /// </param>
        /// <param name="plannedRemovalVersion">
        /// A best-effort guess of which upcoming version will remove the feature entirely
        /// </param>
        /// <param name="removedIn">
        /// If the feature has already been removed, it was removed in this version
        /// </param>
        /// <param name="removedTime">
        /// If the feature has already been removed, it was removed at this timestamp
        /// </param>
        /// <param name="sinceTime">
        /// The deprecation was introduced in this version
        /// </param>
        /// <param name="locations">
        /// The locations within the specified API affected by this deprecation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Deprecation(
            string? id,
            string? status,
            string? apiType,
            string? msg,
            string? mitigation,
            string? sinceVersion,
            string? plannedRemovalVersion,
            string? removedIn,
            global::System.DateTime? removedTime,
            global::System.DateTime? sinceTime,
            global::System.Collections.Generic.IList<string>? locations)
        {
            this.Id = id;
            this.Status = status;
            this.ApiType = apiType;
            this.Msg = msg;
            this.Mitigation = mitigation;
            this.SinceVersion = sinceVersion;
            this.PlannedRemovalVersion = plannedRemovalVersion;
            this.RemovedIn = removedIn;
            this.RemovedTime = removedTime;
            this.SinceTime = sinceTime;
            this.Locations = locations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deprecation" /> class.
        /// </summary>
        public Deprecation()
        {
        }
    }
}