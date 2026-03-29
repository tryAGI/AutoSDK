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
        [global::Newtonsoft.Json.JsonProperty("finetunes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Finetunes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyFinetunesResponse" /> class.
        /// </summary>
        /// <param name="finetunes">
        /// List of finetunes created by the user
        /// </param>
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