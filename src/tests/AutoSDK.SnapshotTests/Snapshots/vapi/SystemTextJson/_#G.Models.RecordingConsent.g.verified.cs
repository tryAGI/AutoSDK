//HintName: G.Models.RecordingConsent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordingConsent
    {
        /// <summary>
        /// This is the type of recording consent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// This is the date and time the recording consent was granted.<br/>
        /// If not specified, it means the recording consent was not granted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantedAt")]
        public global::System.DateTime? GrantedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsent" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of recording consent.
        /// </param>
        /// <param name="grantedAt">
        /// This is the date and time the recording consent was granted.<br/>
        /// If not specified, it means the recording consent was not granted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordingConsent(
            object type,
            global::System.DateTime? grantedAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.GrantedAt = grantedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsent" /> class.
        /// </summary>
        public RecordingConsent()
        {
        }
    }
}