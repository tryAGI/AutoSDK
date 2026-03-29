//HintName: G.Models.CodeInterpreterServerToolContainer1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeInterpreterServerToolContainer1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterServerToolContainerOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_limit")]
        public global::G.OneOf<global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>? MemoryLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fileIds"></param>
        /// <param name="memoryLimit"></param>
        public CodeInterpreterServerToolContainer1(
            global::G.CodeInterpreterServerToolContainerOneOf1Type type,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::G.OneOf<global::G.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>? memoryLimit)
        {
            this.Type = type;
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer1" /> class.
        /// </summary>
        public CodeInterpreterServerToolContainer1()
        {
        }
    }
}