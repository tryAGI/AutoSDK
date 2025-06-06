﻿//HintName: G.Models.AuditLogUserAddedData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to add the user to the project.
    /// </summary>
    public sealed partial class AuditLogUserAddedData
    {
        /// <summary>
        /// The role of the user. Is either `owner` or `member`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserAddedData" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the user. Is either `owner` or `member`.
        /// </param>
        public AuditLogUserAddedData(
            string? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserAddedData" /> class.
        /// </summary>
        public AuditLogUserAddedData()
        {
        }
    }
}