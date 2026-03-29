//HintName: G.Models.AddIceCandidateRequestVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddIceCandidateRequestVariant12
    {
        /// <summary>
        /// A string representing the transport address for the candidate that can be used for connectivity checks.<br/>
        /// The format of this address is a candidate-attribute as defined in RFC 5245. This string is empty ("") if the<br/>
        /// RTCIceCandidate is an "end of candidates" indicator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidate", Required = global::Newtonsoft.Json.Required.Always)]
        public string Candidate { get; set; } = default!;

        /// <summary>
        /// A string specifying the candidate's media stream identification tag which uniquely identifies the media stream<br/>
        /// within the component with which the candidate is associated, or null if no such association exists.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdpMid", Required = global::Newtonsoft.Json.Required.Always)]
        public string SdpMid { get; set; } = default!;

        /// <summary>
        /// If not null, sdpMLineIndex indicates the zero-based index number of the media description (as defined in RFC<br/>
        /// 4566) in the SDP with which the candidate is associated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdpMLineIndex", Required = global::Newtonsoft.Json.Required.Always)]
        public double SdpMLineIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIceCandidateRequestVariant12" /> class.
        /// </summary>
        /// <param name="candidate">
        /// A string representing the transport address for the candidate that can be used for connectivity checks.<br/>
        /// The format of this address is a candidate-attribute as defined in RFC 5245. This string is empty ("") if the<br/>
        /// RTCIceCandidate is an "end of candidates" indicator.
        /// </param>
        /// <param name="sdpMid">
        /// A string specifying the candidate's media stream identification tag which uniquely identifies the media stream<br/>
        /// within the component with which the candidate is associated, or null if no such association exists.
        /// </param>
        /// <param name="sdpMLineIndex">
        /// If not null, sdpMLineIndex indicates the zero-based index number of the media description (as defined in RFC<br/>
        /// 4566) in the SDP with which the candidate is associated.
        /// </param>
        public AddIceCandidateRequestVariant12(
            string candidate,
            string sdpMid,
            double sdpMLineIndex)
        {
            this.Candidate = candidate ?? throw new global::System.ArgumentNullException(nameof(candidate));
            this.SdpMid = sdpMid ?? throw new global::System.ArgumentNullException(nameof(sdpMid));
            this.SdpMLineIndex = sdpMLineIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIceCandidateRequestVariant12" /> class.
        /// </summary>
        public AddIceCandidateRequestVariant12()
        {
        }
    }
}