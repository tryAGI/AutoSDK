//HintName: G.Models.StartReshardingOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartReshardingOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_resharding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StartResharding StartResharding { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartReshardingOperation" /> class.
        /// </summary>
        /// <param name="startResharding"></param>
        public StartReshardingOperation(
            global::G.StartResharding startResharding)
        {
            this.StartResharding = startResharding ?? throw new global::System.ArgumentNullException(nameof(startResharding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartReshardingOperation" /> class.
        /// </summary>
        public StartReshardingOperation()
        {
        }
    }
}