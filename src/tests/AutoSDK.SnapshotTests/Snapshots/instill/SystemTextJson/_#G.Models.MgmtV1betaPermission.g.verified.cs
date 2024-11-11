//HintName: G.Models.MgmtV1betaPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a resource can be used.
    /// </summary>
    public sealed partial class MgmtV1betaPermission
    {
        /// <summary>
        /// Defines whether the resource can be modified.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaPermission" /> class.
        /// </summary>
        /// <param name="canEdit">
        /// Defines whether the resource can be modified.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MgmtV1betaPermission(
            bool? canEdit)
        {
            this.CanEdit = canEdit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaPermission" /> class.
        /// </summary>
        public MgmtV1betaPermission()
        {
        }
    }
}