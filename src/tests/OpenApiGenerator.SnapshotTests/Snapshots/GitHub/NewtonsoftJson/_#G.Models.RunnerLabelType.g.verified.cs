//HintName: G.Models.RunnerLabelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of label. Read-only labels are applied automatically when the runner is configured.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunnerLabelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read-only")]
        ReadOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
    }
}