﻿//HintName: G.Models.MinimalRepositoryPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MinimalRepositoryPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintain")]
        public bool? Maintain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triage")]
        public bool? Triage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull")]
        public bool? Pull { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalRepositoryPermissions" /> class.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="maintain"></param>
        /// <param name="push"></param>
        /// <param name="triage"></param>
        /// <param name="pull"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MinimalRepositoryPermissions(
            bool? admin,
            bool? maintain,
            bool? push,
            bool? triage,
            bool? pull)
        {
            this.Admin = admin;
            this.Maintain = maintain;
            this.Push = push;
            this.Triage = triage;
            this.Pull = pull;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalRepositoryPermissions" /> class.
        /// </summary>
        public MinimalRepositoryPermissions()
        {
        }
    }
}