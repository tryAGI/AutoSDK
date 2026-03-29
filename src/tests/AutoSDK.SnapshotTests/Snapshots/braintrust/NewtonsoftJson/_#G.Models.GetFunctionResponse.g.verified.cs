//HintName: G.Models.GetFunctionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFunctionResponse
    {
        /// <summary>
        /// A list of function objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Function2> Objects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFunctionResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of function objects
        /// </param>
        public GetFunctionResponse(
            global::System.Collections.Generic.IList<global::G.Function2> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFunctionResponse" /> class.
        /// </summary>
        public GetFunctionResponse()
        {
        }
    }
}