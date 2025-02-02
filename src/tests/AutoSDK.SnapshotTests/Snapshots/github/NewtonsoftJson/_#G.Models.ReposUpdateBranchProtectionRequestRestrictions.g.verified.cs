﻿//HintName: G.Models.ReposUpdateBranchProtectionRequestRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
    /// </summary>
    public sealed partial class ReposUpdateBranchProtectionRequestRestrictions
    {
        /// <summary>
        /// The list of user `login`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Users { get; set; } = default!;

        /// <summary>
        /// The list of team `slug`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Teams { get; set; } = default!;

        /// <summary>
        /// The list of app `slug`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRestrictions" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s with push access
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s with push access
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s with push access
        /// </param>
        public ReposUpdateBranchProtectionRequestRestrictions(
            global::System.Collections.Generic.IList<string> users,
            global::System.Collections.Generic.IList<string> teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRestrictions" /> class.
        /// </summary>
        public ReposUpdateBranchProtectionRequestRestrictions()
        {
        }
    }
}