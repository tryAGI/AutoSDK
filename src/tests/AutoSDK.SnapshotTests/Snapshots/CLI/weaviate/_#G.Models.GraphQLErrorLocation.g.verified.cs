﻿//HintName: G.Models.GraphQLErrorLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphQLErrorLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public long? Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public long? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLErrorLocation" /> class.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="line"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphQLErrorLocation(
            long? column,
            long? line)
        {
            this.Column = column;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLErrorLocation" /> class.
        /// </summary>
        public GraphQLErrorLocation()
        {
        }
    }
}