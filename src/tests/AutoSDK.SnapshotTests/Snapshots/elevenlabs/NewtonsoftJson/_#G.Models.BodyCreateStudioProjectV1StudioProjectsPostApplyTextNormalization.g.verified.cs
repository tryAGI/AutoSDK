//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
    ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
    ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
    ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
    ///     
    /// </summary>
    public sealed partial class BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}