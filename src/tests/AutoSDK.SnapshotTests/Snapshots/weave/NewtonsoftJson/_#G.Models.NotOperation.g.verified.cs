//HintName: G.Models.NotOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logical NOT. Inverts the condition.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$not": [<br/>
    ///             {"$eq": [{"$getField": "op_name"}, {"$literal": "debug"}]}<br/>
    ///         ]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class NotOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("$not", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] x_not { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotOperation" /> class.
        /// </summary>
        /// <param name="x_not"></param>
        public NotOperation(
            byte[] x_not)
        {
            this.x_not = x_not ?? throw new global::System.ArgumentNullException(nameof(x_not));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotOperation" /> class.
        /// </summary>
        public NotOperation()
        {
        }
    }
}