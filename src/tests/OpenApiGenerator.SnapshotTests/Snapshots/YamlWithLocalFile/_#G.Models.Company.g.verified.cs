//HintName: G.Models.Company.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Company
    {
        /// <summary>
        /// <br/>Example: Sprint Springfield POP
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: sprint.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public required string Domain { get; set; }

        /// <summary>
        /// <br/>Example: isp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public required TypeEnum Type { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}