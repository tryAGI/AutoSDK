//HintName: G.Models.ApiUpdateProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiUpdateProjectRequest
    {
        /// <summary>
        /// List of target locales
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_locales")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLocales { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiUpdateProjectRequest(
            global::System.Collections.Generic.IList<string> targetLocales)
        {
            this.TargetLocales = targetLocales ?? throw new global::System.ArgumentNullException(nameof(targetLocales));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUpdateProjectRequest" /> class.
        /// </summary>
        public ApiUpdateProjectRequest()
        {
        }
    }
}