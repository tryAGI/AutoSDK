//HintName: G.Models.StoreCostListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreCostListResponse
    {
        /// <summary>
        /// The list of store cost information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StoreCostInfo> Data { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCostListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of store cost information
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreCostListResponse(
            global::System.Collections.Generic.IList<global::G.StoreCostInfo> data,
            string? @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCostListResponse" /> class.
        /// </summary>
        public StoreCostListResponse()
        {
        }
    }
}