//HintName: G.Models.PostInternalActionExecutionLogsResponseDataItemApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsResponseDataItemApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemApp" /> class.
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalActionExecutionLogsResponseDataItemApp(
            string icon,
            string name)
        {
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemApp" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsResponseDataItemApp()
        {
        }
    }
}