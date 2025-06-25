﻿//HintName: G.Models.Principal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Principal
    {
        /// <summary>
        /// The username that was extracted either from the authentication information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Principal" /> class.
        /// </summary>
        /// <param name="username">
        /// The username that was extracted either from the authentication information
        /// </param>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Principal(
            string? username,
            global::System.Collections.Generic.IList<string>? groups)
        {
            this.Username = username;
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Principal" /> class.
        /// </summary>
        public Principal()
        {
        }
    }
}