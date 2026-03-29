//HintName: G.Models.MyFinetunesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MyFinetunesResponse
    {
        /// <summary>
        /// List of finetunes created by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetunes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Finetunes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyFinetunesResponse" /> class.
        /// </summary>
        /// <param name="finetunes">
        /// List of finetunes created by the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MyFinetunesResponse(
            global::System.Collections.Generic.IList<object> finetunes)
        {
            this.Finetunes = finetunes ?? throw new global::System.ArgumentNullException(nameof(finetunes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyFinetunesResponse" /> class.
        /// </summary>
        public MyFinetunesResponse()
        {
        }
    }
}