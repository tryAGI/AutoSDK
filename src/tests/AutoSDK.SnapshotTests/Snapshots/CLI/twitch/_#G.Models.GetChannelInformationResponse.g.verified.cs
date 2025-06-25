﻿//HintName: G.Models.GetChannelInformationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelInformationResponse
    {
        /// <summary>
        /// A list that contains information about the specified channels. The list is empty if the specified channels weren’t found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelInformation> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelInformationResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the specified channels. The list is empty if the specified channels weren’t found.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelInformationResponse(
            global::System.Collections.Generic.IList<global::G.ChannelInformation> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelInformationResponse" /> class.
        /// </summary>
        public GetChannelInformationResponse()
        {
        }
    }
}