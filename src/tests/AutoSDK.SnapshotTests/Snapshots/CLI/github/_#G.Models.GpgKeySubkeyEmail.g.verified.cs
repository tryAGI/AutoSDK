﻿//HintName: G.Models.GpgKeySubkeyEmail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GpgKeySubkeyEmail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeySubkeyEmail" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="verified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpgKeySubkeyEmail(
            string? email,
            bool? verified)
        {
            this.Email = email;
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeySubkeyEmail" /> class.
        /// </summary>
        public GpgKeySubkeyEmail()
        {
        }
    }
}