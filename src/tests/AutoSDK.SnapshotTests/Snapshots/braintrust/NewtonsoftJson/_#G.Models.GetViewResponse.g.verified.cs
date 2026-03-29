//HintName: G.Models.GetViewResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetViewResponse
    {
        /// <summary>
        /// A list of view objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.View> Objects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of view objects
        /// </param>
        public GetViewResponse(
            global::System.Collections.Generic.IList<global::G.View> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewResponse" /> class.
        /// </summary>
        public GetViewResponse()
        {
        }
    }
}