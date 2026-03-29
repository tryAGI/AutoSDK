//HintName: G.Models.FailMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailMessage" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="key"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailMessage(
            string description,
            string key,
            object extras)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Extras = extras ?? throw new global::System.ArgumentNullException(nameof(extras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailMessage" /> class.
        /// </summary>
        public FailMessage()
        {
        }
    }
}