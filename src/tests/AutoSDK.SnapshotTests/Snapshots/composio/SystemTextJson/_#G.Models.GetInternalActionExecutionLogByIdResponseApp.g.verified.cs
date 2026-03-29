//HintName: G.Models.GetInternalActionExecutionLogByIdResponseApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UniqueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseApp" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="uniqueId"></param>
        /// <param name="icon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalActionExecutionLogByIdResponseApp(
            string name,
            string uniqueId,
            string icon)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UniqueId = uniqueId ?? throw new global::System.ArgumentNullException(nameof(uniqueId));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseApp" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseApp()
        {
        }
    }
}