//HintName: G.Models.ObjectsGetResponseVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectsGetResponseVariant3
    {
        /// <summary>
        /// Results for this specific Object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.ObjectsGetResponseVariant3Result? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3" /> class.
        /// </summary>
        /// <param name="result">
        /// Results for this specific Object.
        /// </param>
        public ObjectsGetResponseVariant3(
            global::G.ObjectsGetResponseVariant3Result? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3" /> class.
        /// </summary>
        public ObjectsGetResponseVariant3()
        {
        }
    }
}