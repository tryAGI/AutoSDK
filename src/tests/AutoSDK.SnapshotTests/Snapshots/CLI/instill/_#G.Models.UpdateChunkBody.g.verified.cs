﻿//HintName: G.Models.UpdateChunkBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChunkBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkBody" /> class.
        /// </summary>
        /// <param name="retrievable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChunkBody(
            bool? retrievable)
        {
            this.Retrievable = retrievable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkBody" /> class.
        /// </summary>
        public UpdateChunkBody()
        {
        }
    }
}