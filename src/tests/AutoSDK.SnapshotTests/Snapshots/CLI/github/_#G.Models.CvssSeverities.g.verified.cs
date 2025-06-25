﻿//HintName: G.Models.CvssSeverities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CvssSeverities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_v3")]
        public global::G.CvssSeveritiesCvssV3? CvssV3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_v4")]
        public global::G.CvssSeveritiesCvssV4? CvssV4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CvssSeverities" /> class.
        /// </summary>
        /// <param name="cvssV3"></param>
        /// <param name="cvssV4"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CvssSeverities(
            global::G.CvssSeveritiesCvssV3? cvssV3,
            global::G.CvssSeveritiesCvssV4? cvssV4)
        {
            this.CvssV3 = cvssV3;
            this.CvssV4 = cvssV4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CvssSeverities" /> class.
        /// </summary>
        public CvssSeverities()
        {
        }
    }
}