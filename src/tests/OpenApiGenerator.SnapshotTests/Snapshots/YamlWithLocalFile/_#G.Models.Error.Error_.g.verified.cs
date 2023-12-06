//HintName: G.Models.Error.Error_.g.cs

#nullable enable

namespace G
{
    public sealed partial class Error
    {
        /// <summary>
        /// 
        /// </summary>
        public sealed class Error_
        {
            /// <summary>
            /// Example: Wrong ip
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// Example: Please provide a valid IP address
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("message")]
            public string? Message { get; set; }

            [global::System.Text.Json.Serialization.JsonExtensionData]
            public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
        }
    }
}